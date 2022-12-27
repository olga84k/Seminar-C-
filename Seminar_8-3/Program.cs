// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
int[,] InitMatrix1(int rows1, int columns1)
{
    int[,] matrix = new int[rows1, columns1];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 5);
        }
    }
    return matrix;
}
int[,] InitMatrix2(int rows2, int columns2)
{
    int[,] matrix = new int[rows2, columns2];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 5);
        }
    }
    return matrix;
}

void PrintInitMatrix(int[,] matrix )
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] GetMultiplicationMaxtrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                    {
                        int summ = 0;
                        for (int k = 0; k < matrix1.GetLength(1); k++)
                            {
                                summ +=  matrix1[i,k] * matrix2[k, j];  
                                matrix3[i,j] = summ;
                            }
                    }
            }  
        }

       else
       {
        Console.WriteLine($"матрицы перемножить нельзя");
         
       }
       
    return matrix3;
}
int rows1 = GetNumber("Введите количество строк первой матрицы:");
int columns1 = GetNumber("Введите количество столбцов первой матрицы:");
int rows2 = GetNumber("Введите количество строк второй матрицы:");
int columns2 = GetNumber("Введите количество столбцов второй матрицы:");
int[,] matrix1 = InitMatrix1(rows1, columns1);
PrintInitMatrix(matrix1);
int[,] matrix2 = InitMatrix2(rows2, columns2);
PrintInitMatrix(matrix2);
int[,] matrix3 = new int[columns1,rows2];
int [,] matrix = GetMultiplicationMaxtrix(matrix1,matrix2,matrix3);
PrintInitMatrix(matrix);
