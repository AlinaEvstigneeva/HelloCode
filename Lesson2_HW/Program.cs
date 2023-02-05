/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/* int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int ShowSecondDigit(int enteredNumber)
{
    int firstAct = enteredNumber / 10;
    int secondAct = firstAct % 10;
    return secondAct;
}

int enteredNumber = NumberRequest("Enter the number: ");
int result = ShowSecondDigit(enteredNumber);

Console.WriteLine($"Entered number is {enteredNumber}, the second digit is {result}"); */









/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


/* int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ShowSecondDigit(int enteredNumber)
{
    while(enteredNumber >= 100)
    {
        int firstAct = enteredNumber / 10;
    }
    int secondAct = firstAct % 10;
    return secondAct;
}

int enteredNumber = NumberRequest("Enter the number: ");
int result = ShowSecondDigit(enteredNumber);

Console.WriteLine($"Entered number is {enteredNumber}, the second digit is {result}"); */







/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int enteredNumber = NumberRequest("Enter the number: ");

if(enteredNumber == 1)
{
    Console.WriteLine("No");
}
if(enteredNumber == 2)
{
    Console.WriteLine("No");
}
if(enteredNumber == 3)
{
    Console.WriteLine("No");
}
if(enteredNumber == 4)
{
    Console.WriteLine("No");
}
if(enteredNumber == 5)
{
    Console.WriteLine("No");
}
if(enteredNumber == 6)
{
    Console.WriteLine("Yes");
}
if(enteredNumber == 7)
{
    Console.WriteLine("Yes");
}
if(enteredNumber < 1 | enteredNumber > 7)
{
    Console.WriteLine("Invalid number");
}
