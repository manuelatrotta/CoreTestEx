using NUnit.Framework;

namespace CoreTestEx
{   [TestFixture]
    public class Tests
    {

        [Test]
        public void HTMLFormatterAsBold_WhenCalled_ReturnStringBold()
        {
            var word = new HTMLFormatter();
            var result = word.FormatAsBold("abc");
            // soluzione specifica metodo IgnoreCase ignora se è in upper o lowcase 
           // Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            // soluzione generica 

            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
        }
    }
}