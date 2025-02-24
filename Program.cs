using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejecutando modelos de la Taxonomía de Flynn...\n");

        SISD.Procesar();
        SIMD.Procesar();
        MIMD.Procesar();
    }
}
