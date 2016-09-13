using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xero.Api.Core;
using Xero.Api.Core.Model;
using XeroAutomationConsoleApplication.AppAPIs;
namespace XeroAutomationConsoleApplication.Endpoints
{
    public class OrganisationEndpoint
    {
        public Organisation org;
        public OrganisationEndpoint()
        {
            PublicAppApi PublicAppApi = new PublicAppApi();
            XeroCoreApi XeroCoreApi = PublicAppApi.Create_PublicAppAPI();
            this.org = PublicAppApi.Create_PublicAppAPI_Organisation(XeroCoreApi);
        }

        public void can_get_all_the_organisation_info()
        {

            var orgName = org.Name;
            var orgApiKey = org.ApiKey;
            var orgIsDemoCompany = org.IsDemoCompany;
            //orgAddress: System.Collections.Generic.List`1[Xero.Api.Core.Model.Address]
            var orgAddress = org.Addresses;
            var orgBaseCurrency = org.BaseCurrency;
            var orgCreatedDateUtc = org.CreatedDateUtc;
            var orgEndOfYearLockDate = org.EndOfYearLockDate;
            //orgExternalLinks: System.Collections.Generic.List`1[Xero.Api.Core.Model.ExternalLink]
            var orgExternalLinks = org.ExternalLinks;
            var orgFinancialYearEndDay = org.FinancialYearEndDay;
            var orgFinancialYearEndMonth = org.FinancialYearEndMonth;
            var orgLegalName = org.LegalName;
            var orgLineOfBusiness = org.LineOfBusiness;
            var orgOrganisationStatus = org.OrganisationStatus;
            var orgOrganisationType = org.OrganisationType;
            var orgPaymentTerms = org.PaymentTerms;
            var orgPaysTax = org.PaysTax;
            var orgPeriodLockDate = org.PeriodLockDate;
            //orgPhones: System.Collections.Generic.List`1[Xero.Api.Core.Model.Phone]
            var orgPhones = org.Phones;
            var orgRegistrationNumber = org.RegistrationNumber;
            var orgSalesTaxBasisType = org.SalesTaxBasisType;
            var orgSalesTaxPeriod = org.SalesTaxPeriod;
            var orgShortCode = org.ShortCode;
            var orgTaxNumber = org.TaxNumber;
            var orgTimezone = org.Timezone;
            var orgVersion = org.Version;
            var orgCountryCode = org.CountryCode;

            Console.WriteLine("org info: " + org);
            Console.WriteLine("orgName: " + orgName);
            Console.WriteLine("orgApiKey: " + orgApiKey);
            Console.WriteLine("orgIsDemoCompany: " + orgIsDemoCompany);
            Console.WriteLine("orgAddress: " + orgAddress);
            Console.WriteLine("orgBaseCurrency: " + orgBaseCurrency);
            Console.WriteLine("orgCreatedDateUtc: " + orgCreatedDateUtc);
            Console.WriteLine("orgEndOfYearLockDate: " + orgEndOfYearLockDate);
            Console.WriteLine("orgExternalLinks: " + orgExternalLinks);
            Console.WriteLine("orgFinancialYearEndDay: " + orgFinancialYearEndDay);
            Console.WriteLine("orgFinancialYearEndMonth: " + orgFinancialYearEndMonth);
            Console.WriteLine("orgLegalName: " + orgLegalName);
            Console.WriteLine("orgLineOfBusiness: " + orgLineOfBusiness);
            Console.WriteLine("orgOrganisationStatus: " + orgOrganisationStatus);
            Console.WriteLine("orgOrganisationType: " + orgOrganisationType);
            Console.WriteLine("orgPaymentTerms: " + orgPaymentTerms);
            Console.WriteLine("orgPaysTax: " + orgPaysTax);
            Console.WriteLine("orgPeriodLockDate: " + orgPeriodLockDate);
            Console.WriteLine("orgPhones: " + orgPhones);
            Console.WriteLine("orgRegistrationNumber: " + orgRegistrationNumber);
            Console.WriteLine("orgSalesTaxBasisType: " + orgSalesTaxBasisType);
            Console.WriteLine("orgSalesTaxPeriod: " + orgSalesTaxPeriod);
            Console.WriteLine("orgShortCode: " + orgShortCode);
            Console.WriteLine("orgTaxNumber: " + orgTaxNumber);
            Console.WriteLine("orgTimezone: " + orgTimezone);
            Console.WriteLine("orgVersion: " + orgVersion);
            Console.WriteLine("orgCountryCode: " + orgTimezone);
        }
    }
}
