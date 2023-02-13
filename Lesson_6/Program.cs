/*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

/* int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(1,10);
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

int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }

    return result;
}

int[] array = InitArray(10);
PrintArray(array);
int[] result = ReverseArray(array);
PrintArray(result);

Array.Reverse(result);

PrintArray(result); */






/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

/* int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
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

void CheckSide(int firstNumber, int secondNumber, int thirdNumber)
{
    if (firstNumber < secondNumber + thirdNumber && secondNumber < firstNumber + thirdNumber && thirdNumber < firstNumber + secondNumber)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

int firstNumber = GetNumber("Enter the first number: ");
int secondNumber = GetNumber("Enter the second number: ");
int thirdNumber = GetNumber("Enter the third number: ");

CheckSide(firstNumber, secondNumber, thirdNumber); */







/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

/* int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
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

void ConvertToBinary(int number)
{
    string result = string.Empty;       // создаем новую пустую строку, в которую будет записываться результат деления
    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }
    Console.Write(result);
}

int number = GetNumber("Enter the number: ");
ConvertToBinary(number); */







/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

/* int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
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


int number = GetNumber("Enter the number: ");


void FindFibonacciNumber(int number)
{
    int firstNumber = 0;
    int secondNumber = 1;
    int sum = 0;

    if( number == 1)
    {
        Console.Write("0");
    }
    if(number == 2)
    {
        Console.Write("01");
    }
    else
    {
        Console.Write("01");
        for (int i = 3; i <= number; i++)
        {
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
            Console.Write($"{sum}");
        }
    }

}

FindFibonacciNumber(number); */









/* Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. */

int[] InitArray()
{
    int[] result = new int[10];
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

int [] CopyArray (int [] array)
{
    int [] newArray = new int [10];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i];
        
    }
    return newArray;
}

int [] array = InitArray();
PrintArray(array);
int [] resultArray = CopyArray (array);
PrintArray(resultArray);
