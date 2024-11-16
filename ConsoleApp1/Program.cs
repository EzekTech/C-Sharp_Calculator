//Console.WriteLine("Welcome to my Calculator app");

internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Input first number and press Enter or press Enter to exit: ");
            string num1 = Console.ReadLine();
            int numConvert1 = Convert.ToInt32(num1);

            Console.WriteLine("Input second number and press Enter or press Enter to exit: ");
            string num2 = Console.ReadLine();
            int numConvert2 = Convert.ToInt32(num2);

            Console.WriteLine("Input Operator");
            string sign = Console.ReadLine();

            if (sign == "+")
            {
                Console.WriteLine(numConvert1 + numConvert2);
            }
            else if (sign == "/")
            {
                Console.WriteLine(numConvert1 / numConvert2);

            }
            else if (sign == "-")
            {
                Console.WriteLine(numConvert1 - numConvert2);

            }
            else if (sign == "*")
            {
                Console.WriteLine(numConvert1 * numConvert2);

            }
            else if (sign == "%")
            {
                Console.WriteLine(numConvert1 % numConvert2);

            }
            else if (sign == "")
            {
                Console.WriteLine("No operator imputed");

            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
            Console.WriteLine("Press 'y' and press enter to perform another operation");
            Console.WriteLine("Or press any other key and press enter twice to exit");
            Console.WriteLine("Or press Enter three times to exit");

      

        }

        while (Console.ReadLine() == "y" );

    }
}