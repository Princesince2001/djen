using DemoJenkins;

namespace TestProject4
{
    public class Tests
    {
        [SetUp]
        
        public void Setup()
        {
        }

        [Test]
        public void Test_sayMyname()
        {
            One test = new One();
            string result = test.sayMyname(2);
            Assert.AreEqual("jenkinspassjenkinspass", result);
        }


        [Test]
        public void Test_sayMyname1()
        {
            One test = new One();
            string result = test.sayMyname(1);
            Assert.AreEqual("jenkinspass", result);
        }
    }
}