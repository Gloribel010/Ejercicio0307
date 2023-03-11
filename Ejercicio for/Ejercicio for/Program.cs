//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"


Console.WriteLine("Triangulo rectangulo");
class For
{
    static void Main(string[] args)
    {
        Console.Write("ingresar un numero entero");
        int altura = int.Parse(Console.ReadLine());

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
