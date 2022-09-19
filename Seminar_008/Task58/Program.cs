// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();

int [,] FirstMatrix ()
{
    Console.Write("Input the number of rows:");
    int rows = int.Parse(Console.ReadLine());
    
    Console.Write("Input the number of columns:");
    int columns = int.Parse(Console.ReadLine());
    
    Console.Write("Input min possible value:");
    int minValue = int.Parse(Console.ReadLine());
    
    Console.Write("Input max possible value:");
    int maxValue = int.Parse(Console.ReadLine());

    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(minValue, maxValue+1);
    return matrix;
}

int [,] SecondMatrix ()
{
    Console.Write("Input the number of rows:");
    int rows = int.Parse(Console.ReadLine());
    
    Console.Write("Input the number of columns:");
    int columns = int.Parse(Console.ReadLine());
    
    Console.Write("Input min possible value:");
    int minValue = int.Parse(Console.ReadLine());
    
    Console.Write("Input max possible value:");
    int maxValue = int.Parse(Console.ReadLine());

    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(minValue, maxValue+1);
    return matrix;
}

int [,] MultiplicationMatrix (int [,] fisrtmatrix, int [,] secondmatrix)
{
    if (fisrtmatrix.GetLength(1) != secondmatrix.GetLength(0)) System.Console.WriteLine("Матрицы нельзя перемножить");
    int [,] matrix = new int [fisrtmatrix.Length, secondmatrix.Length];
    for (int i = 0; i < secondmatrix.GetLength(1); i++)
    {
        for (int j = 0; j < secondmatrix.GetLength(0); j++)
        {
            matrix[i, j] = 0;
            for (int k = 0; k < secondmatrix.GetLength(1); k++)
            {
                matrix[i, j] += fisrtmatrix[i, k] * secondmatrix[k, j];
            }
        }
    }
    return matrix;
}

void ShowMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] firstmatrix = FirstMatrix();
int [,] secondmatrix = SecondMatrix();
ShowMatrix(firstmatrix);
ShowMatrix(secondmatrix);
ShowMatrix(MultiplicationMatrix(firstmatrix, secondmatrix));
