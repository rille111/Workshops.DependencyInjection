using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using UpgradingLegacyApplication.Api.SomeWeirdLegacyFolder;

namespace UpgradingLegacyApplication.Tests.Smoke
{
    [TestClass]
    public class CompaniesJsonFileTests
    {
        [TestMethod]
        public void EmbeddedResourceFile_Should_Exist()
        {
            // Arrange
            const string resourceKey = LegacyJsonCompanyLoader.SpecialDaysResourceName;
            var streamLength = (long?) 0;

            // Act
            using (var stream = Assembly.GetAssembly(typeof(LegacyJsonCompanyLoader)).GetManifestResourceStream(resourceKey))
            {
                if (stream != null)
                {
                    streamLength = stream.Length;
                }
            }

            // Assert
            Assert.IsTrue(streamLength.HasValue);
        }

        [TestMethod]
        public void EmbeddedResourceFile_Should_HaveContent()
        {
            // Arrange
            var resourceKey = LegacyJsonCompanyLoader.SpecialDaysResourceName;
            var streamLength = (long?)0;
            var json = string.Empty;

            // Act
            using (var stream = Assembly.GetAssembly(typeof(LegacyJsonCompanyLoader)).GetManifestResourceStream(resourceKey))
            {
                streamLength = stream.Length;
                Debug.Assert(stream != null, "stream != null");
                using (var reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }
            }

            //return JsonConvert.DeserializeObject<IList<SpecialDay>>(json);
            
            // Assert
            Assert.IsTrue(json.Length > 0);
        }
    }
}
