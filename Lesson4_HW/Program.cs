/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = NumberRequest("Enter number: ");
int b = NumberRequest("Enter number: ");

int ExponentiateNumber(int a, int b)
{
    int degree = 1;
    for (int i = 1; i <= b; i++)
    {
        degree = a * degree;
    }
    return degree;
}

int result = ExponentiateNumber(a, b);

Console.WriteLine($"{a} to the power of {b} is equal to {result}"); */






/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/* int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Повторите ввод");
        }
    }

    return result;
}

int number = GetNumber("Enter the number: ");

int FindSumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

int result = FindSumOfDigits(number);
Console.WriteLine($"The sum of the digits in the {number} is {result}"); */







/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = new int[8];

void GetArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    Random rnd = new Random();
    while (index < length)
        {
            array[index] = rnd.Next(1, 99);
            index++;
        }
}

void PrintArray(int [] array)
{
    Console.Write(string.Join(',', array));
}

GetArray(array);
PrintArray(array); 
