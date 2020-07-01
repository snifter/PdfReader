using Xunit;

namespace PdfReader.Lib.Tests
{
    public class PdfDocumentTest
    {
        [Fact]
        public void PagesCount_ReturnsValidCount()
        {
            const string filePath = "../testFiles/LoremIpsum.pdf";
            var target = new PdfDocument(filePath);
            
            Assert.Equal(10, target.PagesCount);
        }
    }
}