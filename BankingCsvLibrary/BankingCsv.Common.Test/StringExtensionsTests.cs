using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingCsv.Common.Test
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void ShouldStripStringWithBeginQuotes()
        {
            // Arrange
            var testString = "\"Test";

            // Act
            var strippedString = testString.StripQuotes();

            // Assert
            Assert.AreEqual("Test", strippedString);
        }

        [TestMethod]
        public void ShouldStripStringWithEndQuotes()
        {
            // Arrange
            var testString = "Test\"";

            // Act
            var strippedString = testString.StripQuotes();

            // Assert
            Assert.AreEqual("Test", strippedString);
        }

        [TestMethod]
        public void ShouldStripStringWithBeginAndEndQuotes()
        {
            // Arrange
            var testString = "\"Test\"";

            // Act
            var strippedString = testString.StripQuotes();

            // Assert
            Assert.AreEqual("Test", strippedString);
        }
    }
}
