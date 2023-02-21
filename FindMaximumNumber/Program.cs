
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            FindIntMax integerfindmax = new FindIntMax();
            integerfindmax.FindMaxValue(13,20,23);
            integerfindmax.FindMaxValue(9.5f, 10.2f, 23.4f);
            Console.ReadLine();
        }
    }
}
