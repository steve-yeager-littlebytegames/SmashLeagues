using NUnit.Framework;

namespace SmashLeagues.Droid.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var name = MainPage.name;
            Assert.AreEqual("Steve", name, "Oops");
        }
    }
}