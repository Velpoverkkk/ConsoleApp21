using System;
class Program
{   //Для матрицы MxN вывести на экран все седловые точки 
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N, M, n = 0;
        System.Console.WriteLine("Razmer massiva NxM");
        N = System.Convert.ToInt32(Console.ReadLine());
        M = System.Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, M];
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                array[j, k] = rnd.Next(0, 10);
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }
        int[] min_str = new int[2];
        int[] max_str = new int[2];
        int[] min_stl = new int[2];
        int[] max_stl = new int[2];
        System.Console.WriteLine();
        for(int i = 0; i < N; i++)
        {
            min_str = search_min_str(array, i, N);
            max_stl = search_max_stl(array, min_str[1], M);
            max_str = search_max_str(array, i, N);
            min_stl = search_min_stl(array, max_str[1], M);
            if (min_str[0] == max_stl[0]) Console.WriteLine("ono " + min_str[0] + " " + min_str[1]);
            if (max_str[0] == min_stl[0]) Console.WriteLine("ono " + max_str[0] + " " + max_str[1]);
        }
       
    }
    static int[] search_min_str(int[,]a,int b,int c)
    {
        int[] min = new int[2];
        min[0] = a[b,0];
        for(int i = 0; i < c; i++)
        {
            if (min[0] > a[b, i]) 
            { 
                min[0] = a[b, i]; 
                min[1]=i;
            }
        }
        return min;
    }
    static int[] search_min_stl(int[,] a, int b, int c)
    {
        int[] min = new int[2];
        min[0] = a[0, b];
        for (int i = 0; i < c; i++)
        {
            if (min[0] > a[i, b])
            {
                min[0] = a[i, b];
                min[1] = i;
            }
        }
        return min;
    }
    static int[] search_max_str(int[,] a, int b, int c)
    {
        int[] max = new int[2];
        max[0] = a[b, 0];
        for (int i = 0; i < c; i++)
        {
            if (max[0] < a[b, i])
            {
                max[0] = a[b, i];
                max[1] = i;
            }
        }
        return max;
    }
    static int[] search_max_stl(int[,] a, int b, int c)
    {
        int[] min = new int[2];
        min[0] = a[0, b];
        for (int i = 0; i < c; i++)
        {
            if (min[0] < a[i, b])
            {
                min[0] = a[i, b];
                min[1] = i;
            }
        }
        return min;
    }

}
