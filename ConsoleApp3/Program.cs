using System;

namespace ExercisesPart1Solve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Simple Calculator");
                Console.WriteLine("2. Basic ATM System");
                Console.WriteLine("3. Geometry Calculator");
                Console.WriteLine("4. Factorial of a Number");
                Console.WriteLine("5. Sum of Even and Odd Numbers");
                Console.WriteLine("6. Scientific Calculator");
                Console.WriteLine("7. Print Triangle Pattern");
                Console.WriteLine("8. Print Pyramid Pattern");
                Console.WriteLine("9. Print Diamond Pattern");
                Console.WriteLine("10. Guess the Number Game");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.. enter a number:");
                    continue;
                }

                switch (choice)
                {
                    case 1: SimpleCalculator(); break;
                    case 2: BasicATM(); break;
                    case 3: GeometryCalculator(); break;
                    case 4: Factorial(); break;
                    case 5: SumEvenOdd(); break;
                    case 6: ScientificCalculator(); break;
                    case 7: PrintTriangle(); break;
                    case 8: PrintPyramid(); break;
                    case 9: PrintDiamond(); break;
                    case 10: GuessGame(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid Choice.. Try again.."); break;
                }
                Console.ReadLine();
            }
        }

        // 1. Simple Calculator
        static void SimpleCalculator()
        {
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.Write("\nEnter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+': Console.WriteLine("Area:" + (num1 + num2)); break;
                case '-': Console.WriteLine("Area:" + (num1 - num2)); break;
                case '*': Console.WriteLine("Area:" + (num1 * num2)); break;
                case '/': Console.WriteLine(num2 != 0 ? "Area:" + (num1 / num2) : "Error: Division by zero!"); break;
                default: Console.WriteLine("Invalid operator.."); break;
            }
        }

        // 2. Basic ATM System
        static void BasicATM()
        {
            double balance = 1000;
            while (true)
            {
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter withdrawal amount: ");
                        double withdraw = double.Parse(Console.ReadLine());
                        if (withdraw > balance) Console.WriteLine("Insufficient funds!");
                        else { balance -= withdraw; Console.WriteLine($"Withdrawal successful! New balance:" + balance); }
                        break;
                    case 2:
                        Console.Write("Enter deposit amount: ");
                        double deposit = double.Parse(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine("Deposit successful! New balance:" + balance);
                        break;
                    case 3:
                        Console.WriteLine($"Current Balance:" + balance);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice..");
                        break;
                }
            }
        }

        // 3. Geometry Calculator
        static void GeometryCalculator()
        {
            Console.WriteLine("\nChoose a shape:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Triangle");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area: {Math.PI * r * r}, Circumference: {2 * Math.PI * r}");
                    break;
                case 2:
                    Console.Write("Enter side length: ");
                    double s = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area:" + s * s, " Perimeter:" + 4 * s);
                    break;
                case 3:
                    Console.Write("Enter base: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area:" + (0.5 * b * h));
                    break;
                default:
                    Console.WriteLine("Invalid choice..");
                    break;
            }
        }

        // 4. Factorial
        static void Factorial()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i <= n; i++) fact *= i;
            Console.WriteLine($"Factorial: {fact}");
        }

        // 5. Sum of Even and Odd Numbers
        static void SumEvenOdd()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0, sumOdd = 0;
            for (int i = 1; i <= n; i++)
                if (i % 2 == 0) sumEven += i; else sumOdd += i;
            Console.WriteLine("Area:" + sumEven, " Perimeter:" + sumOdd);
        }

        // 6. Scientific Calculator
        static void ScientificCalculator()
        {
            Console.Write("Choose operation (sin, cos, tan, sqrt, log, pow): ");
            string op = Console.ReadLine();
            Console.Write("Enter number: ");
            double num = double.Parse(Console.ReadLine());

            switch (op)
            {
                case "sin": Console.WriteLine("Result:" + Math.Sin(num)); break;
                case "cos": Console.WriteLine("Result:" + Math.Cos(num)); break;
                case "tan": Console.WriteLine("Result:" + Math.Tan(num)); break;
                case "sqrt": Console.WriteLine("Result:" + Math.Sqrt(num)); break;
                case "log": Console.WriteLine("Result:" + Math.Log(num)); break;
                case "pow":
                    Console.Write("Enter exponent: ");
                    double exp = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result:" + Math.Pow(num, exp));
                    break;
                default: Console.WriteLine("Invalid operation.."); break;
            }
        }

        // 7. Print Triangle Pattern
        static void PrintTriangle()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string('*', i));
        }

        // 8. Print Pyramid Pattern
        static void PrintPyramid()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
        }

        // 9. Print Diamond Pattern
        static void PrintDiamond()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            // Upper part of the diamond
            for (int i = 1; i <= n; i++)
            {
                PrintRow(i, n);
            }

            // Lower part of the diamond
            for (int i = n - 1; i >= 1; i--)
            {
                PrintRow(i, n);
            }
        }

        // 10. Guess Game
        static void GuessGame()
        {
            Random random = new Random();
            int target = random.Next(1, 101);
            int guess;

            do
            {
                Console.Write("Guess the number (1-100): ");
                guess = int.Parse(Console.ReadLine());

                if (guess > target)
                    Console.WriteLine("Try Lower!");
                else if (guess < target)
                    Console.WriteLine("Try Higher!");
                else
                    Console.WriteLine("You Win!");
            } while (guess != target);
        }

        static void PrintRow(int i, int n)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}