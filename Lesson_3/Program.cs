﻿/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 

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

int x1 = GetNumber("Введите координату Х первой точки");
int y1 = GetNumber("Введите координату Y первой точки");

int x2 = GetNumber("Введите координату Х второй точки");
int y2 = GetNumber("Введите координату Y второй точки");

// // Корень((x1-x2)^2 + (y1-y2)^2)
// // Math.Sqrt()
// // Math.Pow(выражение, степень)

double GetDistance (int x1, int x2, int y1, int y2)
{
    double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));
    return result;
} 

System.Console.WriteLine(GetDistance(x1,x2,y1,y2)); */





/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */


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

int squares = GetNumber("Введите число ");

for (int i = 1; i <= Math.Abs(squares); i++)
{
    Console.Write($"{Math.Pow(i, 2)} ");
}





