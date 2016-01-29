using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using RefactoringApplication.Api.Infrastructure;
using RefactoringApplication.Api.Models;
// ReSharper disable InconsistentNaming

namespace RefactoringApplication.Api.Domain.Services
{
    public static class JsonCompanyLoader
    {
        private const string _specialDaysResourceName = "LEGACYHARDCODEDNAME.Api.Resources.Companies.json";
        private static readonly ConsoleLogger _logger = new ConsoleLogger();

        public static IEnumerable<CompanyModel> LoadCompanies()
        {
            _logger.Log("LoadCompanies() Was called! From what loader? No idea!");
            var retrievedJson = string.Empty;

            using (var embeddedStream = Assembly.GetCallingAssembly().GetManifestResourceStream(_specialDaysResourceName))
            {
                if (embeddedStream != null)
                    using (var reader = new StreamReader(embeddedStream))
                    {
                        retrievedJson = reader.ReadToEnd();
                    }
                else
                {
                    _logger.Log("Companies.json didnt exist or was empty!");
                }
            }

            var deserialized = JsonConvert.DeserializeObject<IEnumerable<CompanyModel>>(retrievedJson).ToList();
            return deserialized;
        }

        public static CompanyModel LoadCompany(int withId)
        {
            _logger.Log(string.Format("LoadCompany({0}) Was called! From what loader? No idea!", withId));
            var company = LoadCompanies().SingleOrDefault(p => p.Id == withId);
            return company;
        }
    }
}