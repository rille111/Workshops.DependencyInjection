using System.Collections.Generic;
using NewApplication.Api.Infrastructure;
using NewApplication.Api.Models;

namespace NewApplication.Api.Domain.Services
{
    public class CompanyLoaderLoggingDecorator : ICompanyLoader
    {
        private readonly ICompanyLoader _decorated;
        private readonly ICustomLogger _logger;

        public CompanyLoaderLoggingDecorator(ICompanyLoader decorated, ICustomLogger logger)
        {
            _logger = logger;
            _decorated = decorated;
        }

        public IEnumerable<CompanyModel> LoadCompanies()
        {
            var name = _decorated.GetType().FullName;
            _logger.Log(name + ":LoadCompanies()");
            return _decorated.LoadCompanies();
        }

        public CompanyModel LoadCompany(int withId)
        {
            var name = _decorated.GetType().FullName;
            _logger.Log(name + ":LoadCompany(" + withId + ")");
            return _decorated.LoadCompany(withId);
        }
    }
}