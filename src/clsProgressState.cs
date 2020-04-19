/*
  * BwDemo- BackgroundWorker Demo
 * 
 * Copyright:   Oliver Kind - 2020
 * License:     LGPL
 * 
 * Desctiption:
 * A class to store the progess of an backup or restore process
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

namespace OLKI.Programme.BwDemo
{
    class ProgressState
    {
        public decimal ActualValue { get; set; } = 0;
        public decimal MaxlValue { get; set; } = 0;

        public DateTime StartTime { get; set; }

        public TimeSpan ElapsedTime
        {
            get
            {
                return DateTime.Now - this.StartTime;
            }
        }

        public TimeSpan RemainingTime
        {
            get
            {
                return OLKI.Tools.CommonTools.Matehmatics.RemainingTime(this.ElapsedTime, (long)ActualValue, (long)MaxlValue);
            }
        }
    }
}