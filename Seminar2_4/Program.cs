// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
// 14 -> нет 46 -> нет 161 -> да

int a = int.Parse(Console.ReadLine());
int firstExam = 7;
int secondExam = 23;

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}