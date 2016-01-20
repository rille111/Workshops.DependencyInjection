using System.Collections.Generic;
using System.Linq;
using RefactoringApplication.Api.Infrastructure;
using RefactoringApplication.Api.Models;
// ReSharper disable InconsistentNaming

namespace RefactoringApplication.Api.Domain.Services
{
    public class HardCodedCompanyLoader : ICompanyLoader
    {
        private readonly ICustomLogger _logger;

        public HardCodedCompanyLoader(ICustomLogger logger)
        {
            _logger = logger;
        }

        public IEnumerable<CompanyModel> LoadCompanies()
        {
            return new List<CompanyModel>
            {
                new CompanyModel() {Id = 1, Name = "Adlibris", Url = "www.adlibris.se"}
                , new CompanyModel() {Id = 2, Name = "Bamba", Url = "www.bamba.se"}
                , new CompanyModel() {Id = 3, Name = "Discshop", Url = "www.discshop.se"}
                , new CompanyModel() {Id = 4, Name = "Köketsfavoriter", Url = "www.koket.se"}
            };
        }

        public CompanyModel LoadCompany(int withId)
        {
            return LoadCompanies().Single(p => p.Id == withId);
        }
    }
}