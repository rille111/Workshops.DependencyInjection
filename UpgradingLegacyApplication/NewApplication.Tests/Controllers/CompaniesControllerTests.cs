using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NewApplication.Api.Controllers;
using NewApplication.Api.Domain.Services;
using NewApplication.Api.Models;

namespace NewApplication.Tests.Controllers
{
    [TestClass]
    public class CompaniesControllerTests
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            var loader = new Mock<ICompanyLoader>();
            loader
                .Setup(p => p.LoadCompanies())
                .Returns(new List<CompanyModel>());
            loader
                .Setup(p => p.LoadCompany(1))
                .Returns(new CompanyModel() {Id = 1, Name = "TEZT"});

            var controller = new CompanyController(loader.Object);

            // Act
            var allCompanies = controller.GetAll();
            var oneCompany = controller.GetById(1);

            // Assert
            allCompanies.Should().NotBeNull("because we expect at least some results");
            oneCompany.Should().NotBeNull("because we want at least 1 company");
            oneCompany.Name.Should().Be("TEZT");
            loader.Verify();
        }

    }
}
