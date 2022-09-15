// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumDig(int num)
{
    int result = 0;
        while (num>0)
    {
        result +=num%10; 
        num /= 10;
    }
    return result;
}
Console.WriteLine("Input your number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDig(num));