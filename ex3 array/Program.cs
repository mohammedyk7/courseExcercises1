using System;
using System.Linq;
using System.Collections.Generic;

namespace ex3_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Array Initialization & Output");
                Console.WriteLine("2. Find Maximum & Minimum in an Array");
                Console.WriteLine("3. Count Even & Odd Numbers");
                Console.WriteLine("4. Reverse an Array");
                Console.WriteLine("5. Search for a Number in an Array");
                Console.WriteLine("6. Sorting an Array (Ascending Order)");
                Console.WriteLine("7. Merging Two Arrays");
                Console.WriteLine("8. Remove Duplicates from an Array");
                Console.WriteLine("9. Second Largest Number in an Array");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.. enter a number:");
                    continue;
                }

                switch (choice)
                {
                    case 1: InitializeAndPrintArray(); break;
                    case 2: FindMaxMinInArray(); break;
                    case 3: CountEvenOddNumbers(); break;
                    case 4: ReverseArray(); break;
                    case 5: SearchNumberInArray(); break;
                    case 6: SortArray(); break;
                    case 7: MergeArrays(); break;
                    case 8: RemoveDuplicatesFromArray(); break;
                    case 9: FindSecondLargestInArray(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid Choice.. Try again.."); break;
                }
                Console.ReadLine();
            }
        }

        // 1. Array Initialization & Output
        static void InitializeAndPrintArray()
        {
            int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

            Console.WriteLine("Array elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // 2. Find Maximum & Minimum in an Array
        static void FindMaxMinInArray()
        {
            const int n = 10;
            int[] numbers = new int[n];

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");
        }

        // 3. Count Even & Odd Numbers
        static void CountEvenOddNumbers()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int evenCount = numbers.Count(num => num % 2 == 0);
            int oddCount = numbers.Count(num => num % 2 != 0);

            Console.WriteLine($"Number of even numbers: {evenCount}");
            Console.WriteLine($"Number of odd numbers: {oddCount}");
        }

        // 4. Reverse an Array
        static void ReverseArray()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);

            Console.WriteLine("Reversed array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // 5. Search for a Number in an Array
        static void SearchNumberInArray()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number to search for: ");
            int searchNumber = int.Parse(Console.ReadLine());

            int index = Array.IndexOf(numbers, searchNumber);

            if (index != -1)
            {
                Console.WriteLine("Number found at index: " + index);
            }
            else
            {
                Console.WriteLine("Number not found in the array.");
            }
        }

        // 6. Sorting an Array (Ascending Order)
        static void SortArray()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("Sorted array in ascending order:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // 7. Merging Two Arrays
        static void MergeArrays()
        {
            Console.Write("Enter the number of elements for each array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            Console.WriteLine("Enter the elements of the first array:");
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the elements of the second array:");
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            int[] mergedArray = new int[array1.Length + array2.Length];
            array1.CopyTo(mergedArray, 0);
            array2.CopyTo(mergedArray, array1.Length);

            Console.WriteLine("The merged array is: " + string.Join(", ", mergedArray));
        }

        // 8. Remove Duplicates from an Array
        static void RemoveDuplicatesFromArray()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] uniqueNumbers = numbers.Distinct().ToArray();

            Console.WriteLine("Unique numbers in the array:");
            for (int i = 0; i < uniqueNumbers.Length; i++)
            {
                Console.WriteLine(uniqueNumbers[i]);
            }
        }

        // 9. Second Largest Number in an Array
        static void FindSecondLargestInArray()
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int secondLargest = FindSecondLargest(array);

            Console.WriteLine("The second largest number is: " + secondLargest);
        }

        static int FindSecondLargest(int[] arr)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            if (secondLargest == int.MinValue)
            {
                Console.WriteLine("No second largest number found.");
                return -1;
            }

            return secondLargest;
        }
    }
}
