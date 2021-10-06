using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {
            LeetCode leetCode = new LeetCode();
            int[] arr1 = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            //List<int> li = arr1.ToList();
            //int[] view= leetCode.Two_Pointers(arr1);


            //int zz= leetCode.makeAnagram("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke");
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Add(5);
            List<int> result = leetCode.rotLeft(a, 4);

            Console.WriteLine(String.Join(" ", result));

            Console.ReadKey();

        }





    }
}
