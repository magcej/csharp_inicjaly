using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicjaly
{
    class Program
    {
        static void spacje(int ile)
        {
            for (int m = 0; m < ile; m++)
            {
                Console.Write(" ");
            }
        }
        static void gwiazdki(int ile)
        {
            for (int m = 0; m < ile; m++)
            {
                Console.Write("*");
            }
        }
        static void Main(string[] args)
        {
            LiteraM();
            Console.WriteLine();
            LiteraC();
        }

        static void LiteraM()
        {
            gwiazdki(1);
            spacje(5);
            gwiazdki(1);
            Console.WriteLine();

            gwiazdki(2);
            spacje(3);
            gwiazdki(2);
            Console.WriteLine();

            gwiazdki(1);
            spacje(1);
            gwiazdki(1);
            spacje(1);
            gwiazdki(1);
            spacje(1);
            gwiazdki(1);
            Console.WriteLine();

            gwiazdki(1);
            spacje(2);
            gwiazdki(1);
            spacje(2);
            gwiazdki(1);
            Console.WriteLine();

            for (int i = 1; i <= 3; i++)
            {
                gwiazdki(1);
                spacje(5);
                gwiazdki(1);
                Console.WriteLine();
            }
        }

        static void LiteraC()
        {
            spacje(1);
            gwiazdki(6);
            Console.WriteLine();

            for (int j = 1; j <= 5; j++)
            {
                gwiazdki(1);
                spacje(6);
                Console.WriteLine();
            }

            spacje(1);
            gwiazdki(6);
            Console.WriteLine();
        }

    }


}





