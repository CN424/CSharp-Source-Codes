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
      int x, y ;
         x = 12 ;
         y = 25 ;
         
         int result1 = x & y;
         Console.WriteLine("Bitwise AND: " + result1);
         
         int result2 = x | y;
         Console.WriteLine("Bitwise OR: " + result2);
          
         int result3 = x ^ y;
         Console.WriteLine("Bitwise XOR: " + result3);
         
         int result4a = ~ x ;
         int result4b = ~ y ;
         Console.WriteLine("Bitwise Complement: (x){0} , (y){1}", result4a, result4b);
         
         int result5 = x << y;
         Console.WriteLine("Bitwise  Left Shift: " + result5);
         
         int result6 = x << y;
         Console.WriteLine("Bitwise Right Shift: " + result6);
         
         Console.WriteLine("Press Enter Key to Exit... .");
  }
}