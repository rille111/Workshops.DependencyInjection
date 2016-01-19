using System.Collections.Generic;
using System.Linq;
using UpgradingLegacyApplication.Api.Models;

namespace UpgradingLegacyApplication.Api.Domain.Services
{
    public static class HardCodedCompanyLoader
    {
        public static IEnumerable<CompanyModel> LoadCompanies()
        {
            return new List<CompanyModel>
            {
                new CompanyModel() {Id = 1, Name = "Adlibris", Url = "www.adlibris.se"}
                , new CompanyModel() {Id = 2, Name = "Bamba", Url = "www.bamba.se"}
                , new CompanyModel() {Id = 3, Name = "Discshop", Url = "www.discshop.se"}
                , new CompanyModel() {Id = 4, Name = "Köketsfavoriter", Url = "www.koket.se"}
            };
        }

        public static CompanyModel LoadCompany(int withId)
        {
            return LoadCompanies().Single(p => p.Id == withId);
        }

    }
}