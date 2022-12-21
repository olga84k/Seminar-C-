// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//получить размерность массива с консоли
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
            Console.WriteLine("Vveli nevernye danniye. Vvedite korrektnoe chislo");
        }
    }
    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

//распечатать массив на консоль
void PrintMatrix(int[,] matrix)
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
int rows = GetNumber("Введите кол-во строк: ");
int columns = GetNumber("Введите кол-во столбцов: ");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ += matrix[i, j];
    }

    Console.Write($"{summ / matrix.GetLength(0)}; ");
}
 