using System;
using System.Collections.Generic;
using UpgradingLegacyApplication.Api.Models;

namespace UpgradingLegacyApplication.Api.SomeWeirdLegacyFolder
{
    public class LegacyJsonCompanyLoader
    {
        public const string SpecialDaysResourceName = "UpgradingLegacyApplication.Api.Resources.Companies.json";

        public static IEnumerable<CompanyModel> LoadCompanies()
        {
            throw new NotImplementedException();
        }

        public static CompanyModel LoadCompany(int withId)
        {
            throw new NotImplementedException();
        }
    }
}