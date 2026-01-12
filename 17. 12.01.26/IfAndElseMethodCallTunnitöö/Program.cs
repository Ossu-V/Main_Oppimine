using System.Threading.Channels;

namespace IfAndElseMethodCallTunnitöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saad valida enda meetodi, kui sesestad numbri");
            Console.WriteLine(" 1. ForLoopText");
            Console.WriteLine(" 2. WhileText");
            Console.WriteLine(" 3. NumberAddition");
            Console.WriteLine(" 4. Age");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ForLoopText();
            }

            else if (choice == "2")
            {
                WhileText();
            }

            else if (choice == "3")
            {
                NumberAddition();
            }

            else if (choice == "4")
            {
                Age();
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        static void ForLoopText()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Tere tulemast for loop!");
            }
        }

        static void WhileText()
        {
            int a = 1;
            while (a <= 3)
            {
                Console.WriteLine("Tere tulemast while loop!");

                Console.WriteLine();
                a++;
            }
        }

        static void NumberAddition()
        {

            Console.WriteLine("Liitmine");
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Sisesta esimene number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Vastus on: " + sum);

        }
        static void Age()
        {
            Console.WriteLine("Sisesta enda vanus");

            string number = Console.ReadLine();

            if (int.TryParse(number, out int numberConverted))
            {
                Console.WriteLine("Sisestasid enda vanuse: " + number);
            }
            else
            {
                Console.WriteLine("Ei sisestanud vanust");
            }
        }
    }
}   
