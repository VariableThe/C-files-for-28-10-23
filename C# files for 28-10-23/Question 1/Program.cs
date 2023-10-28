// See https://aka.ms/new-console-template for more information
namespace Aditya
{
    class program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Enter the first element of the array:  ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second element of the array:  ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third element of the array:  ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the fourth element of the array:  ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            int[] nums = { num1, num2, num3, num4 };

            if (num1 == num2)
            {
                Console.WriteLine("Your array has numbers that repeat, they are: " + num1 + " and " + num2);
            }
            else if (num1 == num3)
            {
                Console.WriteLine("Your array has numbers that repeat, they are: " + num1 + " and " + num3);
            }
            else if (num1 == num4)
            {
                Console.WriteLine("Your array has numbers that repeat, they are: " + num1 + " and " + num4);
            }
            else if (num2 == num3)
            {
                Console.WriteLine("Your array has numbers that repeat, they are: " + num2 + " and " + num3);
            }
            else if (num2 == num4)
            {
                Console.WriteLine("Your array has numbers that repeat, they are: " + num2 + " and " + num4);
            }
            else if (num3 == num4)
            {
                Console.WriteLine("Your array has numbers that repeat, they are: " + num3 + " and " + num4);
            }
            else
            {
                Console.WriteLine("Your array has no repeating numbers");
            }

        }

    }


}

            
