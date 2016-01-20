using System.Collections.Generic;
using System.IO;
using System.Reflection;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RefactoringApplication.Api.Domain.Services;
using RefactoringApplication.Api.Models;

namespace RefactoringApplication.Tests.Etc
{
    [TestClass]
    public class CompaniesJsonFileTests
    {
        [TestMethod]
        public void EmbeddedResourceFile_Should_HaveContent()
        {
            // Arrange
            const string resourceKey = "RefactoringApplication.Api.Resources.Companies.json";
            var streamLength = (long?)0;

            // Act
            using (var stream = Assembly.GetAssembly(typeof(JsonCompanyLoader)).GetManifestResourceStream(resourceKey))
            {
                if (stream != null)
                {
                    streamLength = stream.Length;
                }
            }

            // Assert
            streamLength.Should().BeGreaterThan(0, "because the resource file should not be empty.");
        }

        [TestMethod]
        public void EmbeddedResourceFile_Should_DeSerializeTo_Models()
        {
            // Arrange
            const string resourceKey = "RefactoringApplication.Api.Resources.Companies.json";
            var json = string.Empty;

            // Act
            using (var stream = Assembly.GetAssembly(typeof(JsonCompanyLoader)).GetManifestResourceStream(resourceKey))
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        json = reader.ReadToEnd();
                    }
                }
            }
            var models = JsonConvert.DeserializeObject<IEnumerable<CompanyModel>>(json);

            // Assert
            models.Should().NotBeEmpty("because some models should have been deserialized!");
        }
    }
}
