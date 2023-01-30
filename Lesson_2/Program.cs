// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int GetRandomNumber()
// {
//     Random rnd = new Random();
//     int number = rnd.Next(100, 1000); // [left, right)-> [10, 100) -> [10,99]
//     return number;
// }

// int GetDeliteSecondNumber(int number)
// {   //145
//     int firstDigit = number / 100;  // 1,45 -> деление без остатка
//     int thirdDigit = number % 10;   // 14,5 -> остаток от деление
//     return firstDigit * 10 + thirdDigit;
// }


// int enteredNumber = GetRandomNumber();
// int result = GetDeliteSecondNumber(enteredNumber);

// Console.Write($"Entered number {enteredNumber}, received number {result}");







// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int NumberRequest(string message)
// {
//     Console.WriteLine(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int firstNumber = NumberRequest("Enter number: ");
// int secondNumber = NumberRequest("Enter number: ");

// if (firstNumber % secondNumber == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Остаток от деления {firstNumber % secondNumber}");
// }









// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


// int NumberRequest(string message)
// {
//     Console.WriteLine(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int enteredNumber = NumberRequest("Enter number: ");



// if (enteredNumber % 7 == 0 && enteredNumber % 23 == 0 )      // && - условие И 
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }








// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());   // Convert.ToInt32 - оператор, который переводит любой введенный текст
    return number;                                                         // из консоли в тип int.
}

int firstNumber = NumberRequest("Enter number: ");
int secondNumber = NumberRequest("Enter number: ");

if (firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber )   //  || - условие ИЛИ
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}









/* 1. ссылочный тип (reference types): class, char, array, list
- хранится в управляемой кучи ()
- ссылка на адрес в ячейке памяти в управляемой кучи.

Random rnd; = null..... rnd.Next(1,10). System.NullReferenceException()

rnd = new Random();// выделяется какое-то кол-во памяти в управляемой куче и возвращается ссылка на адрес, 
в которой находится эта переменная(rnd).



2. значимый тип (value types): int, enum, struct, datetime, decimal, double, long, bool, byte
- на стеке (опертивная память). 
- тут мы всегда имеем значение, а не ссылку на это значение */