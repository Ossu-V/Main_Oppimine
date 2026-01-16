namespace Kontrolltöö2Ül
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali milline meetod välja kutsuda, valikus on: ");
            Console.WriteLine("Püramiidi kõrgus");
            Console.WriteLine("Ruut");
            Console.WriteLine("Ruutvõrrand");
            Console.WriteLine(" ");

            string math = Console.ReadLine();

            switch (math)
            {
                case "Püramiidi kõrgus":
                    PüramiidiKõrgus();
                    break;

                case "Ruut":
                    Ruut();
                    break;

                case "Ruutvõrrand":
                    Ruutvõrrand();
                    break;
            }
        }
        static void PüramiidiKõrgus()
        {
            Console.WriteLine("Sisesta Püramiidi kõrgus: ");

            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

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
                Console.WriteLine(" ");
            }
        }
        static void Ruut()
        {
            Console.WriteLine("Sisesta ruudu suurus:");
            //teha for loopiga ruut
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                for (global::System.Int32 j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int area = size * size;
            int around = 4 * size;

            Console.WriteLine("Ruudu pindala on: " + area);
            Console.WriteLine("Ruudu ümbermõõt on: " + around);
        }
        static void Ruutvõrrand()
        {
            Console.WriteLine("Ruutvõrrand!");

            Console.Write("Sisesta a väärtus: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta p väärtus: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Sisesta q väärtus: ");
            double q = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            double y = a * (2 - p) * 2 + q;

            Console.WriteLine($"x1 = {a * (2 - p) * (2 + q)}, x2 = {a * (2 - p) * (2 + q)}");
        }
    }
}
