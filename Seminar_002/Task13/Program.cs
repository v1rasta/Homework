// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int numNumbers(int result)
{
    int a = 1;
    while(result / 10 != 0)
    {
        result = result / 10;
        a++;
    }
    return a;
}

int Dec(int stepen)
{
    int dec = 10;
    while(stepen != 1)
    {
        dec = dec * 10;
        stepen = stepen - 1;
    }
    return dec;
}

Console.Clear();

Console.Write("Print your number:");
int num = Convert.ToInt32(Console.ReadLine());

if(numNumbers(num) <= 2)
{
    Console.WriteLine($"There is no third digit in the number {num}!");
}
else
{
    int exp = numNumbers(num) - 2;
    int znam = Dec(exp);
    int ThirdDigit = (num % znam) / (znam / 10);
    
    Console.Write($"In the number {num}, the third digit is {ThirdDigit}");
}
