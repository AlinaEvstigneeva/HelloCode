// Задача 22: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// int[] array =
// 5 -> 1, 4, 9, 16, 25. 2 -> 1,4

int num = int.Parse(Console.ReadLine());

int[] GetTableOfSquares(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = (int)Math.Pow(i + 1, 2);
    }
    return array;
}

int[] squaresTable = GetTableOfSquares(num);


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(squaresTable);