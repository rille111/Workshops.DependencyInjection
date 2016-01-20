using System.Collections.Generic;
using RefactoringApplication.Api.Models;

namespace RefactoringApplication.Api.Domain.Services
{
    public interface ICompanyLoader
    {
        IEnumerable<CompanyModel> LoadCompanies();
        CompanyModel LoadCompany(int withId);
    }
}
