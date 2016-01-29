using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using NewApplication.Api.Infrastructure;
using NewApplication.Api.Models;
using Newtonsoft.Json;

// ReSharper disable InconsistentNaming

namespace NewApplication.Api.Domain.Services
{
    public class JsonCompanyLoader : ICompanyLoader
    {
        private readonly ICustomLogger _logger;
        private const string _specialDaysResourceName = "RefactoringApplication.Api.Resources.Companies.json";

        public JsonCompanyLoader(ICustomLogger _logger)
        {
            this._logger = _logger;
        }

        public IEnumerable<CompanyModel> LoadCompanies()
        {
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

        public CompanyModel LoadCompany(int withId)
        {
            var company = LoadCompanies().SingleOrDefault(p => p.Id == withId);
            return company;
        }
    }
}