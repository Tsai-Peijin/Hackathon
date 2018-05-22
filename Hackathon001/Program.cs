using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon001
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                string value = i.ToString();
                value = value.Replace("3","A").Replace("5","B").Replace("9","C").Replace("0","D");
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
