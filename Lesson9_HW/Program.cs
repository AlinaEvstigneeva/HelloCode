/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


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

string GetNaturalNumbers(int number)
{
    if(number == 1 )
    return "1";
    return GetNaturalNumbers(number - 1)+" "+ number.ToString();
}

int number = GetNumber("Введите число ");
Console.WriteLine(GetNaturalNumbers(number)); */








/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


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

int GetSumOfNumbers(int numberM, int numberN)
{
    if(numberN == numberM )
    return numberN;
    else
    {
        return numberM + GetSumOfNumbers(numberM + 1, numberN);
    }
}


int numberM = GetNumber("Введите число ");
int numberN = GetNumber("Введите число ");
Console.WriteLine(GetSumOfNumbers(numberM, numberN)); */








/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */


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


int GetAckermanFunction(int numberM, int numberN)
{
if (numberM==0) return numberN+1;
if (numberN==0 && numberM>0 ) return GetAckermanFunction(numberM-1,1);
else return GetAckermanFunction(numberM-1,GetAckermanFunction(numberM,numberN-1));
}

int numberM = GetNumber("Введите число M: ");
int numberN = GetNumber("Введите число N: ");
Console.WriteLine($"Функция Аккермана равна {GetAckermanFunction(numberM, numberN)}");


/* ИЛЬЯ! Тысяча извинений (хотела вставить мемасик, но не умею пока), что не смогла поприсутствовать 
на наших последних увлекательных онлайн занятиях. Большое спасибо за курс и приятную атмосферу! Было интересно :) */