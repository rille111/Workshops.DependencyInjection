using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UpgradingLegacyApplication.Api.Controllers;

namespace UpgradingLegacyApplication.Tests.Controllers
{
    [TestClass]
    public class CompaniesControllerTests
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            var controller = new CompanyController();

            // Act
            var result = controller.GetAll();

            // Assert
            result.Should().NotBeNull("because we expect at least some results");
            result.Should().NotBeEmpty("because we want at least 1 company");
        }

    }
}
