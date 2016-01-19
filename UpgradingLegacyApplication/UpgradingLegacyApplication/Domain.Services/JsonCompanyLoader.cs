using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using UpgradingLegacyApplication.Api.Models;

namespace UpgradingLegacyApplication.Api.Domain.Services
{
    public static class JsonCompanyLoader
    {
        private const string SpecialDaysResourceName = "UpgradingLegacyApplication.Api.Resources.Companies.json";

        public static IEnumerable<CompanyModel> LoadCompanies()
        {
            string json;

            using (var stream = Assembly.GetCallingAssembly().GetManifestResourceStream(SpecialDaysResourceName))
            {
                if (stream != null)
                    using (var reader = new StreamReader(stream))
                    {
                        json = reader.ReadToEnd();
                    }
                else
                {
                    throw new FileNotFoundException("Companies.json didnt exist or was empty!");
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