﻿//
// Copyright (c) .NET Foundation and Contributors
// Portions Copyright 2007 James Newton-King, (c) Pervasive Digital LLC
// See LICENSE file in the project root for full license information.
//

using System;
using System.Globalization;

namespace nanoFramework.Json
{
    internal static class DateTimeExtensions
    {
        /// <summary>
        /// Converts a vCal or iCal date string into a DateTime object.
        /// </summary>
        /// <param name="iCalendar"></param>
        /// <returns></returns>
        public static DateTime FromiCalendar(string iCalendar)
        {
            string result;

            if ((iCalendar.Contains("DTSTART")) || (iCalendar.Contains("DTEND")))
            {
                result = iCalendar.Split(':')[1];
            }
            else
            {
                result = iCalendar;
            }

            // Check to see if format contains the timezone ID, or contains UTC reference
            // Neither means it's local time
            bool tzid = iCalendar.Contains("TZID");
            bool utc = iCalendar.EndsWith("Z");
            string time;

            if (tzid)
            {
                string[] parts = iCalendar.Split(new char[] { ';', '=', ':' });

                // parts[0] == DTSTART or DTEND
                // parts[1] == TZID
                // parts[2] == the timezone string
                // parts[3] == localtime string
                _ = parts[2];
                time = parts[3];
            }
            else if (utc)
            {
                time = result.Substring(0, result.Length - 1);  // truncate the trailing 'Z'
            }
            else
            {
                time = result;  // localtime
            }

            // We now have the time string to parse, and we'll adjust
            // to UTC or timezone after parsing
            string year = time.Substring(0, 4);
            string month = time.Substring(4, 2);
            string day = time.Substring(6, 2);
            string hour = time.Substring(9, 2);
            string minute = time.Substring(11, 2);
            string second = time.Substring(13, 2);

            // Check if any of the date time parts is non-numeric
            if (!IsNumeric(year))
            {
                return DateTime.MaxValue;
            }
            else if (!IsNumeric(month))
            {
                return DateTime.MaxValue;
            }
            else if (!IsNumeric(day))
            {
                return DateTime.MaxValue;
            }
            else if (!IsNumeric(hour))
            {
                return DateTime.MaxValue;
            }
            else if (!IsNumeric(minute))
            {
                return DateTime.MaxValue;
            }
            else if (!IsNumeric(second))
            {
                return DateTime.MaxValue;
            }

            DateTime dt = new(
                Convert.ToInt32(year),
                Convert.ToInt32(month),
                Convert.ToInt32(day),
                Convert.ToInt32(hour),
                Convert.ToInt32(minute),
                Convert.ToInt32(second));

            if (utc)
            {
                // Convert the Kind to DateTimeKind.Utc
                dt = new DateTime(0, DateTimeKind.Utc).AddTicks(dt.Ticks);
            }
            else if (tzid)
            {
                // not sure what to do here
            }

            return dt;
        }

        /// <summary>
        /// Converts a DateTime object into an ISO 8601 string.  This version
        /// always returns the string in UTC format.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToIso8601(DateTime dt)
        {
            return dt.ToString($"{CultureInfo.CurrentUICulture.DateTimeFormat.SortableDateTimePattern}.fffZ");
        }

        /// <summary>
        /// Returns true if the given string contains only numeric characters.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (!((c >= '0') && (c <= '9')))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Converts an ASP.NET Ajaz JSON string to DateTime
        /// </summary>
        /// <param name="ajax"></param>
        /// <returns></returns>
        public static DateTime FromASPNetAjax(string ajax)
        {
            string[] parts = ajax.Split(new char[] { '(', ')' });

            // Check if any of the date time parts is non-numeric
            if (parts.Length < 2)
            {
                return DateTime.MaxValue;
            }

            if (!IsNumeric(parts[1]))
            {
                return DateTime.MaxValue;
            }

            long ticks = Convert.ToInt64(parts[1]);

            // Create a Utc DateTime based on the tick count
            DateTime dt = new(ticks, DateTimeKind.Utc);

            return dt;
        }

        internal static DateTime ConvertFromString(string value)
        {
            // check if this could be a DateTime value
            // min lenght is 18 for Java format: "Date(628318530718)": 18

            DateTime dtValue = DateTime.MaxValue;

            if (value.Length >= 18)
            {
                if (dtValue == DateTime.MaxValue)
                {
                    _ = DateTime.TryParse(value, out dtValue);
                }

                if (dtValue == DateTime.MaxValue)
                {
                    try
                    {
                        dtValue = FromASPNetAjax(value);
                    }
                    catch
                    {
                        // intended, to catch failed conversion attempt
                    }
                }

                if (dtValue == DateTime.MaxValue)
                {
                    try
                    {
                        dtValue = FromiCalendar(value);
                    }
                    catch
                    {
                        // intended, to catch failed conversion attempt
                    }
                }
            }

            return dtValue;
        }
    }
}
