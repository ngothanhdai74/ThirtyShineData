using NUnit.Framework;
using Repository.Implements;

namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async System.Threading.Tasks.Task TestQuantitySupplies()
        {
            var res = await QuantifyRepository.TestQuantitySupplies();
            Assert.IsTrue(res);
        }
    }
}