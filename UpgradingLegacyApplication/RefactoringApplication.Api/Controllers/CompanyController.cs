using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using UpgradingLegacyApplication.Api.Domain.Services;
using UpgradingLegacyApplication.Api.Infrastructure;
using UpgradingLegacyApplication.Api.Models;

namespace UpgradingLegacyApplication.Api.Controllers
{
    public class CompanyController : ApiController
    {
        // GET api/customers
        [HttpGet]
        [Route("api/companies")]
        public List<CompanyModel> GetAll()
        {
            if (CurrentConfiguration.LoadFromJson)
            {
                var companies = JsonCompanyLoader.LoadCompanies().ToList();
                return companies;
            }
            else
            {
                var companies = HardCodedCompanyLoader.LoadCompanies().ToList();
                return companies;
            }
        }

        // GET api/customers/5
        [HttpGet]
        [Route("api/companies/{id:int}")]
        public CompanyModel GetById(int id)
        {
            if (CurrentConfiguration.LoadFromJson)
            {
                var company = JsonCompanyLoader.LoadCompany(id);
                return company;
            }
            else
            {
                var company = HardCodedCompanyLoader.LoadCompany(id);
                return company;
            }
        }
    }
}
