﻿namespace Zadanie_4._5___Dodawanie_macierzy;
public class SamplesArrayList  {

    public static void Main()
    {
        int[,] a = {{1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}};
        int[,] b = {{2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}};
        int[,] c = new int[10, 10];
        int i = 0;
        int j = 0;
        int d = 10;

        for (i = 0; i < d; i++)
        {
            for (j = 0; j < d; j++)
            {
                c[i,j] = a[i, j] + b[i, j];
                //Console.Write(c[i,j]);
            }
        }
        
        for (int k = 0; k < c.GetLength(0); k++)
        {
            for (int p = 0; p < c.GetLength(1); p++) {
                Console.Write("{0} ", c[k, p]);
            }
            Console.WriteLine();
        }
        
        
        
        
    }
    
}