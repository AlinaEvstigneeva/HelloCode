// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46 782 -> 72 918 -> 98

Random randomNum = new();
int number = randomNum.Next(100, 999);
Console.WriteLine(number);

int firstNumber = number / 100;
int thirdNumber = number % 10;                  //чтобы работать с последней цифрой числа, всегда делим на 10 (%10)
int result = firstNumber * 10 + thirdNumber;
Console.WriteLine(result);
