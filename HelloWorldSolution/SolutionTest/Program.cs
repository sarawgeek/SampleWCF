using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrToPass = { 1, 4, 45, 6, 10, 8 };
           string val =  triplet_sum(arrToPass, 6, 22);
           Console.WriteLine(val);
           Console.ReadLine();
        }

        public static string triplet_sum(int[] intArray, int length, int sum)
        {
            bool returnVal = false;
            for (int i = 0; i < length; i++)
            {
                if (intArray[i] <= sum)
                {
                    int left = sum - intArray[i];
                    if (left == 0)
                    {
                        returnVal = true;
                        return "True";

                    }
                    else
                    {
                        int[] tmpArray = (intArray.Where((source, index) => index != i).ToArray()).Where(n => n <= left).ToArray();
                        if (tmpArray.Length != 0)
                        {
                            triplet_sum(tmpArray, tmpArray.Length, left);
                           


                        }
                        else return "False";

                    }
                } else return "False";
               
            }
            if (returnVal)
            {
                return "True";
            }
            else return "False";
            
        }
    }
}
