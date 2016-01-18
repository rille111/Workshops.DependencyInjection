using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UpgradingLegacyApplication;
using UpgradingLegacyApplication.Api.Controllers;

namespace UpgradingLegacyApplication.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            var controller = new CustomersController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Adlibris", result.ElementAt(0));
        }

        [TestMethod, Ignore]
        public void GetById()
        {
            // Arrange
            var controller = new CustomersController();

            // Act
            var result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }
    }
}
