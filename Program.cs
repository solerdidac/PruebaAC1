internal class Program
{
    private static void Main(string[] args)
    {      
        double num1, num2, suma;

        Console.Write("Ingresa el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        suma = num1 + num2;

        Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
    }
}
