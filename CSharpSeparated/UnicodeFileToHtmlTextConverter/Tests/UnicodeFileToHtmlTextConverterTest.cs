using NUnit.Framework;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public class HikerTest
    {
        [Test]
        public void Foobar()
        {
            UnicodeFileToHtmlTextConverter converter = new UnicodeFileToHtmlTextConverter("foobar.txt");
            Assert.AreEqual("fixme", converter.GetFilename());
        }
    }
}