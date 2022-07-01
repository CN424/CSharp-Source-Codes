/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() 
  {
      decimal sal;
      Console.WriteLine("Test Data");
      Console.Write("Employee's Name: ");
      string name = Console.ReadLine();
      Console.Write("Number of hours worked: ");
      int num = Convert.ToInt32(Console.ReadLine());
      Console.Write("Rate per hour: ");
      decimal rate = Convert.ToDecimal(Console.ReadLine());
      Console.Write("Deduction: ");
      decimal ded = Convert.ToDecimal(Console.ReadLine());
      sal = (num * rate);
      Console.WriteLine("Salary: " + sal);
  }
}