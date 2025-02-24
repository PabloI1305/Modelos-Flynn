using System;
using System.Numerics;

class SIMD
{
    public static void Procesar()
    {
        int[] datos = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int tamañoVector = Vector<int>.Count; 
        
        for (int i = 0; i <= datos.Length - tamañoVector; i += tamañoVector)
        {
            Vector<int> vectorDatos = new Vector<int>(datos, i);
            Vector<int> resultado = vectorDatos * 2;
            resultado.CopyTo(datos, i);
        }

        Console.WriteLine("SIMD: " + string.Join(", ", datos));
    }
}
