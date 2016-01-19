using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using UpgradingLegacyApplication.Api.Models;
using UpgradingLegacyApplication.Api.SomeWeirdLegacyFolder;

namespace UpgradingLegacyApplication.Api.Controllers
{
    public class CompanyController : ApiController
    {
        [HttpGet]
        [Route("api/companies")]
        public List<CompanyModel> GetAllCustomers()
        {
            var x = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            return LegacyHardCodedCompanyLoader.LoadCompanies().ToList();
        }

        // GET api/customers/5
        [HttpGet]
        [Route("api/companies/{id:int}")]
        public CompanyModel GetById(int id)
        {
            return LegacyHardCodedCompanyLoader.LoadCompany(id);
        }
    }
}
