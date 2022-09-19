// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();

double [,] CreateRandomDoubleArray ()
{
    Console.Write("Input the number of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Input the number of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Input min possible value:");
    int minValue = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Input max possible value:");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    double [,] array = new double [rows, columns];
    for(int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1) + Math.Round(new Random().NextDouble(),2);
    return array;
}

void Show2dArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
        }
    Console.WriteLine();
}

double [,] myArray = CreateRandomDoubleArray();
Show2dArray(myArray);
