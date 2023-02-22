using FindMaximumGenerics;
namespace FindMaximumGenericsTest
{
    public class Tests
    {

        MaxGeneric<float> floatmax = new MaxGeneric <float>();
        
        [Test]
        public void FindMaxInt_Analyse_WhenFirstValueIsMax()
        {
            float result = floatmax.GenricValue(2.0f, 1.7f, 1.2f);
            Assert.AreEqual(2.0f, result);
            Assert.Pass();
        }
        [Test]
        public void FindMaxInt_Analyse_WhenSecondValueIsMax()
        {
            float result = floatmax.GenricValue(1.7f, 2.0f, 1.2f);
            Assert.AreEqual(2.0f, result);
            Assert.Pass();
        }
        [Test]
        public void FindMaxInt_Analyse_WhenThirdValueIsMax()
        {
            float result = floatmax.GenricValue(1.2f, 1.6f, 2.0f);
            Assert.AreEqual(2.0f, result);
            Assert.Pass();
        }


    }

}