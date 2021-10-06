using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeetCode
    {



        public int[] LeetCode1(int[] arr, int traget)
        {
            int[] arr1 = { 0, 0 };
            
            for (int i = 0; i < arr.Length; i++)
            {
                int values;
                int Out_values;
                values = traget - arr[0];
                if (Array.Exists(arr, x => x == values))
                {
                    Out_values = Array.FindIndex(arr, x => x == values);
                     arr1 = new int[] { arr[0], Out_values };
                    return arr1;

                }               
            }
            return arr1;
        }

        public string  LeetCode2(string [] arr)
        {

            

           



            return "";
        }

        public int[] Two_Pointers(int[] arry)
        {
           // int[] arr1 = { -1, 0, 1, 2, -1, -4 };
            int v1;
            int v2;
            int v3;
            for (int i = 0; i < arry.Length; i++)
            {
                v1 = arry[i];
                for (int j = 0; j < arry.Length; j++)
                {
                    if (i == j)
                        continue;
                    v2 = arry[i];
                    for (int k = 0; k < arry.Length; k++)
                    {
                        if (k == j || i == k)
                            continue;
                        v3 = arry[k];

                        if (v1 + v2 + v3 == 0)
                        {
                            return new int[] { v1, v2, v3 };
                        }
                    }
                }
            }
            return new int[0];
        }

        public int [] Rotate_Array(int [] nums, int k)
        {
            int[] nusms2 = nums;
            for (int i = 0; i < k; i++)
            {
                int[] new_nums = new int[nusms2.Length];
                for (int j = 0; j < nusms2.Length; j++)
                {
                    if (j == 0)
                        new_nums[j] = nusms2[nusms2.Length];
                    else if (j== nusms2.Length)
                    {
                        continue;
                    }
                    else
                        new_nums[j + 1] = nusms2[j];
                }
                nusms2 = new_nums;
            }
            return new int[0];        
        }



        public int Search(int[] nums, int target)
        {
            int values=-1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i])
                {
                    values = i;
                }
            }
                return values;
        }

        class Sock
        {
           public  int sock { get; set; }
            public int sock_count { get; set; }
        }
        public int sockMerchant(int n, List<int> ar)
        {
            string memo = string.Empty;
            int sock_count = 0;

            List<Sock> socks = new List<Sock>();
            for (int i = 0; i < ar.Count; i++)
            {
                Sock socks1 = new Sock();
                socks1.sock = ar[i];
                socks1.sock_count = ar.FindAll(x => x == ar[i]).Count;
                socks.Add(socks1);
            }

            List<Sock> sock_List = socks.FindAll(x => x.sock_count > 2);
            for(int i =0; i < sock_List.Count; i++)
            {
                if (!memo.Contains(sock_List[i].sock.ToString() + ";"))
                {
                    sock_count += sock_List[i].sock_count / 2;
                    memo += sock_List[i].sock.ToString() + ";";
                }
            }
            return sock_count;
        }


        public  int hourglassSum(List<List<int>> arr)
        {

            List<int> Lod = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (i + 2 <arr.Count)
                {
                    List<int> Lt1 = arr[i];
                    List<int> Lt2 = arr[i + 1];
                    List<int> Lt3 = arr[i + 2];
                    for (int j = 0; j < Lt1.Count; j++)
                    {
                        if(j + 2 <arr.Count)
                        {
                            int add_values = Lt1[j] + Lt1[j + 1] + Lt1[j + 2] + Lt2[j + 1] + Lt3[j] + Lt3[j + 1] + Lt3[j + 2];
                            Lod.Add(add_values);                        
                        }
                    }
                }
            }
            return Lod.Max();
        }

        public  int countingValleys(int steps, string path)
        {
            int v = 0;
            List<int> List = new List<int>();
            List.Add(0);
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 'U')
                {
                    v = v + 1;
                    List.Add(v);
                }
                else
                {
                    v = v - 1;
                    List.Add(v);
                }
            }
            List.Add(0);
            int down_count = 0;
            bool InLine = false;
            for (int i =0; i < List.Count; i++)
            {
                if (List[i] == 0)
                {
                    InLine=true;
                }
                if (List[i] < 0&& InLine)
                {
                    down_count++;
                    InLine = false;
                }
            }
            return down_count;
        }

        public  string receivedText(string S)
        {
            // WRITE DOWN YOUR CODE HERE

            //
            int now_index = 0;
            bool First = true;
            string first_str = string.Empty;
            bool Nub_Ok = true; 
            string Values = string.Empty;
            for(int i = 0; i < S.Length; i++)
            {

                if (S[i]== '<') //回到最前面
                {

                }
                if(S[i] == '>')//最後面
                {
 
                }
                if(S[i] == '*') //刪除
                {
       
                }
                if (S[i] == '#')
                {

                }
                else
                {
                    
                }
            }


            return string.Empty;
        }



        public  int jumpingOnClouds(List<int> c)
        {
            var jumps = 0;
            for (int i = 0; i < c.Count - 1; i++, jumps++)
                if (i + 2 < c.Count && c[i + 2] == 0)
                    i++;

            return jumps;
        }


        public  string twoStrings(string s1, string s2)
        {
            string c = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < c.Length; i++)
            {
                if (s1.Contains(c[i]) && s2.Contains(c[i]))
                {
                    return "YES";
                }
            }
            return "NO";
        }


        public static int maximumToys(List<int> prices, int k)
        {
            prices.Sort();
            int count = 0;
            int prices_now = 0;
            for (int i = 0; i < prices.Count; i++)
            {
                prices_now = prices_now + prices[i];
                if (prices_now < k)
                    count++;
                else
                    return count;
            }
            return count;
        }

        public  int alternatingCharacters(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i+1 == s.Length)
                {
                    if (s[i] != s[i - 1])
                        continue;
                }
                else {

                    if (s[i] != s[i + 1])
                        continue;
                    else if (s[i] == 0)
                    {
                        if (s[i] != s[i - 1])
                            continue;
                        else
                            count++;
                    }               
                    else
                        count++;
                }              
            }
            return count;
        }

        public  int makeAnagram(string a, string b)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;
            for (int i = 0; i < abc.Length; i++)
            {
                if (!a.Contains(abc[i]) && !b.Contains(abc[i]))
                {
                    int a_b_difff = a.Split(abc[i]).Length != b.Split(abc[i]).Length ? Math.Abs(a.Split(abc[i]).Length - b.Split(abc[i]).Length) : 0;
                    count = count + a_b_difff;
                }
                else if (!a.Contains(abc[i]) && b.Contains(abc[i]))
                {
                    int str_count = a.Split(abc[i]).Length;
                    count = count + str_count;
                }
                else if (a.Contains(abc[i]) && !b.Contains(abc[i]))
                {
                    int str_count = b.Split(abc[i]).Length;
                    count = count + str_count;
                }
            }
            return count;
        }


        public static void minimumBribes(List<int> q)
        {
            int count = 0;
            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] > q[i + 1])
                {
                    count++;
                }

            }
        }

        public  List<int> rotLeft(List<int> a, int d)
        {    
            List<int> List = a;
            List<int> List_new = new List<int>();       
            for (int i = 0; i < d; i++)
            {
                List_new = new List<int>();
                for (int j = 0; j < List.Count; j++)
                {
                    if (j == List.Count - 1)
                        List_new.Add(List[0]);
                    else
                        List_new.Add(List[j + 1]);
                }
                List = List_new;
                
            }
            return List;
        }


        public  int sockMerchantKai(int n, List<int> ar)
        {
            int count = 0;
            //string Socks = string.Empty;
            string reco = string.Empty;
            for (int i = 0; i < n; i++)
            {
                if (reco.Contains(";"+ar[i].ToString()+";"))
                    continue;
                int Socks = ar.FindAll(x => x == ar[i]).Count;
                count += Socks >= 2 ? Socks / 2 : 0;
                reco += ";"+ar[i].ToString() + ";";
            }
            return count;
        }

    }
}
