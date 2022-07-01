using System;
//Quiz7
//November 26, 2021
//Instruction: Rewrite the code to make it right
class HelloWorld {
  public static void Main() 
  {
          int int1, int2;
      Console.Write("\n\n");
      Console.Write("Check whether the integers are equal or not:\n");
      Console.Write("-------------------------------------");
      Console.Write("\n\n");
      Console.Write("Input First Integer: ");
      int1=Convert.ToInt32(Console.ReadLine());
      Console.Write("Input Second Integer: ");
      int2=Convert.ToInt32(Console.ReadLine());
      
      if (int1 == int2)
      {
      Console.WriteLine("{0} and {1} are equal. \n", int1, int2);
      }
      else
      {
      Console.WriteLine("{0} and {1} are not equal. \n", int1, int2);
      }
  }
}