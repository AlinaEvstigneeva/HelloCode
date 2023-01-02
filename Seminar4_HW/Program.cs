// Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. 
// Не использовать Math.Pow()

// Console.WriteLine("Введите первое число: ");

// int number1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число");

// int number2 = int.Parse(Console.ReadLine());

// int RaiseToPowerOfNumber( int number1, int number2)
// {
//     int result = 1;
//     for( int i = 0; i < number2; i++)
//     {
//        result = result * number1;
//     }
//     return result;
// }

// int product = RaiseToPowerOfNumber(number1, number2);
// Console.WriteLine(product);






// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");

// int num = int.Parse(Console.ReadLine());

// int FindSumOfDigits(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return sum;
// }

// int result = FindSumOfDigits(num);
// Console.WriteLine(result);






// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите желаемое количество элементов массива: ");
int size = int.Parse(Console.ReadLine());


int [] GetArray( int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите значеиние: ");
        array[i] = int.Parse(Console.ReadLine());
        
    }
    return array;
}

int [] resultArray = GetArray(size);


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(resultArray);