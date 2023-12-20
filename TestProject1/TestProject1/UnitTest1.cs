namespace TestProject1
{
    public class Tests
    {
        MarryChristmas _marryChristmas;

        [SetUp]
        public void Setup()
        {
            _marryChristmas = new MarryChristmas();
        }

        [Test]
        public void Test_Today_Is_Not_Marry_Christmas()
        {
            string todayResult = _marryChristmas.IsMarryChristmas();
            Assert.AreEqual("Today isn't Marry Christmas", todayResult);
        }

        [Test]
        public void Test_Today_Should_Be_Marry_Christmas()
        {
            _marryChristmas = new MarryChristmas(new DateTime(2023, 12, 25));
            string todayResult = _marryChristmas.IsMarryChristmas();
            Assert.AreEqual("Today is Marry Christmas", todayResult);
        }
    }
}