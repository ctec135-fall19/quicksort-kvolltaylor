/*
 Katrina Voll-Taylor
 Module 10, Program Quicksort
 9 December 2019

    TASK: Program Quicksort
        1. Create a solution named "Sort"
        2. Create a console app project named "QuickSort"
        3. Create static methods as needed to program the algorithm provided 
           in the slides for this module
        4. To test your algorithm create a data structure with at least 10 
           elements filled with random int values. 
        5. Print the initial values before calling your quick sort method
        6. Print the final values after completion of your method. 
        7. Print a count of the number of swaps required to sort the values.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {

        // INPUT: a random array of 10 numbers
        // PROCESS: sort numbers by creating partition points that 
        //          determine placement from low to high until all
        //          numbers are in order
        // OUTPUT: print the random array, the sorted array, and the 
        //         number of times numbers needed to be swapped in the 
        //         array in order to be sorted

        static void Main(string[] args)
        {
            // declare and initialize an array to quicksort
            int[] myArray = new int[] {77, 42, 65, 38, 17, 99, 24, 51, 4, 83};

            // print out the values in the array before sorting
            Console.WriteLine("The values in the array before sorting:");
            Console.Write("*   ");
            foreach (int item in myArray)
            {
                Console.Write(item + "   *   ");
            }
            Console.WriteLine("\n");

            // call sorting method to sort all the values in the array
            quicksort(myArray, 0, myArray.Length - 1);

            // print out the values in the array after sorting
            Console.WriteLine("The values in the array after sorting:");
            Console.Write("*   ");
            foreach (int item in myArray)
            {
                Console.Write(item + "   *   ");
            }
            Console.WriteLine("\n");

            // print out the number of swaps needed to sort array
            Console.WriteLine("The number of swaps performed: {0}", swapCount);
            Console.WriteLine("\n");


        }

        // initialize and declare variable to hold count of swaps performed
        public static int swapCount = 0;

        // Sorting method
        static void quicksort(int[] A, int lo, int hi)
        {

            if (lo < hi)
            {
                // declare and determine a partition by
                // calling the partition method
                int p = partition(A, lo, hi);

                // change the value if needed based on the partition 
                // uses recursive calls to call itself
                if (p > 1)
                {
                    quicksort(A, lo, p - 1);

                    // every time this condition determines a swap is needed,
                    // increase the swap count by one
                    swapCount++;
                }
                if (p + 1 < hi)
                {
                    quicksort(A, p + 1, hi);

                    // every time this condition determines a swap is needed,
                    // increase the swap count by one
                    swapCount++;
                }
            }

        }

        // Partitioning method
        static int partition(int[] A, int lo, int hi)
        {
            // create a pivot point
            int pivot = A[lo + (hi - lo) / 2];

            // declare and initialize highest and lowest index values the
            // partition will fall between
            int i = lo - 1;
            int j = hi + 1;

            while (true)
            {
                // increment the value of the low end index up by one while its value
                // is lower than the pivot point selected
                do { i = i + 1; }
                while (A[i] < pivot);

                // increment the value of the high end index down by one while its 
                // value is higher than the pivot point selected
                do { j = j - 1; }
                while (A[j] > pivot);

                // reorder the collection
                
                // if the low end index value is higher than or equal to the
                // high end, then return the high
                if (i >= j)
                {
                    return j;
                }
                else
                {
                    // if the values in the low and high index positions are equal,
                    // then return the high end index
                    if (A[i] == A[j]) return j;

                    // declare and intialize a variable to hold the current low
                    // value and then use it to change positions with the higher one
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
        }

    } // end Program
} // end QuickSort
