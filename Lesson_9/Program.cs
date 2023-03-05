/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

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

string GetNaturalNumbers(int number)    // метод с рекурсией
{
    if(number == 1 )    //в таком методе обязательно прописывается условие, которое закончит цикл
    return "1";     //если number = 1, то программа должна вернуть цифру 1.
    return GetNaturalNumbers(number - 1)+" "+ number.ToString();   //иначе, проваливаемся в рекурсию, 
                                                                //которая выполняет какие-то действия с заданным числом
                                                                //и возвращает значения этих действий, поэтому стоит слово return.
}

// number.ToString() - данная конструкция переводит int в string.

int number = GetNumber("Введите число ");
Console.WriteLine(GetNaturalNumbers(number)); */







/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */


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

string GetNaturalNumbers(int numberM, int numberN)
{
    if(numberN == numberM )
    return numberM.ToString();  //без разницы что возвращать M или N - они одинаковые по условию.
    return numberM.ToString() +" "+ GetNaturalNumbers(numberM + 1, numberN);
}


int numberM = GetNumber("Введите число ");
int numberN = GetNumber("Введите число ");
Console.WriteLine(GetNaturalNumbers(numberM, numberN));*/








/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */


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

int GetSumOfNumbers(int number, int sum)   //у метода тип int тк в методе производятся математические действия. 
{                                           //также вводим аргумент sum - контейнер, в который будет записываться результат.
    if(number == 0 )
    return sum;
    else
    {
        sum += number % 10;
        number /= 10;
        return GetSumOfNumbers(number, sum);
    }
}


int number = GetNumber("Введите число ");
int sum = 0;
Console.WriteLine(GetSumOfNumbers(number, sum)); */








/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */


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

int GetProductOfNumbers(int numberA, int numberB)
{
    if(numberB == 1 )
    return numberA;
    else
    {
        return numberA * GetProductOfNumbers(numberA, numberB - 1);
    }
}


int numberA = GetNumber("Введите число ");
int numberB = GetNumber("Введите степень числа: ");
Console.WriteLine(GetProductOfNumbers(numberA, numberB));
