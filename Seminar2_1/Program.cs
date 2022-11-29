// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8;
// 12 -> 2;
// 85 -> 8;

Random randomNum = new();                   // Создаем генератор случайных чисел
int number = randomNum.Next(10, 100);              // Обращаемся к сетоду рандома и вводим диапазон чисел
Console.WriteLine(number);                      // Выводим сгенерированное число

int firstNumber = number / 10;                  // вводим переменные для первой и второй цифры двузначного числа
int lastNumber = number % 10;

if (firstNumber > lastNumber)
{
    Console.WriteLine(firstNumber);
}                                               // сравниваем цифры числа между собой и выводим большую
else
{
    Console.WriteLine(lastNumber);
}

