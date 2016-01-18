using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using UpgradingLegacyApplication.Api.Models;
using UpgradingLegacyApplication.Api.SomeWeirdLegacyFolder;

namespace UpgradingLegacyApplication.Api.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("api/customers")]
        public List<CustomerModel> GetAllCustomers()
        {
            return YeOldeCustomersLoader.LoadAllCustomers().ToList();
        }

        // GET api/customers/5
        [HttpGet]
        [Route("api/customers/{id:int}")]
        public CustomerModel GetById(int id)
        {
            return YeOldeCustomersLoader.LoadCustomer(id);
        }
    }
}
