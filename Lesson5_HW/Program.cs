/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

/* int[] GetArray()
{
    int[] array = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 300);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int FindEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count = count + 1;
    }

    return count;
}

int [] initialArray = GetArray();
PrintArray(initialArray);
int result = FindEvenNumbers(initialArray);

Console.WriteLine($"Количество четных чисел в массиве равно {result}"); */









/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


/* int[] GetArray()
{
    int[] array = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-99, 99);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int FindOddPosition(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
            sum = sum + array[i];
    }

    return sum;
}

int [] initialArray = GetArray();
PrintArray(initialArray);
int result = FindOddPosition(initialArray);

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {result}"); */







/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


int[] GetArray()
{
    int[] array = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 99);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int FindMaxNumber(int[] array)
{
    int maxNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxNumber)
            maxNumber = array[i];
    }

    return maxNumber;
}

int FindMinNumber(int[] array)
{
    int minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < minNumber)
            minNumber = array[i];
    }

    return minNumber;
}


int [] initialArray = GetArray();
PrintArray(initialArray);
int max = FindMaxNumber(initialArray);
int min = FindMinNumber(initialArray);

Console.WriteLine($"Максимальное число {max}, минимальное число {min}. Разница равна {max - min}");

