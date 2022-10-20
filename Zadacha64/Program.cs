// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа кратные 3-м в промежутке от N до 1.
    // N = 5 -> "5, 4, 3, 2, 1"
    // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
   
    int n = InputNumbers("Введите N: ");
    int count = 2;
    PrintNumber(n, count);
   
    void PrintNumber(int n, int count)
    {
        if (count > n) return;
        PrintNumber(n, count + 1);
        if (count % 3 == 0)
        {
            Console.Write(count + ", ");
        }
    }
    int InputNumbers(string input)
    {
        Console.Write(input);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }
