using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UpgradingLegacyApplication.Controllers
{
    public class CustomersController : ApiController
    {
        // GET api/customers
        public IEnumerable<string> Get()
        {
            return new string[] { "Adlibris", "Bamba" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "Adlibris";
        }
    }
}
