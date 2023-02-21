using FindMaximumGenerics;
namespace FindMaximumGenericsTest
{
    public class Tests
    {

        MaxGeneric<int> intmax = new MaxGeneric <int>();
        
        [Test]
        public void FindMaxInt_Analyse_WhenFirstValueIsMax()
        {
            int result = intmax.GenricValue(20, 17, 12);
            Assert.AreEqual(20, result);
            Assert.Pass();
        }
        [Test]
        public void FindMaxInt_Analyse_WhenSecondValueIsMax()
        {
            int result = intmax.GenricValue(16, 17, 12);
            Assert.AreEqual(17, result);
            Assert.Pass();
        }
        [Test]
        public void FindMaxInt_Analyse_WhenThirdValueIsMax()
        {
            int result = intmax.GenricValue(16, 15, 12);
            Assert.AreEqual(12, result);
            Assert.Pass();
        }

    }

}