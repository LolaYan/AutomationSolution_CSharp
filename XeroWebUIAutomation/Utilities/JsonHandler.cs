using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace XeroWebUIAutomation.Utilities
{
    public class StringHelpers
    {
        /// <summary>
        /// </summary>
        /// <param name="length"></param>
        /// <param name="option">0 - Lower/Uppercase Letters, 1 - Numbers Only, 2 - Lower/Uppercase/Number, 3 - Lowercase Letters, 4 - Uppercase Letters</param>
        /// <returns></returns>
        public static string GenerateRandom(int length, int option = 0)
        {
            string chars = "";
            switch (option)
            {
                case 0:
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                    break;
                case 1:
                    chars = "0123456789";
                    break;
                case 2:
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    break;
                case 3:
                    chars = "abcdefghijklmnopqrstuvwxyz";
                    break;
                case 4:
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
            }
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;

        }
        public static string FormatToTitleCase(string toFormat)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(toFormat.ToLower());
        }
    }
}
