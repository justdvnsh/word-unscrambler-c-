using System;
using System.Collections.Generic;

namespace word_unscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            // lis = [1,2,3,4,5] -> python
            // len(lis) -> 5
            // var myFirstList = new List<int>();
            // myFirstList.Add(10);
            // myFirstList.Add(1);
            // myFirstList.Add(14);
            // myFirstList.Add(15);
            // Console.WriteLine(myFirstList[1]);
            // int[] arr = new int[10];
            // arr[9] = 5;
            // arr[8] = 7;
            // arr[5] = 6;

    // lis = [1,2,3,4,5]
    // for i in lis:
        // print(i)

            int[] arr = { 8,7,6,5,4,3,2,1 };
            Array.Sort(arr);
            // Console.WriteLine(arr[0]);
            // sort(lis)
            foreach ( int i in arr ) {
                Console.WriteLine(arr[i]);
            }
        }
    }
}