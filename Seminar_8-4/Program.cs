// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
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
int[,,] InitArray(int posizion1, int posizion2, int posizion3)
{
    int[,,] array = new int[ posizion1, posizion2, posizion3];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int z = 0; z < array.GetLength(2); z++)
                {
                array[i, j, z] = rnd.Next(10, 100);
                }
            }
    }
    return array;
}
void PrintInitArray(int[,,] array )
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
             Console.Write($"{array[i, j, z]}");
             Console.Write( $"({i},{j},{z}); ");
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    }

}
int posizion1 = GetNumber("Введите позицию 1:");
int posizion2 = GetNumber("Введите позицию 2:");
int posizion3 = GetNumber("Введите позицию 3:");
int[,,] array = InitArray(posizion1,posizion2,posizion3);
PrintInitArray(array);