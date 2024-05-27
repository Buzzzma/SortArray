using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sort(new List<int> { 1,3,7,5 }, new List<int> { 1, 2, 4, 10 });
        }

        static List<int> Sort(List<int> nums1, List<int> nums2)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums1.Count; i++)
            {

                if (!list.Contains(nums1[i]))
                { list.Add(nums1[i]); }
            }
            for (int i = 0; i < nums2.Count; i++)
            {
                if (!list.Contains(nums2[i])) 
                    { list.Add(nums2[i]); }

            }
            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}, ");
            }
            Console.Write("\n");


            return list;
        }
    }
}
