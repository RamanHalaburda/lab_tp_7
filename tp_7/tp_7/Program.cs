using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int S = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 9; ++i)
                for (int j = 0; j <= 9; ++j)
                        if ((i + j == S) && (i + j >= A) && (i + j <= B))
                            Console.WriteLine(i.ToString() + j.ToString());
            for (int i = 1; i <= 9; ++i)
                for (int j = 0; j <= 9; ++j)
                    for (int k = 0; k <= 9; ++k)
                        if ((i + j + k == S) && (i + j + k >= A) && (i + j + k <= B))
                            Console.WriteLine(i.ToString() + j.ToString() + k.ToString());
            Console.ReadLine();
        }
    }
}
