using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 33; i++)
            {
                for (int q = 2; q <= 34; q++)
                {
                    for (int w = 3; w <= 35; w++)
                    {
                        for (int e = 4; e <= 36; e++)
                        {
                            for (int r = 5; r <= 37; r++)
                            {
                                for (int t = 6; t <= 38; t++)
                                {
                                    for (int z = 7; z <= 39; z++)
                                    {
                                        Console.WriteLine(i + " " + q + " " + w + " " + e + " " + r + " " + t + " " + z);
                                    }

                                }
                            }
                        }
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
