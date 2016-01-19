using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using UpgradingLegacyApplication.Api.Domain.Services;
using UpgradingLegacyApplication.Api.Models;

namespace UpgradingLegacyApplication.Api.Controllers
{
    public class CompanyController : ApiController
    {
        [HttpGet]
        [Route("api/companies")]
        public List<CompanyModel> GetAllCustomers()
        {
            var companies = LegacyJsonCompanyLoader.LoadCompanies().ToList();
            return companies;
        }

        // GET api/customers/5
        [HttpGet]
        [Route("api/companies/{id:int}")]
        public CompanyModel GetById(int id)
        {
            var company = LegacyJsonCompanyLoader.LoadCompany(id);
            return company;
        }
    }
}
