using NUnit.Framework;

using PaketSandbox.Universe;

namespace PaketSandbox.Universe.Tests
{
    public class UnitTests
    {
        [Test]
        public void AnswerToUniverse()
        {
            Assert.IsTrue(Universe.Answer()  == 41);
        }
    }
}
