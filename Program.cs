using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int n = int.Parse(Console.ReadLine());

        int count = m * n;
        if (count % 2 != 0)
        {
            count--;
        }

        int[] array = new int[count];
        Random random = new Random();


        for (int i = 0; i < count; i++)
        {
            array[i] = random.Next(100);
        }


        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", array[i * n + j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        int iterations = count / 2;
        for (int i = 0; i < iterations; i++)
        {

            int index1 = random.Next(count);
            int index2 = random.Next(count);
            while (index2 == index1)
            {
                index2 = random.Next(count);
            }


            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }


        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", array[i * n + j]);
            }
            Console.WriteLine();
        }
    }
}
