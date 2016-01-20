using Microsoft.VisualStudio.TestTools.UnitTesting;
using UpgradingLegacyApplication.Api.Domain.Services;

namespace UpgradingLegacyApplication.Tests.Domain.Services
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
