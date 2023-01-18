using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solveing.Problem
{
    public class Team
    {
        public Team()
        {
            int n = int.Parse(Console.ReadLine() ?? "");
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if (Console.ReadLine()?.Split(" ").Select(x => int.Parse(x)).Sum() >= 2)
                    s++;
            }

            Console.WriteLine(s);
        }
    }
}
