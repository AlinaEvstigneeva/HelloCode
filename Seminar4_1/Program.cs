//Задача 24: Напишите программу, которая принимает на вход число
// (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28 4 -> 10 8 -> 36

bool isParsed = int.TryParse(Console.ReadLine(), out int number);      //Считываем число из консоли

if (!isParsed || number < 1)                     // Проверка для введенного числа, чтоб оно было положительным и целым
{                                               // ! - превращает TRUE в FALSE, т.е. введенное число не соответствует
    Console.WriteLine("Incorrect number");      // критериям: положительное и целое. Значит программа выдает результат:
    return;                                     // "Некоректное число"
}

// int sum = GetSum(number);
// Console.WriteLine(sum);

int GetSum(int number)
{
    int sum = 0;
    for (var i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

// ручная проверка (ручная проверка)
int[] numbers = new int[]{1, 2, 3, 4};      // значения, котороые ввели

int [] sums = new int []{1, 3, 6, 11};      // значения, которые ожидаем получить

for( var i = 0; i < numbers.Length; i++)
{
    int sum = GetSum(numbers[i]);

    if(sum != sums[i])
    {
        Console.WriteLine($"Ожидали получить {sums[i]}, а получили {sum}");
    }
    else
    {
        Console.WriteLine("okay");
    }
}