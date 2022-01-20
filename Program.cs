using System;

namespace basiclearning
{
    abstract class Abstract {
        public abstract void Addition(double a, double b); 
        public abstract void Subtraction(double a, double b);
        public abstract void Multiplication(double a, double b);
        public abstract void Division(double a, double b);
    }


    class Calculator: Abstract {
        public  override void Addition(double a, double b){ double result = a+b; Console.WriteLine(result); }
        public  override void Subtraction(double a, double b){double result = a-b; Console.WriteLine(result); }
        public  override void Multiplication(double a, double b){double result = a*b; Console.WriteLine(result); }
        public  override void Division(double a, double b){double result = a/b; Console.WriteLine(result); }
    }

 class Program
{

    static void Main(String[] args){
            Console.WriteLine("Enter First number: ");

            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter Second number: ");

            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your choice\n");
            Console.WriteLine("Enter 1 for Subtraction\n");
            Console.WriteLine("Enter 2 for Addition\n");
            Console.WriteLine("Enter 3 for Multiplication\n");
            Console.WriteLine("Enter 4 for Division\n");

            int choice = Convert.ToInt32(Console.ReadLine());

            Calculator calculations =new Calculator();
            switch (choice)
            {
                case 1:
                {
                        calculations.Addition( number1,  number2);
                        break;

                    }
                  
                     case 2:
                    
                      {
                        calculations.Subtraction( number1,  number2);
                        break;

                    }
                     case 3:
                    {
                        calculations.Multiplication( number1,  number2);
                        break;

                    }
                     case 4:
                    {
                        calculations.Division( number1,  number2);
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Enter a valid input");
                        break;
                    }
             }

    }

}
}