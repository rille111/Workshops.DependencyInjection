using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using UpgradingLegacyApplication.Api.Models;

namespace UpgradingLegacyApplication.Api.Domain.Services
{
    public static class LegacyJsonCompanyLoader
    {
        public const string SpecialDaysResourceName = "UpgradingLegacyApplication.Api.Resources.Companies.json";

        public static IEnumerable<CompanyModel> LoadCompanies()
        {
            string json = null;

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(SpecialDaysResourceName))
            {
                if (stream != null)
                    using (var reader = new StreamReader(stream))
                    {
                        json = reader.ReadToEnd();
                    }
            }

            return JsonConvert.DeserializeObject<IEnumerable<CompanyModel>>(json);
        }

        public static CompanyModel LoadCompany(int withId)
        {
            var company = LoadCompanies().SingleOrDefault(p => p.Id == withId);
            return company;
        }
    }
}