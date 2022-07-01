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
      string stdntN, iDnum ;
      double TNunit, TperU ;
      Console.Write("Student name: ");
      stdntN = Console.ReadLine();
      Console.Write("I.D number : ");
      iDnum = Console.ReadLine();
      Console.Write("Total number of units: ");
      TNunit = Convert.ToDouble(Console.ReadLine());
      Console.Write("Tuition per unit: ");
      TperU = Convert.ToDouble(Console.ReadLine());
      Console.Write("Tuition Fee: {0}", TNunit * TperU);
      Console.ReadKey();
  }
}