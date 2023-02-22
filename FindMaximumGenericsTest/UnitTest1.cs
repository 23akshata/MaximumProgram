using FindMaximumGenerics;
namespace FindMaximumGenericsTest
{
    public class Tests
    {

        MaxGeneric<string> stringmax = new MaxGeneric <string>();
        
        [Test]
        public void FindMaxstring_Analyse_WhenFirstValueIsMax()
        {
            string result = stringmax.GenricValue("Peach","Banana","Apple");
            Assert.AreEqual("Peach", result);
            Assert.Pass();
        }
        [Test]
        public void FindMaxstring_Analyse_WhenSecondValueIsMax()
        {
            string result = stringmax.GenricValue("Banana", "Peach", "Apple");
            Assert.AreEqual("Peach", result);
            Assert.Pass();
        }
        [Test]
        public void FindMaxstring_Analyse_WhenThirdValueIsMax()
        {
            string result = stringmax.GenricValue("Banana","Peach","Zebra");
            Assert.AreEqual("Zebra", result);
            Assert.Pass();
        }


    }

}