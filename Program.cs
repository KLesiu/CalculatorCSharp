namespace Main
{
   public class Calculator
    {
        static void Main(string[] args)
        {
            
            static double add(double firstNumber, double secondNumber)
            {
                return firstNumber + secondNumber;

            }
            static double subtract(double firstNumber, double secondNumber)
            {
                return firstNumber - secondNumber;
            }
            static double multiply(double firstNumber, double secondNumber)
            {
                return firstNumber * secondNumber;
            }
            static double divide(double firstNumber, double secondNumber)
            {
                return firstNumber / secondNumber;
            }

            Console.WriteLine("Type first number");
            var userFirstNumber = Console.ReadLine();
            Console.WriteLine("Type second number");
            var userSecondNumber = Console.ReadLine();
            Console.WriteLine("Type mathematic operation");
            var userMathematicOperation = Console.ReadLine();

            double firstNumber = Convert.ToDouble(userFirstNumber);
            double secondNumber = Convert.ToDouble(userSecondNumber);

            double result;
            if(userMathematicOperation == "+")
            {
                result = add(firstNumber, secondNumber);
            }
            else if(userMathematicOperation == "-")
            {
                result = subtract(firstNumber, secondNumber);
            }
            else if (userMathematicOperation == "*")
            {
                result = multiply(firstNumber, secondNumber);
            }
            else
            {
                result = divide(firstNumber, secondNumber);
            }
            Console.WriteLine(result);
            

            
        }
        
        


    }

    


}




