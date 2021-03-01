using System;

namespace DevE_L04_Single_Dimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Maks! Now you'll watch the Single-Dimensional Array being fried:");

            Random random = new Random();
            int[] friedArray = new int[8];

            Console.Write("Array: ");

            for (int i = 0; i < friedArray.Length; i++)
            {
                friedArray[i] = random.Next(1, 9);
                Console.Write(friedArray[i]);
            }
            Console.WriteLine("");

            FirstTask(friedArray);
            SecondTask(friedArray);
            ThirdTask(friedArray);
            FourthTask(friedArray);
            FifthTask(friedArray);
            SixthTask(friedArray);
            SeventhTask(friedArray);
            EighthTask(friedArray);
            NinthTask(friedArray);
            TehthTask(friedArray);
            AdditionTask(friedArray);


            static void FirstTask(int[] arr)
            {
                Console.WriteLine("First Task: search min value...");
                int[] array = arr;
                int min = 10;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                Console.WriteLine($"Min value from fried array is {min}");
                Console.WriteLine(("").PadRight(50, '-'));
            }

            static void SecondTask(int[] arr)
            {
                Console.WriteLine("Second Task: search max value...");
                int[] array = arr;
                int max = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                Console.WriteLine($"Max value from fried array is {max}");
                Console.WriteLine(("").PadRight(50, '-'));
            }

            static void ThirdTask(int[] arr)
            {
                Console.WriteLine("Third Task: search min value index...");
                int[] array = arr;
                int min = 10;
                int index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        index = i;
                    }
                }
                Console.WriteLine($"Index of first min value from fried array is {index}");
                Console.WriteLine(("").PadRight(50, '-'));
            }

            static void FourthTask(int[] arr)
            {
                Console.WriteLine("Fourth Task: search max value index...");
                int[] array = arr;
                int max = 0;
                int index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        index = i;
                    }
                }
                Console.WriteLine($"Index of first max value from fried array is {index}");
                Console.WriteLine(("").PadRight(50, '-'));
            }

            static void FifthTask(int[] arr)
            {
                Console.WriteLine("Fifth Task: search sum of values with odd index...");
                int[] array = arr;
                int sum = 0;
                for (int i = 1; i < array.Length; i += 2)
                {
                    sum += array[i];
                }
                Console.WriteLine($"Sum of odd indexes value from fried array is {sum}");
                Console.WriteLine(("").PadRight(50, '-'));
            }

            static void SixthTask(int[] arr)
            {
                Console.WriteLine("Sixth Task: reverse array without temp...");
                Console.Write("Reversed array: ");
                int[] array = arr;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.Write(array[i]);
                }
                Console.WriteLine("");
                Console.WriteLine(("").PadRight(50, '-'));
            }

            static void SeventhTask(int[] arr)
            {
                Console.WriteLine("Seventh Task: count odd elements...");
                int[] array = arr;
                int quantity = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        quantity++;
                    }
                }
                Console.WriteLine($"Count odd elements of fried array {quantity}");
                Console.WriteLine(("").PadRight(50, '-'));
            }

            static void EighthTask(int[] arr)
            {
                Console.WriteLine("Eigh Task: change half fried array with other...");
                int[] array = arr;
                int mid = array.Length / 2;
                int[] first = array[..mid];
                int[] second = array[mid..];

                Console.Write("{0}", String.Join("", second));
                Console.WriteLine("{0}", String.Join("", first));

                // It's joke, I guess it should be in such way:
                //int[] hotFriedArray = new int[array.Length];
                //do
                //{
                //    int i = 0;
                //    int j = 0;
                //    for (j = array.Length / 2; j < array.Length; j++)
                //    {
                //        hotFriedArray[j] = array[i];
                //        i++;
                //    }

                //    j = array.Length / 2;
                //    for (i = 0; i < array.Length / 2; i++)
                //    {
                //        hotFriedArray[i] = array[j];
                //        j++;
                //    }
                //}
                //while (false);

                //Console.Write("The hot fried array is: ");
                //Console.Write("[{0}]", string.Join(", ", hotFriedArray));
                //Console.WriteLine();
                Console.WriteLine(("").PadRight(50, '-'));
            }

            static void NinthTask(int[] arr)
            {
                Console.WriteLine("Ninth Task: Mr. Buble Sort is coming to the ring...");
                int[] array = arr;

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[i])
                        {
                            int temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        }
                    }
                }
                Console.Write("Sorted by Bubble: {0}", String.Join("", array));
                Console.WriteLine();
                Console.WriteLine(("").PadRight(50, '-'));
            }
            static void TehthTask(int[] arr)
            {
                Console.WriteLine("Tehth Task: Mr. Select Sort is coming to the ring...");
                int[] array = arr;

                for (int i = 0; i < array.Length; i++)
                {
                    int iMin = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] > array[iMin])
                        {
                            iMin = j;
                        }
                    }
                    int minValue = array[iMin];
                    array[iMin] = array[i];
                    array[i] = minValue;
                }
                Console.Write("Sorted by Selection: {0}", String.Join("", array));
                Console.WriteLine();
                Console.WriteLine(("").PadRight(50, '-'));
            }

            static void AdditionTask(int[] arr)
            {
                Console.WriteLine("Addition Task: Mr. Insert Sort is coming to the ring...");
                int[] array = arr;

                for (int i = 1; i < array.Length; i++)
                {
                    int value = array[i];
                    int position = i;

                    while (position > 0 && array[position-1] > value)
                    {
                        array[position] = array[position - 1];
                        position--;
                    }
                    array[position] = value;

                }
                Console.Write("Sorted by Selection: {0}", String.Join("", array));
                Console.WriteLine();
                Console.WriteLine(("").PadRight(50, '-'));
            }
        }
    }
}
