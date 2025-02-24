using System;

class SISD
{
    public static void Procesar()
    {
        int[] datos = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < datos.Length; i++)
        {
            datos[i] *= 2; 
        }
        
        Console.WriteLine("SISD: " + string.Join(", ", datos));
    }
}
