using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xero.Api.Core.Model;
using Xero.Api.Core;

namespace XeroEndpointsAPIAutomation.Tests
{
    /// <summary>
    ///  BaseTest Class, which will be extend from EndpointsAPITest.
    ///  Using UnitTesting Attributes
    ///  Feature 1: Initialization of public XeroCoreApi object.
    ///  Note 1: All the authorisation url and xero app credentials are configured in Project.Properties.Settins.
    /// </summary>
    /// <author>Lola Yan</author>
    /// <author>LolaYan@outlook.com</author>
    /// 
    [TestClass]
    public class OrganisationAPITest : EndpointBaseTest
    {
        public OrganisationAPITest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Additional test attributes
        #endregion

        [TestMethod]
        public void can_get_all_the_organisation_info()
        {

            string orgName = org.Name;
            string orgApiKey = org.ApiKey;
            var orgIsDemoCompany = org.IsDemoCompany;
            //orgAddress: System.Collections.Generic.List`1[Xero.Api.Core.Model.Address]
            var orgAddress = org.Addresses;
            string orgBaseCurrency = org.BaseCurrency;
            var orgCreatedDateUtc = org.CreatedDateUtc;
            var orgEndOfYearLockDate = org.EndOfYearLockDate;
            //orgExternalLinks: System.Collections.Generic.List`1[Xero.Api.Core.Model.ExternalLink]
            var orgExternalLinks = org.ExternalLinks;
            var orgFinancialYearEndDay = org.FinancialYearEndDay;
            var orgFinancialYearEndMonth = org.FinancialYearEndMonth;
            string orgLegalName = org.LegalName;
            var orgLineOfBusiness = org.LineOfBusiness;
            string orgOrganisationStatus = org.OrganisationStatus.ToString();
            string orgOrganisationType = org.OrganisationType.ToString();
            var orgPaymentTerms = org.PaymentTerms;
            var orgPaysTax = org.PaysTax;
            var orgPeriodLockDate = org.PeriodLockDate;
            //orgPhones: System.Collections.Generic.List`1[Xero.Api.Core.Model.Phone]
            var orgPhones = org.Phones;
            string orgRegistrationNumber = org.RegistrationNumber;
            string orgSalesTaxBasisType = org.SalesTaxBasisType.ToString();
            string orgSalesTaxPeriod = org.SalesTaxPeriod.ToString();
            string orgShortCode = org.ShortCode;
            string orgTaxNumber = org.TaxNumber;
            string orgTimezone = org.Timezone;
            string orgVersion = org.Version.ToString();
            string orgCountryCode = org.CountryCode;

            string expectOrgApiKey ="";
            bool expectOrgIsDemoCompany = true;
            string expectOrgBaseCurrency = "NZD";
            string expectOrgCreatedDateUtc = "13/07/2016 12:29:47 a.m.";
            int? expectOrgFinancialYearEndDay = 31;
            int? expectOrgFinancialYearEndMonth = 3;
            string expectOrgLegalName  = "Demo Company (NZ)";
            string expectOrgOrganisationStatus = "Active";
            string expectOrgOrganisationType = "Company";
            bool expectOrgPaysTax = true;
            string expectOrgPeriodLockDate = " 30/09/2009 12:00:00 a.m.";
            string expectOrgSalesTaxPeriod = "TwoMonths";
            string expectOrgShortCode = "!Rbg3D";
            string expectOrgTaxNumber = "111-111-111";
            string expectOrgTimezone = " NEWZEALANDSTANDARDTIME";
            string expectOrgVersion = "NewZealand";
            string expectOrgCountryCode = " NEWZEALANDSTANDARDTIME";

            Assert.AreEqual(expectOrgOrganisationStatus, orgOrganisationStatus);
            Assert.AreEqual(expectOrgTaxNumber, orgTaxNumber);
            Assert.AreEqual(expectOrgShortCode, orgShortCode);
            Assert.AreEqual(expectOrgLegalName, orgLegalName);
            Assert.AreEqual(expectOrgBaseCurrency, orgBaseCurrency);
            Assert.AreEqual(expectOrgFinancialYearEndDay, orgFinancialYearEndDay);
            Assert.AreEqual(expectOrgFinancialYearEndMonth, orgFinancialYearEndMonth);
            Assert.AreEqual(expectOrgSalesTaxPeriod, orgSalesTaxPeriod);
            Assert.AreEqual(expectOrgTimezone, orgTimezone);
            Assert.AreEqual(expectOrgVersion, orgVersion);
            Assert.AreEqual(expectOrgCountryCode, orgCountryCode);
            Assert.AreEqual(expectOrgOrganisationType, orgOrganisationType);
        }

        [TestMethod]
        public void can_get_the_organisation_sales_tax_basis()
        {
            var test = this.org.SalesTaxBasisType;

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void can_get_the_organisation_sales_tax_period()
        {
            var test = this.org.SalesTaxPeriod;

            Assert.IsNotNull(test);
        }
    }
}
