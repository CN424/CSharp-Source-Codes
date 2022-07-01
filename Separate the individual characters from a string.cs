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
      //Separate the individual characted from the string
      string str; 
            int l=0;
	
      Console.Write("\n\nSeparate the individual characters from a string :\n");
      Console.Write("Input the string : ");
      str = Console.ReadLine();
	  Console.Write("The characters of the string are  :  ");
            while (l <= str.Length - 1)
            {
                Console.Write("{0} ", str[l]);
                l++;
            }
                Console.Write("\n\n");
  }
}