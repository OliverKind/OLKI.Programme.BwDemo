/*
 * Extractet from: OLKI.Tools.CommonTools (Version:  6.2.0.16)
 * 
 * Copyright:   Oliver Kind - 2019
 * License:     LGPL
 * 
 * Desctiption:
 * Class that provides mathematical tools
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

namespace OLKI.Tools.CommonTools
{
    /// <summary>
    /// Class that provides mathematical tools
    /// </summary>
    public static class Matehmatics
    {
        #region Constants
        /// <summary>
        /// The number of digits returnd by percentages calculation by default
        /// </summary>
        private const int DEFAULT_PERCENTAGES_DIGITS = 0;
        #endregion

        #region Methodes
        #region Percentage
        /// <summary>
        /// Calculate the percentage value from a diven Quotation and a basic value
        /// </summary>
        /// <param name="percentageQuotation">Specifies the quotation for percent calculation</param>
        /// <param name="basicValue">Specifies the basic value for percent calculation</param>
        /// <returns>Ther percentage value of a given qoutation and a basic value with none digits</returns>
        public static double Percentages(decimal percentageQuotation, decimal basicValue)
        {
            return Percentages((double)percentageQuotation, (double)basicValue, DEFAULT_PERCENTAGES_DIGITS);
        }
        /// <summary>
        /// Calculate the percentage value from a diven Quotation and a basic value
        /// </summary>
        /// <param name="percentageQuotation">Specifies the quotation for percent calculation</param>
        /// <param name="basicValue">Specifies the basic value for percent calculation</param>
        /// <param name="digits">The number of digits given in result</param>
        /// <returns>Ther percentage value of a given qoutation and a basic value with an specified number of digits</returns>
        public static double Percentages(double percentageQuotation, double basicValue, int digits)
        {
            try
            {
                if (percentageQuotation > 0 && basicValue > 0)
                {
                    return System.Math.Round((100 * percentageQuotation / basicValue), digits);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
                return 0;
            }
        }
        #endregion

        #region Remaining Time
        /// <summary>
        /// Calculates the remaining time for an process, depenting on the elapsed time
        /// </summary>
        /// <param name="elapsedTime">Time elapsed for the actual progress</param>
        /// <param name="progressValue">Actual progress value</param>
        /// <param name="totalValueToFinish">Progress value to finish</param>
        /// <returns>The remining time to process all</returns>
        public static TimeSpan RemainingTime(TimeSpan elapsedTime, long progressValue, long totalValueToFinish)
        {
            return RemainingTime(elapsedTime, progressValue, totalValueToFinish, out _);
        }
        /// <summary>
        /// Calculates the remaining time for an process, depenting on the elapsed time
        /// </summary>
        /// <param name="elapsedTime">Time elapsed for the actual progress</param>
        /// <param name="progressValue">Actual progress value</param>
        /// <param name="totalValueToFinish">Progress value to finish</param>
        /// <param name="exception">Exception during calculation</param>
        /// <returns>The remining time to process all</returns>
        public static TimeSpan RemainingTime(TimeSpan elapsedTime, double progressValue, double totalValueToFinish, out Exception exception)
        {
            exception = null;
            try
            {
                return new TimeSpan(0, 0, 0, 0, Convert.ToInt32(elapsedTime.TotalMilliseconds / progressValue * (totalValueToFinish - progressValue)));
            }
            catch (Exception ex)
            {
                exception = ex;
                return new TimeSpan();
            }
        }
        #endregion
        #endregion
    }
}