using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactoringApplication.Api.Domain.Services;

namespace RefactoringApplication.Tests.Domain.Services
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
