using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using RefactoringApplication.Api.Domain.Services;
using RefactoringApplication.Api.Models;

namespace RefactoringApplication.Api.Controllers
{
    public class CompanyController : ApiController
    {
        private ICompanyLoader _loader;

        public CompanyController(ICompanyLoader loader)
        {
            _loader = loader;
        }

        // GET api/customers
        [HttpGet]
        [Route("api/companies")]
        public List<CompanyModel> GetAll()
        {
            var companies = _loader.LoadCompanies().ToList();
            return companies;
        }

        // GET api/customers/5
        [HttpGet]
        [Route("api/companies/{id:int}")]
        public CompanyModel GetById(int id)
        {
            var company = _loader.LoadCompany(id);
            return company;
        }
    }
}
