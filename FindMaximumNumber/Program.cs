using FindMaximumNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            FindIntMax integerfindmax = new FindIntMax();
            integerfindmax.FindMaxValue(13,20,23);
            Console.ReadLine();
        }
    }
}
