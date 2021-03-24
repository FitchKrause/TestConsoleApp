using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Initialization
            int MaxNumIterations = 16;
            int OutNums = 0;

            for (int i = 1; i <= MaxNumIterations; i++)
            {
                OutNums = 8 * i;
                if (OutNums % 16 == 0)
                {
                    OutNums += MathMagic(OutNums, 8);
                }
                Console.WriteLine(OutNums);
            }

            ///Test function
            int MathMagic(int Num, int Multiplier)
            {
                return Num * Multiplier;
            }
        }
    }
}
