/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20 */

/* int[] InitArray()
{
    int[] result = new int[12];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-9,10);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetPositiveSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            sum += array[i];
    }

    return sum;
}

int GetNegativeSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }

    return sum;
}

Amounts GetAmounts(int[] array)
{
    Amounts item = new Amounts();

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            item.Negative += array[i];
        else
            item.Positive += array[i];
    }

    return item;
}

(int, int) GetSumms(int [] array)
{
    int negative = 0;
    int positive = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            negative += array[i];
        else
            positive += array[i];
    }

    return (negative, positive);
}



int[] arr = InitArray();
PrintArray(arr);
int posSum = GetPositiveSum(arr);
int negSum = GetNegativeSum(arr);

Amounts item = GetAmounts(arr);

(int negative, int positive) = GetSumms(arr);

Console.WriteLine($"Сумма положительных элементов = {posSum}, отрицательных = {negSum}");
Console.WriteLine($"Сумма положительных элементов = {item.Positive}, отрицательных = {item.Negative}");
Console.WriteLine($"Сумма положительных элементов = {positive}, отрицательных = { negative}");




class Amounts
{
    internal int Negative{get;set;}
    internal int Positive {get;set;}
} */








/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

/* int [] GetArray()
{
    int[] array = new int[12];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }

    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void ChangeArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = array[i] * -1;
    }
}

int[] array = GetArray();
PrintArray(array);


ChangeArray (array);
PrintArray(array); */







/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */


/* int [] GetArray()
{
    int[] array = new int[12];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }

    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

void SearchNumber(int [] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            Console.WriteLine("Yes");
            return;                                         // break - выход из цикла
        }                                                   // return - выход из функции
        
    }
    Console.WriteLine("No");
}





int[] array = GetArray();
int number = GetNumber("Enter the number: ");
PrintArray(array);

SearchNumber(array, number); */






/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */


/* int [] GetArray()
{
    int[] array = new int[12];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100,300);
    }

    return array;
}


void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int GetCount(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>=10 && arr[i]<=99)
            count++;
    }
    return count;
}


int[] array = GetArray();
Console.WriteLine(string.Join(',', array));
int count = GetCount(array);

Console.WriteLine($"кол-во элементов в диапазоне [10, 99] = {count}"); */







/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */


int[] GetArray()
{
    int[] array = new int[12];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-4, 5);
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


int [] GetResultArray(int[] array)
{
    int[] result;
    if (array.Length % 2 == 0)
    {
        result = new int[array.Length / 2];
    }
    else
    {
        result = new int[array.Length / 2 + 1];
    }

    for (int i = 0; i < array.Length/2; i++)
    {
        result[i] = array [i] * array [array.Length - i - 1];
    }

    if (array.Length % 2 != 0)
    {
        result[result.Length-1] = array [array.Length/2];
    }
    return result;
}


int [] array = GetArray();
PrintArray(array);
int [] resultArray = GetResultArray(array);
PrintArray(resultArray);
