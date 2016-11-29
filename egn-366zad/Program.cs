using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egn_366zad
{
    class Program
    {
        static void Main(string[] args)
        {
            // wsqka cifra   0*2,1*4,2*8,3*5,4*10,5*9,6*7,7*3,8*6 /11 = 2
            //    2485109736.
            //EGN 8406194582 - 1984
            //EGN 7552011038 - 2075
            //EGN 7524169268 - 1875

            string myEgn = "2405189736";

            int years = int.Parse(myEgn.Substring(0, 2));
            int months = int.Parse(myEgn.Substring(2, 2));
            int days = int.Parse(myEgn.Substring(4,2));

            string genderDigit = myEgn.Substring(8,1);

            bool isFemale = IsFemale(genderDigit);

            Console.WriteLine("Is Lyuben female: " + isFemale);

            if (months > 0 && months < 13 )
            {
                Console.WriteLine("19" + years);
            }
            else if (months > 19 && months < 33)
            {
                months -= 20;
                Console.Write("18" + years);
                Console.WriteLine(".{0}" , months);
                Console.WriteLine(".{0}.{1}", months, days);
                
            }
            else if (months > 40 && months < 53)
            {
                months -= 40;
                Console.WriteLine("20" + years);
                Console.WriteLine(".{0}", months);
                Console.WriteLine(".{0}.{1}", months, days);
            }
            else
            {
                Console.WriteLine("Wrong Data!!! ");

            }

            checkDigitalWeight(myEgn);
        }

        private static void checkDigitalWeight(string egn)
        {
            
            int[] digit = new int[egn.Length];

            for (int i = 0; i < digit.Length; i++)
            {
                digit[i] = egn[i];
                
            }

            int currentSum = (digit[0] *= 2) + (digit[1] *= 4) + (digit[2] *= 8) + (digit[3] *= 5) + (digit[4] *= 10) + (digit[5] *= 9) + (digit[6] *= 7) + (digit[7] *= 3) + (digit[8] *= 6);
            Console.WriteLine(currentSum);
            currentSum = currentSum % 11;
            
          
            if (currentSum == 10)
            {
                currentSum = 0;
            }
            Console.WriteLine(11 - currentSum);
            
        }

        public static bool IsFemale(string genderDigit)
        {
            bool isFemale = false;
            int digit = int.Parse(genderDigit);
            if (digit % 2 != 0) ;
            {
                isFemale = true;
            }
            return isFemale;
        }
    }
}
