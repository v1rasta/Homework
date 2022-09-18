// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();

int [,] CreateNewArray ()
{
    Console.Write("Input the number of rows:");
    int rows = int.Parse(Console.ReadLine());
    
    Console.Write("Input the number of columns:");
    int columns = int.Parse(Console.ReadLine());
    
    Console.Write("Input min possible value:");
    int minValue = int.Parse(Console.ReadLine());
    
    Console.Write("Input max possible value:");
    int maxValue = int.Parse(Console.ReadLine());
    
    int [,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void FindValueIndexArray (int [,] array)
{
    Console.Write("Input the number of rows:");
    int numIndex1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input the number of columns:");
    int numIndex2 = Convert.ToInt32(Console.ReadLine());

    int [,] newArray = new int [numIndex1, numIndex2];
    if (numIndex1 < 0 || numIndex1 > array.GetLength(0) || numIndex2 < 0 || numIndex2 > array.GetLength(1))
        Console.WriteLine("The element does not exist");
    else
        Console.WriteLine($"Value of an array element {array[numIndex1, numIndex2]}");
}

void Show2dArray (int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
            Console.WriteLine();
        Console.WriteLine();
    }

int [,] myArray = CreateNewArray();
Show2dArray(myArray);
FindValueIndexArray(myArray);