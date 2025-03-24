using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal("муся", 8);
            cow.ShowData();
            cow.voice();
            Console.ReadKey();
        }
    }
}
