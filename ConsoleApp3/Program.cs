﻿using System;

namespace ExercisesPart1Solve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////postfix and prefix
            //int x , k;
            //x = k = 6;          

            //int y = x++; //postfix
            //int z = ++k; //prefix

            //Console.WriteLine(y + "  " + z); //y=6 , z=7

            ////Even or Odd
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //    Console.WriteLine("The number is Even.");
            //else
            //    Console.WriteLine("The number is Odd.");


            //Console.WriteLine("-------------------------------------------------");
            ////-------------------------------------------------------


            //////Largest of Three Numbers
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int num3 = int.Parse(Console.ReadLine());

            //int largest = num1;

            //if(largest > num2)
            //{
            //    if (largest > num3)
            //        Console.WriteLine("The largest number is:"+largest);
            //}
            //else 
            //{
            //    largest = num2;

            //    if (largest > num3)
            //        Console.WriteLine("The largest number is:" + largest);
            //    else
            //        Console.WriteLine("The largest number is:" + num3);

            //}

            //Console.WriteLine("-------------------------------------------------");

            //////-----------------------------------------------------------

            //////Temperature Converter
            //Console.Write("Enter temperature in Celsius: ");
            //double celsius = double.Parse(Console.ReadLine());

            //double fahrenheit = (celsius * 9 / 5) + 32;

            //Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            //Console.WriteLine("-------------------------------------------------");

            //////----------------------------------------------------------

            //////Simple Discount Calculator
            //Console.Write("Enter the price of the item: ");
            //double price = double.Parse(Console.ReadLine());
            //double discount = 0;

            //double finalPrice;

            //if(price >100)
            //{
            //    discount = (price / 100) * 10;
            //    finalPrice = price - discount;
            //    Console.WriteLine("Final price is:" + finalPrice);

            //}
            //else 
            //{
            //    Console.WriteLine("Final price is:" + price);

            //}

            //Console.WriteLine("-------------------------------------------------");

            //////-------------------------------------------------------------

            //////Grading System
            //Console.Write("Enter student score: ");
            //int score = int.Parse(Console.ReadLine());
            //char grade;

            //if (score >= 90)
            // grade = 'A';            
            //else if (score >= 80)
            //    grade = 'B';
            //else if (score >= 70)
            //    grade = 'C';
            //else if (score >= 60)
            //    grade = 'D';
            //else
            //    grade = 'F';






            //Console.WriteLine("The student's grade is: " + grade);
            //Console.WriteLine("-------------------------------------------------");

            //////-------------------------------------------------------

            //////Swap Two Numbers
            //Console.Write("Enter first number: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int b = int.Parse(Console.ReadLine());

            //int c;

            //c = a;
            //a = b;
            //b = c;

            //Console.WriteLine("After swapping: First Number = " + a + ", Second Number = " + b);
            //Console.WriteLine("-------------------------------------------------");


            //////------------------------------------------------------------

            //////Days to Weeks and Days Converter
            //Console.Write("Enter number of days: ");
            //int days = int.Parse(Console.ReadLine());

            //int weeks = days / 7;
            //int remainingDays = days % 7;

            //Console.WriteLine( days + " days = " + weeks + " week(s) and " + remainingDays + " day(s)");
            //Console.WriteLine("-------------------------------------------------");

            //////-----------------------------------------------------------

            //////Simple Calculator
            //Console.Write("Enter first number: ");
            //double FirstNumber = double.Parse(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //Console.Write("Enter second number: ");
            //double SecondNumber = double.Parse(Console.ReadLine());

            //double result = 0;

            //if (op == '+')
            //    result = FirstNumber + SecondNumber;
            //else if (op == '-')
            //    result = FirstNumber - SecondNumber;
            //else if (op == '*')
            //    result = FirstNumber * SecondNumber;
            //else if (op == '/')
            //{
            //    if (SecondNumber != 0)
            //        result = FirstNumber / SecondNumber;
            //    else
            //    {
            //        Console.WriteLine("Cannot divide by zero!");
            //        return;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator!");
            //    return;
            //}

            //Console.WriteLine("Result: " + result );
            //Console.WriteLine("-------------------------------------------------");

            ////-----------------------------------------------

            //Console.WriteLine("Enter your grade :");
            //char Grade = Console.ReadKey().KeyChar;


            //if (Grade == 'A')
            //    Console.WriteLine("Excellent");
            //else if(Grade == 'B')
            //    Console.WriteLine("Good");
            //else if(Grade == 'C')
            //    Console.WriteLine("avg");
            //else
            //    Console.WriteLine("fail");


            //switch(grade)
            //{

            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;

            //    case 'B':
            //        Console.WriteLine("good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("avg");
            //        break;

            //    default:
            //        Console.WriteLine("fail");
            //        break;

            //}

            //--------------------------------------------------


            //Console.WriteLine("enter a number ");
            //int n = int.Parse(Console.ReadLine());

            //int counter;

            //for (counter = 0; counter <= n; counter++)
            //{
            //    Console.WriteLine("Karim");

            //}


            //int num = 20;

            //while(num != 20)
            //{
            //    Console.WriteLine("guess a number again");
            //    num = int.Parse(Console.ReadLine());
            //}

            ////simple calculator 
            //            Console.Write("Enter first number: ");
            //            double num1 = double.Parse(Console.ReadLine());

            //            Console.Write("Enter an operator (+, -, *, /): ");
            //            int op = int.Parse(Console.ReadLine());

            //            Console.Write("Enter second number: ");
            //            double num2 = double.Parse(Console.ReadLine());
            //            switch (op)
            //            {
            //                case '+':
            //                    Console.WriteLine("Result: " + (num1 + num2));
            //                    break;
            //                case '-':
            //                    Console.WriteLine("Result: " + (num1 - num2));
            //                    break;
            //                case '*':
            //                    Console.WriteLine("Result: " + (num1 * num2));
            //                    break;
            //                case '/':
            //                    if (num2 != 0)
            //                        Console.WriteLine("Result: " + (num1 / num2));
            //                    else
            //                        Console.WriteLine("Error! Division by zero is not allowed.");
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid operator!");
            //                    break;

            //            }
            //            Console.ReadLine();
            //        }
            //    }
            //}

            //            double balance = 1000;  // Starting balance

            //            while (true)
            //            {
            //                // Display the menu
            //                Console.WriteLine("\nATM Menu:");
            //                Console.WriteLine("1. Withdraw Money");
            //                Console.WriteLine("2. Deposit Money");
            //                Console.WriteLine("3. Check Balance");
            //                Console.WriteLine("4. Exit");

            //                // Get user input
            //                Console.Write("Select an option (1/2/3/4): ");
            //                int choice = int.Parse(Console.ReadLine());

            //                // Process based on the selected option
            //                switch (choice)
            //                {
            //                    case 1:
            //                        // Withdraw Money
            //                        Console.Write("Enter amount to withdraw: ");
            //                        double withdrawAmount = double.Parse(Console.ReadLine());
            //                        if (withdrawAmount <= balance)
            //                        {
            //                            balance -= withdrawAmount;
            //                            Console.WriteLine($"${withdrawAmount} withdrawn successfully. New balance: {balance}");
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Insufficient funds!");
            //                        }
            //                        break;

            //                    case 2:
            //                        // Deposit Money
            //                        Console.Write("Enter amount to deposit: ");
            //                        double depositAmount = double.Parse(Console.ReadLine());
            //                        balance += depositAmount;
            //                        Console.WriteLine($"${depositAmount} deposited successfully. New balance: {balance}");
            //                        break;

            //                    case 3:
            //                        // Check Balance
            //                        Console.WriteLine($"Your current balance is: {balance}");
            //                        break;

            //                    case 4:
            //                        // Exit
            //                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
            //                        return;

            //                    default:
            //                        Console.WriteLine("Invalid choice. Please try again.");
            //                        break;
            //                }
            //            }
            //        }
            //    }
            //}
            // geometry calculator 
            // Display the menu

            //            Console.WriteLine("Geometry Calculator");
            //            Console.WriteLine("Choose a shape:");
            //            Console.WriteLine("1. Circle (Calculate Area & Circumference)");
            //            Console.WriteLine("2. Square (Calculate Area & Perimeter)");
            //            Console.WriteLine("3. Triangle (Calculate Area)");
            //            // Get user input
            //            Console.Write("Select an option (1/2/3): ");
            //            int choice = int.Parse(Console.ReadLine());
            //            switch (choice)
            //            {
            //                case 1:

            //                    double radius = double.Parse(Console.ReadLine());
            //                    double areacircle = Math.PI * radius * radius;
            //                    double circumference = 2 * Math.PI * radius;
            //                    break;
            //                case 2:
            //                    // Square calculations
            //                    Console.Write("Enter the side length of the square: ");
            //                    double side = double.Parse(Console.ReadLine());
            //                    double areaSquare = side * side;
            //                    double perimeterSquare = 4 * side;
            //                    Console.WriteLine($"Area of Square:" + areaSquare);
            //                    Console.WriteLine($"Perimeter of Square" + perimeterSquare);
            //                    break;
            //                case 3:
            //                    Console.Write(" enter the base : ");
            //                    double Base = double.Parse(Console.ReadLine());
            //                    Console.Write(" enter the height : ");
            //                    double height = double.Parse(Console.ReadLine());
            //                    double areatriangle = 0.5 * height * Base;
            //                    Console.WriteLine(" enter the height of a triangle: " + height );
            //                    Console.WriteLine("enter the base of a triangle :" + Base );
            //                    Console.WriteLine("Area of triangle "  + areatriangle);

            //                    break;

            //                default:
            //                    Console.WriteLine("Invalid choice. Please try again.");
            //                    break;



            //            }
            //        }
            //    }
            //}
            ///diamond shape 
            //            int n; // Change this for a bigger/smaller diamond
            //            Console.WriteLine("enter N :"); 
            //            n =int.Parse(Console.ReadLine());

            //            for (int i = -n + 1; i < n; i++)
            //            {
            //                Console.Write(new string(' ', Math.Abs(i)));
            //                Console.WriteLine(new string('*', (2 * (n - Math.Abs(i))) - 1));
            //            }
            //        }
            //    }
            //}

            //            Console.Write("Enter a number: ");
            //            int n = int.Parse(Console.ReadLine());

            //            long factorial = 1;
            //            for (int i = 1; i <= n; i++)
            //            {
            //                factorial *= i;
            //            }

            //            Console.WriteLine($"Factorial of {n} is {factorial}");
            //        }
            //    }
            //}



            //            Console.Write("Enter a number (N): ");
            //            int n = int.Parse(Console.ReadLine());

            //            int sumEven = 0, sumOdd = 0;

            //            for (int i = 1; i <= n; i++)
            //            {
            //                if (i % 2 == 0)  // Check if even
            //                {
            //                    sumEven += i;
            //                }
            //                else             // Else, it's odd
            //                    sumOdd += i;
            //            }

            //            Console.WriteLine($"Sum of even numbers:" + sumEven);
            //            Console.WriteLine($"Sum of odd numbers:" + sumOdd);
            //        }
            //    }
            //}

//            Console.WriteLine("Scientific Calculator");
//            Console.WriteLine("Choose an operation: sin, cos, tan, sqrt, log, pow");
//            string operation = Console.ReadLine().ToLower();

//            double num1, num2, result = 0;

//            switch (operation)
//            {
//                case "sin":
//                    Console.Write("Enter angle in degrees: ");
//                    num1 = Convert.ToDouble(Console.ReadLine());
//                    result = Math.Sin(num1 * Math.PI / 180);
//                    break;

//                case "cos":
//                    Console.Write("Enter angle in degrees: ");
//                    num1 = Convert.ToDouble(Console.ReadLine());
//                    result = Math.Cos(num1 * Math.PI / 180);
//                    break;

//                case "tan":
//                    Console.Write("Enter angle in degrees: ");
//                    num1 = Convert.ToDouble(Console.ReadLine());
//                    result = Math.Tan(num1 * Math.PI / 180);
//                    break;

//                case "sqrt":
//                    Console.Write("Enter a number: ");
//                    num1 = Convert.ToDouble(Console.ReadLine());
//                    result = Math.Sqrt(num1);
//                    break;

//                case "log":
//                    Console.Write("Enter a number: ");
//                    num1 = Convert.ToDouble(Console.ReadLine());
//                    result = Math.Log(num1);
//                    break;

//                case "pow":
//                    Console.Write("Enter base: ");
//                    num1 = Convert.ToDouble(Console.ReadLine());
//                    Console.Write("Enter exponent: ");
//                    num2 = Convert.ToDouble(Console.ReadLine());
//                    result = Math.Pow(num1, num2);
//                    break;

//                default:
//                    Console.WriteLine("Invalid operation.");
//                    return;
//            }

//            Console.WriteLine("Result: " + result);
//        }
//    }
//}
