using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroWebUIAutomation.Utilities
{
    public class DateHelper
    {


        static DateTime GetYesterday()
        {
            // Add -1 to now.
            return DateTime.Today.AddDays(-1);
        }

        static DateTime GetTomorrow()
        {
            
            return DateTime.Today.AddDays(1);
        }

    }
}
