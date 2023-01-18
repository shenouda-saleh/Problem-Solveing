using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solveing.Problem
{
    public class BoyOrGirl
    {
        public BoyOrGirl()
        {
            var arr = Console.ReadLine().ToCharArray().Distinct().Count();
            Console.WriteLine(arr % 2 == 0 ? "CHAT WITH HER!" : "IGNORE HIM!");
        }
    }
}
