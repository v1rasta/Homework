// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int AckermanRec(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermanRec(m - 1, 1);
    else return AckermanRec(m - 1, AckermanRec(m, n - 1));
}
Console.WriteLine(AckermanRec(m, n));