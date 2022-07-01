/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
public class Exercise10
{
  public static void Main()
  {
    int number1, number2, number3;
     //insert first number
    Console.Write("Enter first number:");
    number1 = Convert.ToInt32(Console.ReadLine());
     //insert second number
    Console.Write("Enter second number:");
    number2 = Convert.ToInt32(Console.ReadLine());
     //insert third number
    Console.Write("Enter third number:");
    number3 = Convert.ToInt32(Console.ReadLine());
     //print output for the given equation
    Console.Write("Result of specified numbers {0}, {1} and {2}, (a+b)/c is {3} and (a·b) + (b·c) is {4}\n\n",
        number1, number2, number3, ((number1+number2)/number3), (number1*number2+number2*number3));
  }
}