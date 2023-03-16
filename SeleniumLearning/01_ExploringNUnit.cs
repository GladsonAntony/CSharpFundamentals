namespace SeleniumLearning
{
    public class ExploringNUnitFeaturtes
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("This is the Setup Block. It will be executed before each Test Blocks");
        }

        [Test]
        public void Test01()
        {
            TestContext.Progress.WriteLine("This is the Test01 Block");
            Assert.Pass();
        }

        [Test]
        public void Test02()
        {
            TestContext.Progress.WriteLine("This is the Test02 Block");
            Assert.Pass();
        }

        [TearDown]
        public void Teardown()
        {
            TestContext.Progress.WriteLine("This is the Tear Down block. It will be executed after each Test Block\n\n");
        }
    }
}