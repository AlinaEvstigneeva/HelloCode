﻿// Виды методов



// 1 вид - ничего не принимают и ничего не взващают.

void Method1()
{
    Console.WriteLine("Автор ...");                 // Используется, например, для автоматической подписи.
}
Method1();                                          // Таким образом вызываем метод.





// 2 вид - принимают некоторые аргументы, но ничего не возвращают.

void Method2(string msg)                            // Принимает аргумент msg (какое-то сообщение)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");                         // Вызов методаю


void Method21(string msg, int count)                // Аргументов может быть несколько.
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;                                    // i++  -инкремент; i--  -декремент
    }
}
Method21(msg: "Текст", count: 4);                   // Вызов метода. "Текст" - аругмен msg; 4 - count
                                                    // В консоли будет выведено слово "Текст" четыре раза.
                                                    // Если команда зациклилась, остановить ( control + C )





// 3 вид - ничего не принимают, но что-то возвращают

int Method3()                                       // если метод что-то возвращает, обязательно должен быть указан тип данных
{                                                   // например int
    return DataTime.Now.Year;
}
int year = Method3();                               // вызывать метод можно через новую переменную и идентификатор присваивания
Console.WriteLine(year);                            // затем мы можем использовать эту новую переменную, для различных манипуляций





// 4 вид - что-то принимают и что-то возвращают

string Method4(int count, string text)              // int count, string text - аргументы введенные в метод
{
    int i = 0;                                      // i - перременная для счетчика цикла, в котором будет работать метод
    string result = String.Empty;                   // string result - переменная, в которой будет храниться результат метода
    while( i< count)                                // String.Empty - команда для создания пустой строки
    {
        rusult = result + text;
        i++;                                        
    }
    return result;                                  // возвращаем результат
}
string res = Method4(10, "hello");                  // для вызова метода, так же заводим переменную
Console.WriteLine(res);                             