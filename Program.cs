using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Transactions;

namespace IntroPgm
{
    class Program
    {
        static void Main(string[] args)
        {
          //Console.WriteLine("Hello World!");
          //Console.ReadKey();
          Debug.WriteLine("Hello World!");

            //Adding 2 numbers

            //int x, y;

            //x = 2;
            //y = 3;
            //int sum = x + y;
            //Debug.WriteLine(" x + y = " + sum);

            //obtaining user input

            //Console.WriteLine("Please provide your input");
            //string userInput = Console.ReadLine();
            //Debug.WriteLine("You entered - " + userInput);

            //parsing Data types
            //int inputNumber=0;
            //try
            //{
            //    inputNumber = Convert.ToInt32(userInput);
            //}
            //catch (Exception e)
            //{
            //    Debug.WriteLine(e.Message);
            //}
            //Debug.WriteLine(" Input Number = " + inputNumber);
            //Debug.WriteLine(" User Input = " + userInput);
            //inputNumber = inputNumber + 3;
            //Debug.WriteLine(" Input Number + User Input = " + inputNumber);

            ////Example simple computation - double vs decimal
            //decimal income = 10000000.45M;
            //decimal taxRate = 0.1M;
            //decimal taxLiability = income * taxRate;
            //Debug.WriteLine("The Tax Liability is : " + taxLiability);

            ////Example 2
            //double rate = 0.06;
            //double doublingTime = Math.Log(2) / Math.Log(1+rate);
            //Debug.WriteLine("Doubling time is nearly "+ Convert.ToInt32(doublingTime) + " Years");

            ////Example 3 - selection
            //decimal income = 10000000.45M;
            //decimal taxRate = 0.1M;
            //decimal taxLiability;

            //if (income < 400000)
            //{
            //    taxLiability = 0;
            //}
            //else
            //{
            //    taxRate = 0.5M;
            //    taxLiability = taxRate * income;
            //}

            //Debug.WriteLine("Tax liability is "+ taxLiability);

            //// Example - Loops
            //decimal income;
            //decimal taxRate;
            //decimal taxLiability=0M;
            //bool stopProgram = false;

            //while (stopProgram == false)
            //{
            //    Console.Write("Please enter the income : ");
            //    income = Convert.ToDecimal(Console.ReadLine());

            //if (income > 400000)
            //{
            //    taxRate = 0.05M;
            //    taxLiability = income * taxRate;
            //}
            //else if (income >= 0)
            //{
            //    taxLiability = 0M;
            //}
            //else
            //{
            //    stopProgram = true;
            //}

            //    Console.WriteLine("Tax liabiity is " + taxLiability);
            //}

            //// Example - Methods
            decimal income = 0M;
            decimal taxLiability=0;
            bool isNumber = false;
            while (isNumber == false)
            {
                try
                {
                    Console.WriteLine(" Please enter your income : " );
                    income = Convert.ToDecimal(Console.ReadLine());
                    taxLiability = ComputeTaxes(income);
                    isNumber = true;
                }
            catch (Exception)
                {
                    Console.WriteLine("The entered value is not a number. Please enter a Number!");
                    isNumber = false;
                }
                
            }
            Console.WriteLine("Tax liability is : " + taxLiability);

        }
        static decimal ComputeTaxes(decimal argIncome)
        {
            decimal taxLiability = 0;
            decimal taxRate;
            if (argIncome > 400000)
            {
                taxRate = 0.05M;
                taxLiability = argIncome * taxRate;
            }
            else if (argIncome <= 400000)
            {
                taxLiability = 0;
            }

            return taxLiability;

        }
    }
}
