using System.Collections.Generic;

namespace c_
{
    public class pascalsTriangle
    {
       
        static List<List<int>> pTriangle(int num) {

            List<List<int>> results = new List<List<int>>();

            results.Add(new List<int>{1});
            if(num == 1) return results;

            results.Add(new List<int>{1, 1});
            if(num == 2) return results;
            List<int> list = new List<int>{1, 1};


            for(int i = 2; i < num; i++)
            {
                results.Add(new List<int>{1});
                for(int j = 0; j < list.Count-1; j++)
                {
                    var sum = list[j] + list[j+1];
                    results[i].Add(sum);
                }
                results[i].Add(1);
                list = new List<int>(results[i]);
            }

            for(int i = 0; i < results.Count; i++)
            {
                for(int j = 0; j < results[i].Count; j++)
                {
                    System.Console.WriteLine(results[i][j]);
                    System.Console.WriteLine("*****");
                }
                System.Console.WriteLine("the end");
            }
            return results;

        }
    }
}
