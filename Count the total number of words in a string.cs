/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;  
public class Exercise5
{  
    public static void Main() 
{
    string str;
    int i, wrd,l;
	
      Console.Write("\n\nCount the total number of words in a string :\n");
      Console.Write("Input the string : ");
      str = Console.ReadLine();
	
    l = 0;
    wrd = 1;

    /* loop till end of string */
    while (l <= str.Length - 1)
    {
        /* check whether the current character is white space or new line or tab character*/
        if(str[l]==' ' || str[l]=='\n' || str[l]=='\t')
        {
            wrd++;
        }

        l++;
    }

   Console.Write("Total number of words in the string is : {0}\n", wrd);
	}
}
