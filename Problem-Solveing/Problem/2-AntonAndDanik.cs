using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solveing.Problem
{
    public class AntonAndDanik
    {
        public AntonAndDanik()
        {
            long numberOfPlay = Convert.ToInt64(Console.ReadLine());
            var letters = Console.ReadLine().ToCharArray();
            int Danik = letters.Where(x => x == 'D').Count();
            int Anton = letters.Length - Danik;

            if (Danik > Anton)
                Console.WriteLine("Danik");
            else if (Anton > Danik)
                Console.WriteLine("Anton");
            else
                Console.WriteLine("Friendship");
        }
    }
}
