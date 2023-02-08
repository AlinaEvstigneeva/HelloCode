/* int GetNumber(string message)
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

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int number = GetNumber("Введите число больше 0:");
int sum = GetSum(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}"); */







/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */


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


int GetCountOfDigits(int number)
{
    int count = 0;
    while(number != 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}


int number = GetNumber("Введите число: ");
int counOfDigit = GetCountOfDigits(number);

Console.WriteLine($"Введенное число {number}, кол-во цифр {counOfDigit}"); */







/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

/* int GetNumber(string message)
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


int GetProductOfDigit(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product = product * i;
    }
    return product;
}

int number = GetNumber("Введите число: ");
int productOfDigit = GetProductOfDigit(number);

Console.WriteLine($"Произведение числес от 1 до {number} равно: {productOfDigit}"); */







/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

/* int[] array = new int[8];

void InitArray(int[] array)
{
    int length = array.Length; // Переменной передаётся значение равное длине массива
    int index = 0;
    Random rnd = new Random();                  // Счётчик элементов
    while (index < length)          //Цикл пока
        {
            array[index] = rnd.Next(0, 2); //Случайное заполнение первого элемента массива
            index++;                // Увеличиваем счётчик элементов на 1
        }
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write(array[i]);
    }

}

InitArray(array);
PrintArray(array); */
