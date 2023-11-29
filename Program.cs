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
            var userMathematicalOperation = Console.ReadLine();
            double firstNumber;
            double secondNumber;
            try
            {
               firstNumber = Convert.ToDouble(userFirstNumber);
               secondNumber = Convert.ToDouble(userSecondNumber);

            }catch(Exception error)
            {
                Console.WriteLine(error.Message);
                return;
            }

            
            if(userMathematicalOperation == "+" || userMathematicalOperation == "-" || userMathematicalOperation == "*" || userMathematicalOperation == "/")
            {
                double result;
                if (userMathematicalOperation == "+")
                {
                    result = add(firstNumber, secondNumber);
                }
                else if (userMathematicalOperation == "-")
                {
                    result = subtract(firstNumber, secondNumber);
                }
                else if (userMathematicalOperation == "*")
                {
                    result = multiply(firstNumber, secondNumber);
                }
                else 
                {
                    result = divide(firstNumber, secondNumber);
                }
                Console.WriteLine("Result is " + result);
                return;
            }
            Console.WriteLine("I dont know this mathematical operation");
            return;
         
        }
        
        


    }

    


}




