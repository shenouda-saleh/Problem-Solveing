using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solveing.Problem
{
    public class Word
    {
        public Word()
        {
            var arr = Console.ReadLine();
            var len = arr.ToCharArray().Where(x => char.IsLower(x)).Count();
            Console.WriteLine(len >= Math.Abs(arr.Length - len) ? arr.ToLower() : arr.ToUpper());
        }
    }
}
