using System;

class Program
{
    static void Main()
    {
        // Definir los catetos del triángulo
        double catetoA = 3.0;
        double catetoB = 4.0;

        // Calcular la hipotenusa utilizando el teorema de Pitágoras
        double hipotenusa = CalcularHipotenusa(catetoA, catetoB);

        // Mostrar el resultado
        Console.WriteLine("La hipotenusa es: " + hipotenusa);
    }

    static double CalcularHipotenusa(double a, double b)
    {
        // Usar la función Math.Sqrt para calcular la raíz cuadrada
        return Math.Sqrt(a * a + b * b);
    }
}