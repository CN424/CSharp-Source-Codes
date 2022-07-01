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
      int A = 24, B = 9 ;
           
           bool result1 = (A == B);
           Console.WriteLine("Equal to Operator: " + result1);
           bool result2 = (A > B) ;
           Console.WriteLine("Greater than Operator: " + result2);
           bool result3 = (A < B) ;
           Console.WriteLine("Less than Operator: " + result3);
           bool result4 = (A >= B);
           Console.WriteLine("Greater than or Equal to Operator: " + result4);
           bool result5 = (A <= B) ;
           Console.WriteLine("Less than or Equal to Operator: " + result5);
           bool result6 = (A != B) ;
           Console.WriteLine("Not Equal to Operator: " + result6);
  }
}