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


            int zz= leetCode.sockMerchant(9, arr1.ToList());
            Console.WriteLine(zz.ToString());

            Console.ReadKey();

        }





    }
}
