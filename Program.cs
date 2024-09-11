using System;
using System.Security.Cryptography.X509Certificates;






//Mi MAIN

public class Programa
{
    public static void Main()
    {
        // Creando matriz
        Shape[] shapes = new Shape[]
        {
            new Rectangle(6, 12),
            new Triangle(6, 12),
            new Circle(7)
        };

        //Areas calculadas
        double[] areas = new double[shapes.Length];



        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurface();
        }

        //Mostrar datos

        for (int i = 0; i < areas.Length; i++)
        {
            Console.WriteLine($"El área de la forma {i + 1} es: {areas[i]:F2}");
        }
    }
}