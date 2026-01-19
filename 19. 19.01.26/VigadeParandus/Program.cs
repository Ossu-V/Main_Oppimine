
namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vigade parandus");

            Console.WriteLine("Vajuta numbrit");
            Console.WriteLine("1. Upside down Pyramid");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Pyramid");

            string input = Console.ReadLine();

            switch (input)
            {
                //meetodi välja kutsumine
                case "1":
                    UpsidedownPyramid();
                    break;

                case "2":
                    Rectangle();
                    break;

                case "3":
                    Pyramid();
                    break;  

                default:
                    Console.WriteLine("Sellist valikut ei ole");
                    break;
            }
        }
        static void UpsidedownPyramid()
        {
            Console.WriteLine("Sisesta kõrgus");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = n - 0; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        static void Rectangle()
        {
            Console.WriteLine("Sisesta pikkus");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta pikkus");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
            }

            int area = row * width;
            int around = 2 * (row + width);

            Console.WriteLine("Pindala on " + area);
            Console.WriteLine("Ümbermõõt on " + around);
        }
        static void Pyramid()
        {
            Console.WriteLine("");
            Console.WriteLine("Sisesta püramiidi kõrgus: ");

            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
