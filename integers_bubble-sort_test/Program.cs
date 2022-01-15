using System;

namespace IntegersBubbleSort // Note: actual namespace depends on the project name.
{
     class Bubble
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 4, 2, 1, 3 };

            Console.WriteLine("Unordered Array.");
            printArray(array);

            Console.WriteLine("Forward order.");
            BubbleSort(array);
            printArray(array);

            Console.WriteLine("Reverse Order");
            ReverseBubbleSort(array);
            printArray(array);

            char[] array2 = { 'a', 'd', 'c', 'b','e' };
            printCharArray(array2);

            BubbleCharSort(array2);
            printCharArray(array2);

            ReverseBubbleCharSort(array2);
            printCharArray(array2);

            Console.Read();

        }

        static void printArray(int[] array)
        {
            Console.WriteLine("Printing your array:");
            foreach (int p in array)
                Console.Write(p + " ");
            Console.WriteLine("");
        }

        static void BubbleSort(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }

        static void ReverseBubbleSort(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] < array[i + 1]) //just reverse the comparison to print it backwards
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }

        static void printCharArray(Char[] array)
        {
            Console.WriteLine("Printing your array:");
            foreach (Char p in array)
                Console.Write(p + " ");
            Console.WriteLine("");
        }

        public static void BubbleCharSort(Char[] array)
        {
            Char temp;

            // Sorting strings using bubble sort
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = j + 1; i < array.Length; i++)
                {
                    if (array[j].CompareTo(array[i]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
        public static void ReverseBubbleCharSort(Char[] array)
        {
            Char temp;

            // Sorting strings using bubble sort
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = j + 1; i < array.Length; i++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}