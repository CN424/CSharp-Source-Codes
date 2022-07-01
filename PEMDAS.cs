using System;
class HelloWorld {
  static void Main() 
  {
      int Num1, Num2;
      Console.Write("Enter the First Number : ");
      Num1 = Convert.ToInt32(Console.ReadLine());
      
      Console.Write("Enter the Second Number: ");
      Num2 = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("The exponent {1} of {0} is: {2}", Num1, Num2, Math.Pow(Num1,Num2));
      Console.WriteLine("The product of {0} and {1} is: {2}", Num1, Num2, Num1 * Num2);
      Console.WriteLine("The quotient of {0} and {1} is    : {2}", Num1, Num2, Num1 / Num2);
      Console.WriteLine("The modulo of {0} and {1} is      : {2}", Num1, Num2, Num1 % Num2);
      Console.WriteLine("The sum of {0} and {1} is         : {2}", Num1, Num2, Num1 + Num2);
      Console.WriteLine("	The difference of {0} and {1} is: {2}", Num1, Num2, Num1 - Num2);
      Console.WriteLine("Press Enter to Exit... .");
      Console.ReadKey();
  }
}