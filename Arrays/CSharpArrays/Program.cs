using System;

namespace FixedSizeArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 550000000;
            int[] array = new int[size];
            int count = size;

            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }

            // insert an element near the beginning
            int index = 10;
            int valueToInsert = 99999;

            var startTime = DateTime.Now;

            // if the array is full and needs resizing: (in this case - yes)
            if (count == array.Length)
            {
                // create a new array with 2x the size
                int[] newArray = new int[array.Length * 2];
                Array.Copy(array, newArray, array.Length);
                array = newArray;  // replace old array with a new array
            }

            // index 2
            // [1,2,3,4]
            // count 4:
            // i = 4-1 = 3
            // 3 >= 2 / true
            // array[4] = array[3]
            // [1,2,3,4,4]

            // second iteration:
            // i = 2
            // 2 >= 2 / true
            // array[3] = array[2]
            // [1,2,3,3,4]

            // last:
            // i = 1
            // 1 >= 2 / false
            // breaks
            // [1,2,3,3,4]
            // [1,2,_,3,4] _ where new element would go.

            // shifting elements to right 
            for (int i = count - 1; i >= index; i--)
            {
                array[i + 1] = array[i];
            }

            // insert the new element
            array[index] = valueToInsert;

            var endTime = DateTime.Now;

            var timeTaken = (endTime - startTime).TotalSeconds;
            Console.WriteLine($"Time taken to insert the element near the beginning: {timeTaken} seconds");

            // verify 
            Console.WriteLine("First 20 elements of the array after insertion:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
