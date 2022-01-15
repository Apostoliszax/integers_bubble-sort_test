using System;

namespace IntegersBubbleSort // Note: actual namespace depends on the project name.
{
    class Bubble
    {
        static void Main(string[] args)
        {
            int[] intArray = { 5, 4, 2, 1, 3 };

            Console.WriteLine("Unordered integer array.");
            printAnyArray(intArray);

            Console.WriteLine("Forward order for integer array.");
            OneBubbleSort(intArray: intArray);
            printAnyArray(intArray);

            Console.WriteLine("Reverse for integer Order");
            OneReverseBubbleSort(intArray: intArray);
            printAnyArray(intArray);

            char[] chArray = { 'a', 'd', 'c', 'b', 'e' };
            Console.WriteLine("Unordered character array.");
            printAnyArray(chArray: chArray);

            Console.WriteLine("Forward character order.");
            OneBubbleSort(chArray: chArray);
            printAnyArray(chArray: chArray);

            Console.WriteLine("Reverse character order.");
            OneReverseBubbleSort(chArray: chArray);
            printAnyArray(chArray: chArray);

            Console.Read();

        }

        static void printAnyArray(int[] intArray = null,   Char[] chArray = null)
        {
            if (intArray != null)
            {
                var str = String.Join(",", intArray);
                Console.WriteLine(str);
            }

            if (chArray != null)
            {
                var str = String.Join(",", chArray);
                Console.WriteLine(str);
            }
        }

        static void OneBubbleSort(char[] chArray = null , int[] intArray = null)
        {
            if (chArray != null)
            {
                Char temp;

                // Sorting strings using bubble sort
                for (int j = 0; j < chArray.Length - 1; j++)
                {
                    for (int i = j + 1; i < chArray.Length; i++)
                    {
                        if (chArray[j].CompareTo(chArray[i]) > 0)
                        {
                            temp = chArray[j];
                            chArray[j] = chArray[i];
                            chArray[i] = temp;
                        }
                    }
                }
            }

            if (intArray != null)
            {
                int temp;
                for (int j = 0; j <= intArray.Length - 2; j++)
                {
                    for (int i = 0; i <= intArray.Length - 2; i++)
                    {
                        if (intArray[i] > intArray[i + 1])
                        {
                            temp = intArray[i + 1];
                            intArray[i + 1] = intArray[i];
                            intArray[i] = temp;
                        }
                    }
                }
            }
        }

        static void OneReverseBubbleSort(char[] chArray = null, int[] intArray = null)
        {
            if (chArray != null)
            {
                Char temp;

                // Sorting strings using bubble sort
                for (int j = 0; j < chArray.Length - 1; j++)
                {
                    for (int i = j + 1; i < chArray.Length; i++)
                    {
                        if (chArray[i].CompareTo(chArray[j]) > 0)
                        {
                            temp = chArray[i];
                            chArray[i] = chArray[j];
                            chArray[j] = temp;
                        }
                    }
                }
            }

            if (intArray != null)
            {
                int temp;
                for (int j = 0; j <= intArray.Length - 2; j++)
                {
                    for (int i = 0; i <= intArray.Length - 2; i++)
                    {
                        if (intArray[i] < intArray[i + 1]) //just reverse the comparison to print it backwards
                        {
                            temp = intArray[i + 1];
                            intArray[i + 1] = intArray[i];
                            intArray[i] = temp;
                        }
                    }
                }
            }
        }
    }
}