using System;
using System.Linq;

namespace ex3_array
{
    class Program
    {
        static void Main()
        {
            // Call the method for each task
            FindMaxMinInArray();
            SearchNumberInArray();
            SortArray();
            MergeArrays();
            RemoveDuplicatesFromArray();
            FindSecondLargestInArray();
            CountEvenOddNumbers();
            ReverseArray();
            InitializeAndPrintArray();
        }

        static void FindMaxMinInArray()
        {
            const int n = 10;
            int[] numbers = new int[n];

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    numbers[i] = result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Decrement i to retry the current index
                }
            }

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");
        }

        static void SearchNumberInArray()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
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

        static void MergeArrays()
        {
            Console.WriteLine("Enter the number of elements for each array:");
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

            int[] array3 = new int[array1.Length + array2.Length];
            array1.CopyTo(array3, 0);
            array2.CopyTo(array3, array1.Length);

            Console.WriteLine("The merged array is: " + string.Join(", ", array3));
        }

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

            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine($"Number of even numbers: {evenCount}");
            Console.WriteLine($"Number of odd numbers: {oddCount}");
        }

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

        static void InitializeAndPrintArray()
        {
            // Declare an array of 5 integers
            int[] numbers = new int[5];

            // Assign values to the array
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Print the values using a for loop
            Console.WriteLine("Array elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
