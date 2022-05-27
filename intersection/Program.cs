using System;
using System.Collections.Generic;
using System.Linq;

namespace intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int intersection in Intersection(new int[] { 1, 5, 9, 6, 5, 2 }, new int[] { 5, 9, 8, 2, 10, 9 }))
            {
                Console.WriteLine(intersection);
            }
        }

        public static int[] Intersection(int[] a, int[] b)
        {
            int[] result;
            List<int> aList = a.ToList();
            List<int> bList = b.ToList();
            result = aList.Intersect(bList).ToArray();

            return result;
        }
    }
}
