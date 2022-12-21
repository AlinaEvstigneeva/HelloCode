//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// sting s = "qwerty"
//            012345
// s[3] - r

string Replace(string text, char oldValue, char newValue)       // char - тип данных - символ
{
    string result = String.Empty;

    int length = text.Length;
    for( int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";    // результат выполнения условия должен куда-то помещаться
        else result = result + $"{text[i]}";                        // в нашем случае это result.
    }   
    return result;
}

string newText = Replace(text, ' ', '|');               // вызываем метод через новую переменную
Console.WriteLine(newText);                             // выводим результат в консоль

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);                     // теперь можно использовать метод для других задач, и не писать снова код