// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [- 9, 9]. 
// Найдите сумму отрицательных и положительных эелементов массива.
// Например, в массиве [3, 9, -8, 1,0, -7,2-1,8,-3, -1,6] сумма положительный чисел равна 29, сумма отрицательных равна -20.


int [] array = GetArray(-9, 9, 12);
int positiveSum = GetSumPositiveNumbers(array);
int negativeSum = GetSumNegativeNumbers(array);
PrintArray(array);


int [] GetArray (int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int GetSumPositiveNumbers(int[] array)
{
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            sumPositive += array[i];
        }
    }
    return sumPositive;
}


int GetSumNegativeNumbers(int[] array)
{
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegative += array[i];
        }
    }
    return sumNegative;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    string message = string.Join(",", array);          // метод который позволяет печатать буквы и цифры в одной строке.
    Console.WriteLine(message);                        // заводим под него отдельную перпеменную message.
}


Console.WriteLine($"Сумма положительный чисел равна {positiveSum}, сумма отрицательных равна {negativeSum}");
