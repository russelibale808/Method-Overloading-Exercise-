using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //My addition answer
            //var num1 = 5;
            //var num2 = 10;
            //Console.WriteLine(Add(num1, num2));

            // My decimal Answer
            //var num1 = 5.55m;
            //var num2 = 5.55m;
            //Console.WriteLine(Add(num1, num2));


            Console.WriteLine(Add(0,1, true));
        }

        //Method Adding with ints

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //Method adding with decimals
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        // Method that returns a string and accepts 3 parameters: 2 integers and 1 boolean

        public static string Add(int num1, int num2, bool check)
        {
            int addition = num1 + num2;

            if (check == true && addition > 5)
            {   
                return $"{addition} dollars";
            }

            else if(check == true && addition == 1)
            {
                return $"{addition} dollar";
            }

            else if(check == false && addition < 0)
            {
                return $"{addition} dollars.";
            }

            else
            {
                return addition.ToString();
            }


        }

    }
}
