using System.Collections.Generic;
using System.IO;
using System.Reflection;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using UpgradingLegacyApplication.Api.Models;
using UpgradingLegacyApplication.Api.SomeWeirdLegacyFolder;

namespace UpgradingLegacyApplication.Tests.Smoke
{
    [TestClass]
    public class CompaniesJsonFileTests
    {
        [TestMethod]
        public void EmbeddedResourceFile_Should_HaveContent()
        {
            // Arrange
            const string resourceKey = LegacyJsonCompanyLoader.SpecialDaysResourceName;
            var streamLength = (long?)0;

            // Act
            using (var stream = Assembly.GetAssembly(typeof(LegacyJsonCompanyLoader)).GetManifestResourceStream(resourceKey))
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
            const string resourceKey = LegacyJsonCompanyLoader.SpecialDaysResourceName;
            var json = string.Empty;

            // Act
            using (var stream = Assembly.GetAssembly(typeof(LegacyJsonCompanyLoader)).GetManifestResourceStream(resourceKey))
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
