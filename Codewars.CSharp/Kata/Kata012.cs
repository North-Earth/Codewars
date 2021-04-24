using System;

namespace Codewars.CSharp.Kata
{
    /// <summary>
    /// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
    /// HH = hours, padded to 2 digits, range: 00 - 99
    /// MM = minutes, padded to 2 digits, range: 00 - 59
    /// SS = seconds, padded to 2 digits, range: 00 - 59
    /// The maximum time never exceeds 359999 (99:59:59)
    /// </summary>
    public static class Kata012
    {
        /// <summary>
        /// My version.
        /// </summary>
        public static string GetReadableTime(int seconds)
            => $"{GetReadableNumber(Math.DivRem(seconds, 3600, out int remainder).ToString())}" +
               $":{GetReadableNumber(Math.DivRem(remainder, 60, out remainder).ToString())}" +
               $":{GetReadableNumber(remainder.ToString())}";

        private static string GetReadableNumber(string number)
            => $"{(number.Length < 2 ? "0" + number : number)}";

        #region Best practice according to the community Codewars.

        public static string GetReadableTimeBestPractice1(int seconds)
        {
            return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        }

        public static string GetReadableTimeBestPractice2(int seconds)
        {
            var t = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
        }

        #endregion
    }
}
