namespace OLKI.Programme.BwDemo
{
    partial class frmMainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.btnProcessPause = new System.Windows.Forms.Button();
            this.txtProgressPercent = new System.Windows.Forms.TextBox();
            this.txtProgressValue = new System.Windows.Forms.TextBox();
            this.pbaProgress = new System.Windows.Forms.ProgressBar();
            this.btnProcessCancel = new System.Windows.Forms.Button();
            this.btnProcessStart = new System.Windows.Forms.Button();
            this.nudLoops = new System.Windows.Forms.NumericUpDown();
            this.nudSleep = new System.Windows.Forms.NumericUpDown();
            this.lblLoops = new System.Windows.Forms.Label();
            this.lblSleep = new System.Windows.Forms.Label();
            this.chkModalMsg = new System.Windows.Forms.CheckBox();
            this.chkModalForm = new System.Windows.Forms.CheckBox();
            this.nudModalMsg = new System.Windows.Forms.NumericUpDown();
            this.nudModalForm = new System.Windows.Forms.NumericUpDown();
            this.txtRemainingTime = new System.Windows.Forms.TextBox();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.txtElapsedTime = new System.Windows.Forms.TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModalMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModalForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcessPause
            // 
            this.btnProcessPause.Enabled = false;
            this.btnProcessPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPause.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessPause.Image")));
            this.btnProcessPause.Location = new System.Drawing.Point(288, 194);
            this.btnProcessPause.Name = "btnProcessPause";
            this.btnProcessPause.Size = new System.Drawing.Size(74, 68);
            this.btnProcessPause.TabIndex = 11;
            this.btnProcessPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcessPause.UseVisualStyleBackColor = true;
            this.btnProcessPause.Click += new System.EventHandler(this.btnProcessPause_Click);
            // 
            // txtProgressPercent
            // 
            this.txtProgressPercent.Location = new System.Drawing.Point(368, 271);
            this.txtProgressPercent.Name = "txtProgressPercent";
            this.txtProgressPercent.ReadOnly = true;
            this.txtProgressPercent.Size = new System.Drawing.Size(35, 20);
            this.txtProgressPercent.TabIndex = 14;
            // 
            // txtProgressValue
            // 
            this.txtProgressValue.Location = new System.Drawing.Point(409, 271);
            this.txtProgressValue.Name = "txtProgressValue";
            this.txtProgressValue.ReadOnly = true;
            this.txtProgressValue.Size = new System.Drawing.Size(163, 20);
            this.txtProgressValue.TabIndex = 15;
            // 
            // pbaProgress
            // 
            this.pbaProgress.Location = new System.Drawing.Point(12, 268);
            this.pbaProgress.Name = "pbaProgress";
            this.pbaProgress.Size = new System.Drawing.Size(350, 23);
            this.pbaProgress.TabIndex = 13;
            // 
            // btnProcessCancel
            // 
            this.btnProcessCancel.Enabled = false;
            this.btnProcessCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProcessCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessCancel.Image")));
            this.btnProcessCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessCancel.Location = new System.Drawing.Point(368, 194);
            this.btnProcessCancel.Name = "btnProcessCancel";
            this.btnProcessCancel.Size = new System.Drawing.Size(204, 68);
            this.btnProcessCancel.TabIndex = 12;
            this.btnProcessCancel.Text = "Abbrechen";
            this.btnProcessCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcessCancel.UseVisualStyleBackColor = true;
            this.btnProcessCancel.Click += new System.EventHandler(this.btnProcessCancel_Click);
            // 
            // btnProcessStart
            // 
            this.btnProcessStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessStart.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessStart.Image")));
            this.btnProcessStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessStart.Location = new System.Drawing.Point(12, 194);
            this.btnProcessStart.Name = "btnProcessStart";
            this.btnProcessStart.Size = new System.Drawing.Size(270, 68);
            this.btnProcessStart.TabIndex = 10;
            this.btnProcessStart.Text = "Daten verschieben";
            this.btnProcessStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcessStart.UseVisualStyleBackColor = true;
            this.btnProcessStart.Click += new System.EventHandler(this.btnProcessStart_Click);
            // 
            // nudLoops
            // 
            this.nudLoops.Location = new System.Drawing.Point(125, 12);
            this.nudLoops.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLoops.Name = "nudLoops";
            this.nudLoops.Size = new System.Drawing.Size(120, 20);
            this.nudLoops.TabIndex = 1;
            this.nudLoops.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudSleep
            // 
            this.nudSleep.Location = new System.Drawing.Point(125, 38);
            this.nudSleep.Name = "nudSleep";
            this.nudSleep.Size = new System.Drawing.Size(120, 20);
            this.nudSleep.TabIndex = 3;
            this.nudSleep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblLoops
            // 
            this.lblLoops.AutoSize = true;
            this.lblLoops.Location = new System.Drawing.Point(12, 14);
            this.lblLoops.Name = "lblLoops";
            this.lblLoops.Size = new System.Drawing.Size(80, 13);
            this.lblLoops.TabIndex = 0;
            this.lblLoops.Text = "Schleifenlänge:";
            // 
            // lblSleep
            // 
            this.lblSleep.AutoSize = true;
            this.lblSleep.Location = new System.Drawing.Point(12, 40);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(107, 13);
            this.lblSleep.TabIndex = 2;
            this.lblSleep.Text = "Pause pro Durchlauf:";
            // 
            // chkModalMsg
            // 
            this.chkModalMsg.AutoSize = true;
            this.chkModalMsg.Checked = true;
            this.chkModalMsg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModalMsg.Location = new System.Drawing.Point(125, 64);
            this.chkModalMsg.Name = "chkModalMsg";
            this.chkModalMsg.Size = new System.Drawing.Size(177, 17);
            this.chkModalMsg.TabIndex = 4;
            this.chkModalMsg.Text = "Modale Dialogbox bei Durchlauf";
            this.chkModalMsg.UseVisualStyleBackColor = true;
            // 
            // chkModalForm
            // 
            this.chkModalForm.AutoSize = true;
            this.chkModalForm.Checked = true;
            this.chkModalForm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModalForm.Location = new System.Drawing.Point(125, 91);
            this.chkModalForm.Name = "chkModalForm";
            this.chkModalForm.Size = new System.Drawing.Size(175, 17);
            this.chkModalForm.TabIndex = 6;
            this.chkModalForm.Text = "Modales Formular bei Durchlauf";
            this.chkModalForm.UseVisualStyleBackColor = true;
            // 
            // nudModalMsg
            // 
            this.nudModalMsg.Location = new System.Drawing.Point(308, 64);
            this.nudModalMsg.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudModalMsg.Name = "nudModalMsg";
            this.nudModalMsg.Size = new System.Drawing.Size(120, 20);
            this.nudModalMsg.TabIndex = 5;
            this.nudModalMsg.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudModalForm
            // 
            this.nudModalForm.Location = new System.Drawing.Point(308, 90);
            this.nudModalForm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudModalForm.Name = "nudModalForm";
            this.nudModalForm.Size = new System.Drawing.Size(120, 20);
            this.nudModalForm.TabIndex = 7;
            this.nudModalForm.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtRemainingTime
            // 
            this.txtRemainingTime.Location = new System.Drawing.Point(119, 168);
            this.txtRemainingTime.Name = "txtRemainingTime";
            this.txtRemainingTime.ReadOnly = true;
            this.txtRemainingTime.Size = new System.Drawing.Size(163, 20);
            this.txtRemainingTime.TabIndex = 9;
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(12, 171);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(93, 13);
            this.lblRemainingTime.TabIndex = 8;
            this.lblRemainingTime.Text = "Verbleibende Zeit:";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Location = new System.Drawing.Point(12, 146);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(89, 13);
            this.lblElapsedTime.TabIndex = 16;
            this.lblElapsedTime.Text = "Vergangene Zeit:";
            // 
            // txtElapsedTime
            // 
            this.txtElapsedTime.Location = new System.Drawing.Point(119, 143);
            this.txtElapsedTime.Name = "txtElapsedTime";
            this.txtElapsedTime.ReadOnly = true;
            this.txtElapsedTime.Size = new System.Drawing.Size(163, 20);
            this.txtElapsedTime.TabIndex = 17;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(12, 119);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(48, 13);
            this.lblStartTime.TabIndex = 18;
            this.lblStartTime.Text = "Startzeit:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(119, 117);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ReadOnly = true;
            this.txtStartTime.Size = new System.Drawing.Size(163, 20);
            this.txtStartTime.TabIndex = 19;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 303);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.txtElapsedTime);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.txtRemainingTime);
            this.Controls.Add(this.nudModalForm);
            this.Controls.Add(this.nudModalMsg);
            this.Controls.Add(this.chkModalForm);
            this.Controls.Add(this.chkModalMsg);
            this.Controls.Add(this.lblSleep);
            this.Controls.Add(this.lblLoops);
            this.Controls.Add(this.nudSleep);
            this.Controls.Add(this.nudLoops);
            this.Controls.Add(this.btnProcessPause);
            this.Controls.Add(this.txtProgressPercent);
            this.Controls.Add(this.txtProgressValue);
            this.Controls.Add(this.pbaProgress);
            this.Controls.Add(this.btnProcessCancel);
            this.Controls.Add(this.btnProcessStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BwDemo";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.nudLoops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModalMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModalForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnProcessPause;
        internal System.Windows.Forms.TextBox txtProgressPercent;
        internal System.Windows.Forms.TextBox txtProgressValue;
        internal System.Windows.Forms.ProgressBar pbaProgress;
        internal System.Windows.Forms.Button btnProcessCancel;
        internal System.Windows.Forms.Button btnProcessStart;
        private System.Windows.Forms.NumericUpDown nudLoops;
        private System.Windows.Forms.NumericUpDown nudSleep;
        private System.Windows.Forms.Label lblLoops;
        private System.Windows.Forms.CheckBox chkModalMsg;
        private System.Windows.Forms.CheckBox chkModalForm;
        private System.Windows.Forms.NumericUpDown nudModalMsg;
        private System.Windows.Forms.NumericUpDown nudModalForm;
        private System.Windows.Forms.Label lblSleep;
        internal System.Windows.Forms.TextBox txtRemainingTime;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label lblElapsedTime;
        internal System.Windows.Forms.TextBox txtElapsedTime;
        private System.Windows.Forms.Label lblStartTime;
        internal System.Windows.Forms.TextBox txtStartTime;
    }
}

