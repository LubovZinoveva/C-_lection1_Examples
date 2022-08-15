// В тексте нужно все пробелы заменить черточками, маленькие буквы 'к' заменить большими
// 'К', а большие С заменить маленькими с.

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string text = "Природа — материальный мир ВСеленной, в Сущности — основной объект";
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();