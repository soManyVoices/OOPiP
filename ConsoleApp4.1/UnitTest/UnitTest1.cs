using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace Html.Tests
{
    [TestClass]
    public class HtmlHelperTests
    {
        [TestMethod]
        public void PrintLinesWithTags_TagDoesNotExist_DoesNotAddAnyLinesToResult()
        {
            // Arrange
            string htmlCode = "<div>Hello world!</div>";
            string tag = "p";
            StringBuilder result = new StringBuilder();

            // Act
            HtmlHelper.PrintLinesWithTags(htmlCode, tag, result);

            // Assert
            string expectedOutput = "";
            Assert.AreEqual(expectedOutput, result.ToString());
        }

        [TestMethod]
        public void CombineStringBuilders_ReturnsCombinedResult()
        {
            // Arrange
            StringBuilder html = new StringBuilder("<html>");
            StringBuilder form = new StringBuilder("<form>");
            StringBuilder h1 = new StringBuilder("<h1>");

            // Act
            StringBuilder combinedResult = HtmlHelper.CombineStringBuilders(html, form, h1);

            // Assert
            string expectedOutput = "<html><form><h1>";
            Assert.AreEqual(expectedOutput, combinedResult.ToString());
        }

        [TestMethod]
        public void CombineStringBuilders_EmptyBuilders_ReturnsEmptyString()
        {
            // Arrange
            StringBuilder html = new StringBuilder();
            StringBuilder form = new StringBuilder();
            StringBuilder h1 = new StringBuilder();

            // Act
            StringBuilder combinedResult = HtmlHelper.CombineStringBuilders(html, form, h1);

            // Assert
            string expectedOutput = "";
            Assert.AreEqual(expectedOutput, combinedResult.ToString());
        }

        [TestMethod]
        public void PrintLinesWithTags_TagExistsInMultipleLines_CaseSensitive_DoesNotAddLinesToResult()
        {
            // Arrange
            string htmlCode = "<h1>\nHello world!\n</h1>";
            string tag = "form";
            StringBuilder result = new StringBuilder();

            // Act
            HtmlHelper.PrintLinesWithTags(htmlCode, tag, result);

            // Assert
            string expectedOutput = "";
            Assert.AreEqual(expectedOutput, result.ToString());
        }

        [TestMethod]
        public void CombineStringBuilders_NonEmptyBuilders_ReturnsCombinedResult()
        {
            // Arrange
            StringBuilder html = new StringBuilder("<html>");
            StringBuilder form = new StringBuilder("<form>");
            StringBuilder h1 = new StringBuilder("<h1>");

            // Act
            StringBuilder combinedResult = HtmlHelper.CombineStringBuilders(html, form, h1);

            // Assert
            string expectedOutput = "<html><form><h1>";
            Assert.AreEqual(expectedOutput, combinedResult.ToString());
        }
    }
}