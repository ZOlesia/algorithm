using System.Collections.Generic;
using System.Linq;

namespace c_
{
    public class happy
    {
        public static bool isHappy(int n)
        {

            List<int> list = new List<int>();
            while(n!=1)
            {
                n = numSum(n);
                if(list.Contains(n))
                {
                    return false;
                } 
                list.Add(n);

            }
            return true;
        }
        public static int numSum(int n)
        {
            int sum = 0;
            while(n != 0)
            {
                sum += (n % 10) * (n % 10);
                n = n / 10;
            }
            return sum;
        }



        static void Main(string[] args)
        {
            System.Console.WriteLine(isHappy(23));
        }
    }
}