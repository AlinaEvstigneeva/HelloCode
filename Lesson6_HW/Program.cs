/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


/* int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
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

int [] GetArray(int arrayLenght )
{
    int[] array = new int[arrayLenght];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumber($"Enter the number: ");
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


int CountTheNumberOfDigits(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            count ++;
        }
        
    }
    return count;
}


int arrayLenght = GetNumber("Введите длину массива: ");
int [] array = GetArray(arrayLenght);
PrintArray(array);
int result = CountTheNumberOfDigits(array);
Console.WriteLine($"Количество чисел больше нуля равно {result}"); */








/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int GetNumber(string message)

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

int b1 = GetNumber("Введите значение b1: ");
int k1 = GetNumber("Введите значение k1: ");
int b2 = GetNumber("Введите значение b2: ");
int k2 = GetNumber("Введите значение k2: ");



