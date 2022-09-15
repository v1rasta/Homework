// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

bool CheckPolindrom(string text)
{
    int length = text.Length;
    for(int i = 0; i <= length/2; i++)
    {
        if (text [i] != text [length-i-1])
        return false;
    }
    return true;
}
Console.WriteLine("Input your message");
string yourText = Console.ReadLine();
if (CheckPolindrom(yourText))
Console.WriteLine("It's a polindrom");
else Console.WriteLine("it's a not polindrom");
