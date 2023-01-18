using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solveing.Problem
{
    public class BearAndBigBrother
    {
        public BearAndBigBrother()
        {
            var inputLine = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            int year=0;

            while (inputLine[1] >= inputLine[0])
            {
                inputLine[0] = inputLine[0] * 3;
                inputLine[1] = inputLine[1] * 2;
                year++;
            }

            Console.WriteLine(year);
        }
    }

}
