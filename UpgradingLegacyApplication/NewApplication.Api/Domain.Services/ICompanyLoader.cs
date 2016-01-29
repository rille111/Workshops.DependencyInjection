using System.Collections.Generic;
using NewApplication.Api.Models;

namespace NewApplication.Api.Domain.Services
{
    public interface ICompanyLoader
    {
        IEnumerable<CompanyModel> LoadCompanies();
        CompanyModel LoadCompany(int withId);
    }
}
