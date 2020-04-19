/*
 * BwDemo- BackgroundWorker Demo
 * 
 * Copyright:   Oliver Kind - 2020
 * License:     LGPL
 * 
 * Desctiption:
 * The MainForm of the application
 * 
 * 
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the LGPL General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed WITHOUT ANY WARRANTY; without even the implied
 * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * LGPL General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not check the GitHub-Repository.
 * 
 * */

using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace OLKI.Programme.BwDemo
{
    public partial class frmMainForm : Form
    {
        #region Constants
        /// <summary>
        /// Format for progress percentage field
        /// </summary>
        private const string FORMAT_PERCENTAGE = "{0}%";
        /// <summary>
        /// Format for progress value field, while moving files
        /// </summary>
        private const string FORMAT_VALUE_MOVE = "{0} / {1}";
        /// <summary>
        /// Number format for value field
        /// </summary>
        private const string FORMAT_VALUE_NUMBER = "N0";
        #endregion

        #region Fields
        /// <summary>
        /// Backgroundworker for count and move files
        /// </summary>
        private readonly BackgroundWorker _bgwWorker;
        /// <summary>
        /// Locks to lock the BackgroundWorker
        /// </summary>
        private readonly ManualResetEvent _locker = new ManualResetEvent(true);
        //private DateTime _progressStartTime = new DateTime();
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new MainForm
        /// </summary>
        public frmMainForm()
        {
            InitializeComponent();

            this._bgwWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgwWorker.DoWork += new DoWorkEventHandler(this.bgwWorker_DoWork);
            this._bgwWorker.ProgressChanged += new ProgressChangedEventHandler(this.bgwWorker_ProgressChanged);
            this._bgwWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwWorker_RunWorkerCompleted);
        }

        #region Form events
        private void MainForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            SubForms.AboutForm AboutForm = new SubForms.AboutForm();
            AboutForm.ShowDialog(this);
            AboutForm.Dispose();
            e.Cancel = true;
        }

        #region Controle Buttons
        private void btnProcessCancel_Click(object sender, EventArgs e)
        {
            this._locker.Reset();
            if (MessageBox.Show(this, src.Forms.frmMainForm_Stringtable._0x0001m, src.Forms.frmMainForm_Stringtable._0x0001c, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.btnProcessStart.Enabled = true;
                this.btnProcessPause.Enabled = false;
                this.btnProcessCancel.Enabled = false;
                this.nudLoops.Enabled = true;
                this.nudSleep.Enabled = true;
                this.chkModalMsg.Enabled = true;
                this.nudModalMsg.Enabled = true;
                this.chkModalForm.Enabled = true;
                this.nudModalForm.Enabled = true;

                this._bgwWorker.CancelAsync();
            }
            this._locker.Set();
        }

        private void btnProcessPause_Click(object sender, EventArgs e)
        {
            this.btnProcessStart.Enabled = true;
            this.btnProcessPause.Enabled = false;
            this.btnProcessCancel.Enabled = true;

            this._locker.Reset();
        }

        private void btnProcessStart_Click(object sender, EventArgs e)
        {
            DialogResult Selection = (DialogResult)this.Invoke((Func<DialogResult>)(() => new DummyForm().ShowDialog()));

            this.btnProcessStart.Enabled = false;
            this.btnProcessPause.Enabled = true;
            this.btnProcessCancel.Enabled = true;
            this.nudLoops.Enabled = false;
            this.nudSleep.Enabled = false;
            this.chkModalMsg.Enabled = false;
            this.nudModalMsg.Enabled = false;
            this.chkModalForm.Enabled = false;
            this.nudModalForm.Enabled = false;
            this.txtStartTime.Text = "";
            this.txtElapsedTime.Text = "";
            this.txtRemainingTime.Text = "";
            this.pbaProgress.Value = 0;
            this.txtProgressPercent.Text = "0";

            this._locker.Set();
            if (!this._bgwWorker.IsBusy) this._bgwWorker.RunWorkerAsync();
        }
        #endregion
        #endregion

        #region BackgroundWorker events
        private void bgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int ProgressPercent;

            ProgressState State = new ProgressState
            {
                MaxlValue = (int)this.nudLoops.Value,
                StartTime = DateTime.Now
            };
            this._bgwWorker.ReportProgress(0, State);

            for (decimal i = 0; i < this.nudLoops.Value; i++)
            {
                //Pause worker
                this._locker.WaitOne();

                // Cancel worker
                if (this._bgwWorker.CancellationPending) { e.Cancel = true; this._bgwWorker.CancelAsync(); return; }

                //Show a Modal dialogbox
                if (this.chkModalMsg.Checked && this.nudModalMsg.Value == i)
                {
                    DialogResult Selection = (DialogResult)this.Invoke((Func<DialogResult>)(() => MessageBox.Show(src.Forms.frmMainForm_Stringtable._0x0002m, src.Forms.frmMainForm_Stringtable._0x0002c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)));
                    this.Invoke((Func<DialogResult>)(() => MessageBox.Show(string.Format(src.Forms.frmMainForm_Stringtable._0x0003m, Selection.ToString()), src.Forms.frmMainForm_Stringtable._0x0003c, MessageBoxButtons.OK, MessageBoxIcon.Information)));
                }

                //Show a Modal form
                if (this.chkModalForm.Checked && this.nudModalForm.Value == i)
                {
                    Form xy = new DummyForm();
                    DialogResult Selection = (DialogResult)this.Invoke((Func<DialogResult>)(() => xy.ShowDialog()));
                    this.Invoke((Func<DialogResult>)(() => MessageBox.Show(string.Format(src.Forms.frmMainForm_Stringtable._0x0004m, Selection.ToString()), src.Forms.frmMainForm_Stringtable._0x0004c, MessageBoxButtons.OK, MessageBoxIcon.Information)));
                }

                // Dummy for program functions
                Thread.Sleep((int)this.nudSleep.Value);

                // Report progress
                ProgressPercent = (int)OLKI.Tools.CommonTools.Matehmatics.Percentages(i, this.nudLoops.Value);
                State.ActualValue = i;
                this._bgwWorker.ReportProgress(ProgressPercent, State);
            }
        }

        private void bgwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressState State = (ProgressState)e.UserState;

            this.txtStartTime.Text = State.StartTime.ToString();
            this.txtElapsedTime.Text = State.ElapsedTime.ToString();
            this.txtRemainingTime.Text = State.RemainingTime.ToString();

            this.pbaProgress.Value = e.ProgressPercentage;
            this.txtProgressPercent.Text = string.Format(FORMAT_PERCENTAGE, e.ProgressPercentage);
            this.txtProgressValue.Text = string.Format(FORMAT_VALUE_MOVE, new object[] { State.ActualValue.ToString(FORMAT_VALUE_NUMBER), State.MaxlValue.ToString(FORMAT_VALUE_NUMBER) });
        }

        private void bgwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btnProcessStart.Enabled = true;
            this.btnProcessPause.Enabled = false;
            this.btnProcessCancel.Enabled = false;
            this.nudLoops.Enabled = true;
            this.nudSleep.Enabled = true;
            this.chkModalMsg.Enabled = true;
            this.nudModalMsg.Enabled = true;
            this.chkModalForm.Enabled = true;
            this.nudModalForm.Enabled = true;

            //MessageBox.Show(this, string.Format(Stringtable._0x00002m, new object[] { this._fileMover.FileTotalCount, this._fileMover.FileMove, this._fileMover.FileSkip, this._fileMover.FileExceptions }), Stringtable._0x00002c, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #endregion
    }
}