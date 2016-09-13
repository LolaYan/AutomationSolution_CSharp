using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroWebUIAutomation.Utilities
{
    /// <summary>
    ///  DirectoryProvider, which is used for Get Current Solution DirectoryInfo and the directory of chrome driver/IE driver.
    ///  In order to avoid the execution fail which results from the wrong directory of web drivers.
    ///  Note: Make sure the folder 'drivers' is placed under the solution directory folder, which includes files - chromedriver.exe and chromedriver.exe.
    /// </summary>
    /// <author>Lola Yan</author>
    /// <author>LolaYan@outlook.com</author>
    /// 

    public class DirectoryProvider
    {
        public static DirectoryInfo GetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(
                currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }

        public static string GetDriversDirectoryInfo()
        {
            var directory = GetSolutionDirectoryInfo();
            var driversPath = directory.FullName + "\\drivers";
            return driversPath;
        }
    }
}
