using System;
using System.Threading.Tasks;

class MIMD
{
    public static void Procesar()
    {
        int[] datos = { 1, 2, 3, 4, 5, 6, 7, 8 };

        Parallel.For(0, datos.Length, i =>
        {
            datos[i] = (i % 2 == 0) ? datos[i] * 2 : datos[i] * 3;
        });

        Console.WriteLine("MIMD: " + string.Join(", ", datos));
    }
}
