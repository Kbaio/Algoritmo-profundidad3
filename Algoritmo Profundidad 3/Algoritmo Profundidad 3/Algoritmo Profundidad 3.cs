using System;

internal class Program
{
 
    //Hipotesis: Al ser un algoritmo de profundidad 3 con tantas iteraciones va a durar una increible cantidad de tiempo antes de terminar.

    //Luego de dejar el programa por unos 21 minutos logro realizar 90376820 iteraciones

    static void Main()
    {
        Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
        int num = 0;

        for (int i = 0; i < 10000; i++)
        {
            for (int j = 0; j < 10000; j++)
            {
                for (int k = 0; k < 10000; k++)
                {
                    num += 1;
                    Console.WriteLine("Iteracion numero: " + num);
                }

            }
        }
    }
}

