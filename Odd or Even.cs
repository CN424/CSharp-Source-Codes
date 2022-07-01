using System; 
//Quiz7
//November 26, 2021
//Instruction: Evaluate the program and write the output in the 
//space provided for
public class helloworld  
{  
    public static void Main()  
    {
        int num1, rem1;
        Console.Write("\n\n");
        Console.Write("Check whether a number is even or odd:\n");
        Console.Write("---------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input the Number: ");
        num1 = Convert.ToInt32(Console.ReadLine()); 
        rem1 = num1 % 2;
        if (rem1 == 0)
        {
            Console.WriteLine("{0} is an even number\n", num1);
        }
        else
        {
            Console.WriteLine("{0} is an odd number\n", num1);
        }
    }
}