using System.Diagnostics.CodeAnalysis;

// Calcular la siguiente suma serie exponencial

internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;
        double x = 0, exp = 0;
        Console.WriteLine("Ingrese el valor de x para calcular exp(x): ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el número de repeticiones de la serie: ");
        num = Convert.ToInt32(Console.ReadLine());
        exp = exponencial(x, num);
        Console.WriteLine("Exponencial: " + exp);
    }

    private static double factorial(int n)
    {
        double resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;      
        }
        return resultado;
    }

    private static double exponencial(double x, int n)
    {
        double sum = 1.00;
        for(int i = 0; i <= n; i++)
        {
            if (x == 0.5)
            {
                sum = 1 + Math.Exp(x);
            }
            else
            {
                sum += ((Math.Pow(x,i)) / (factorial(i)));
            }
        }
        return sum - 1.00;
    }
}