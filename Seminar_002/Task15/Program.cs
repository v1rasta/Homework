// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
// 7 -> да
// 1 -> нет

void Saturday(int six)
{
    Console.WriteLine("Saturday is a day off");
}

void Sunday(int seven)
{
   Console.WriteLine("Sunday is a day off");
}

void workingDay(int working)
{
    Console.WriteLine("As the great Lenin said: working, working and working again");
}

void crazyDay(int NotDay)
{
    Console.WriteLine($"You got something mixed up, you don't work {NotDay - 2} days a week");
}

Console.Clear();
Console.Write("Input your week day number: ");
int yourDayNumber = int.Parse(Console.ReadLine());

if(yourDayNumber > 7) crazyDay(yourDayNumber);
else
    if(yourDayNumber == 6) Saturday(yourDayNumber);
    else
        if(yourDayNumber == 7) Sunday(yourDayNumber);
        else
            workingDay(yourDayNumber);

