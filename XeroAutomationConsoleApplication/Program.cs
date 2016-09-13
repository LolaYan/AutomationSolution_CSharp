using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroAutomationConsoleApplication.AppAPIs;
using Xero.Api;
using Xero.Api.Core.Model;
using Xero.Api.Core;
using Xero.Api.Common;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Example.Applications.Public;
using Xero.Api.Example.TokenStores;
using Xero.Api.Payroll;
using Xero.Api.Serialization;

using XeroAutomationConsoleApplication.Endpoints;
using XeroAutomationConsoleApplication.Utils;

namespace XeroAutomationConsoleApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            PublicAppApi PublicAppApi = new PublicAppApi();
            XeroCoreApi XeroCoreApi = PublicAppApi.Create_PublicAppAPI();
            Organisation org = XeroCoreApi.Organisation;
            */

            /*
            OrganisationEndpoint organisationEndpoint = new OrganisationEndpoint();
            organisationEndpoint.can_get_all_the_organisation_info();
            */
            BankAccountGenerator BankAccountGenerator = new BankAccountGenerator();
            BankAccountGenerator.getBankAccount("D");
            BankAccountGenerator.getBankAccount("E");
            BankAccountGenerator.getBankAccount("F");
            BankAccountGenerator.getBankAccount("G");
            BankAccountGenerator.getBankAccount("X");
            /*
            String strDate = DateTime.Today.ToString("dd MMMM yyyy");
            Console.WriteLine("strDate: " + strDate);
             * 
             *  */
        }
    }
}
