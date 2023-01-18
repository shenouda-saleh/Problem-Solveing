using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solveing.Problem
{
    public class GravityFlip
    {
        public GravityFlip()
        {
            int num = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            Array.Sort(arr);

            for (int i = 0; i < num; i++)
                Console.Write(arr[i] + " ");

        }
    }
}
