using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon002
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            int n = 0;
            int y = 0;


            for (x = 12; x > 0; x--)
            {
                y++;
                n++;
                while (n == 3)
                {
                    x--;
                    n = 1;
                }

            }
            Console.Write(y);
            Console.ReadLine();
        }
    }
}
