using System;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Xml;

namespace QuickSort
{
    class Program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; //number of comparasion
        private int mov_count = 0; ////number of data  movements

        //private of elements in array
        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Enter The Number Of Elements in The array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }
            Console.WriteLine("\n====================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n====================");


            //get array Elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);

            }
        }
        //swap the elements at index x with the element at index y

        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
        }

        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            //partition the list into two parts:
            //one containing elements less that or equal to pivot
            //outher conntainning elements greather than pivot

            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                //search for an element greather than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
            }

        }

    }
}

