using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));
            string resultAdd = Add(1, 2, false);
            Console.WriteLine(resultAdd);

            // OR
            Console.WriteLine(Add(3, 5, true));
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;  
        }

        static decimal Add(decimal decimal1, decimal decimal2) 
        { 
            return decimal1 + decimal2;
        }

        public static string Add(int num1, int num2, bool trueFalse)
        {
            if (trueFalse == true)
            {
                string result = (num1 + num2).ToString();

                if (result == "1")
                {
                    string message = $"{result} dollar";
                    return message;

                }
                else
                {
                    string messageTwo = $"{result} dollars";
                    return messageTwo;
                }
            }
            else
            {
                string messageThree = (num1 + num2).ToString();

                return messageThree;
            }
        }
    }
}
