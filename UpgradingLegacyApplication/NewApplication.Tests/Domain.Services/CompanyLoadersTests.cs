using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewApplication.Api.Domain.Services;

namespace NewApplication.Tests.Domain.Services
{
    [TestClass]
    public class CompanyLoadersTests
    {
        [TestMethod]
        public void LegacyJsonCompanyLoader_Should_Load_Companies()
        {
            // Arrange

            // Act
            JsonCompanyLoader.LoadCompanies();

            // Assert
        }
    }
}
