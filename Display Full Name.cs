/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter your First Name: ");
    string fname = Console.ReadLine( );
    Console.WriteLine("Enter your Middle Name: ");
    string mname = Console.ReadLine( );
    Console.WriteLine("Enter your Last Name: ");
    string lname = Console.ReadLine( );
    Console.WriteLine("{0} {1} {2}", fname, mname, lname);
    
    Console.ReadKey();
  }
}