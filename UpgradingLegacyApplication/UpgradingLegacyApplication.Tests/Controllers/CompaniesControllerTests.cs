using System.Linq;
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
            var result = controller.GetAllCustomers();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
        }

    }
}
