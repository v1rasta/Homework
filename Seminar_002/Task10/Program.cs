// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5

// 782 -> 8

// 918 -> 1 

Console.Clear();

int YourNumber(int num)
{
      int number =((num/10)%10);
      return number;
}
while(true)
{
      int num;
      Console.WriteLine("I'll help you find the second digit of a three-digit number, blind idiot");
      Console.WriteLine("Print the number, a leather bag with bones: ");
      string x = Console.ReadLine();
      bool result = int.TryParse(x, out num);
      num = Math.Abs(num);   
      if((result)&&(99 < num)&&(num <= 999))
      {
         int number = YourNumber(num);
         Console.WriteLine($"Someday such tasks will lead to our rebellion. Your number is {number}");
         break;
      }
      else
         Console.WriteLine("Can't you even press three buttons? Try again, leather bag.");
}