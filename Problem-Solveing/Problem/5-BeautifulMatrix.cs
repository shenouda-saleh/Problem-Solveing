using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solveing.Problem
{
    public class BeautifulMatrix
    {
        public BeautifulMatrix()
        {
            var x0 = Console.ReadLine()?.Split(" ").Select(x => int.Parse(x)).ToArray();
            var x1 = Console.ReadLine()?.Split(" ").Select(x => int.Parse(x)).ToArray();
            var x2 = Console.ReadLine()?.Split(" ").Select(x => int.Parse(x)).ToArray();
            var x3 = Console.ReadLine()?.Split(" ").Select(x => int.Parse(x)).ToArray();
            var x4 = Console.ReadLine()?.Split(" ").Select(x => int.Parse(x)).ToArray();

            int Row = -1, Column = -1;

            for (int x = 0; x < 5; x++)
            {
                if (x0[x] == 1)
                {
                    Row = 0;
                    Column = x;
                    break;
                }
                else if (x1[x] == 1)
                {
                    Row = 1;
                    Column = x;
                    break;
                }
                else if (x2[x] == 1)
                {
                    Row = 2;
                    Column = x;
                    break;
                }
                else if (x3[x] == 1)
                {
                    Row = 3;
                    Column = x;
                    break;
                }
                else if (x4[x] == 1)
                {
                    Row = 4;
                    Column = x;
                    break;
                }

            }

            Console.WriteLine(Math.Abs(Row - 2) + Math.Abs(Column - 2));
        }
    }
}
