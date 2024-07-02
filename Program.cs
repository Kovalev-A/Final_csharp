
{
   
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        PrintNumbers(M, N);
    }

    static void PrintNumbers(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNumbers(start + 1, end);
        }
    }
}

 {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        long result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }

    static long Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, (int)Ackermann(m, n - 1));
        }
        else
        {
            throw new ArgumentException("Аргументы должны быть неотрицательными числами.");
        }
    }


        int[] array = { 1, 2, 3, 4, 5 };
        PrintArrayFromEnd(array, array.Length - 1);
    

    static void PrintArrayFromEnd(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayFromEnd(array, index - 1);
        }
    }
