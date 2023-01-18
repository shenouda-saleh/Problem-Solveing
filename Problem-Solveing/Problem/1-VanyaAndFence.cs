using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solveing.Problem
{
    public class VanyaAndFence
    {

        public VanyaAndFence()
        {
            var inputLine1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var inputLine2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            int x = 0;

            for (int i = 0; i < inputLine1[0]; i++)
            {
                if (inputLine2[i] > inputLine1[1])
                    x += 2;
                else
                    x++;
            }

            Console.WriteLine(x);

        }
    }
}
