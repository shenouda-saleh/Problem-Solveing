using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solveing.Problem
{
    public class PetyaAndStrings
    {
        public PetyaAndStrings()
        {
            string lineOne = Console.ReadLine().ToLower();
            string lineTwo = Console.ReadLine().ToLower();
            int x=lineOne.CompareTo(lineTwo);
            Console.WriteLine(x);   

        }
    }
}
