using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class FindIntMax
    {

        public void FindMaxValue(int First, int Second, int Third)       //UC1 finding max of 3 numbers.
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                Console.WriteLine("first is greater :" + First);
            }
            else if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                Console.WriteLine("second is greater :" + Second);
            }
            else if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                Console.WriteLine("third is greater :" + Third);
            }
            else
                Console.WriteLine("All Numbers are Equal! ");
        }
        public void FindMaxValue(float First, float Second, float Third)    // UC2 Finding maximum Of Three Float
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                Console.WriteLine("first is greater :" + First);
            }
            else if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                Console.WriteLine("second is greater :" + Second);
            }
            else if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                Console.WriteLine("third is greater :" + Third);
            }
            else
                Console.WriteLine("All Numbers are Equal! ");

        }
        public void FindMaxValue(string First, string Second, string Third)
        {
            if (First.CompareTo(Second) >= 0 && First.CompareTo(Third) >= 0)
            {
                Console.WriteLine("First is greater :" + First);
            }
            else if (Second.CompareTo(First) >= 0 && Second.CompareTo(Third) >= 0)
            {
                Console.WriteLine("second is greater :" + Second);
            }
            else if (Third.CompareTo(First) >= 0 && Third.CompareTo(Second) >= 0)
            {
                Console.WriteLine("third is greater :" + Third);
            }
            else
                Console.WriteLine("All Numbers are Equal! ");

        }
    }
}