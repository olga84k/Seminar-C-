// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int GetNumber(string message)
{
int result;
while(true)
{
    Console.WriteLine(message);

    if(int.TryParse(Console.ReadLine(), out result))
        {
        break;
        }
    else
{
Console.WriteLine("Ввели не число.");
}
        }

        return result;
}

int[] InitArray(int dimension)
{
    int[] array = new int[dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());;
    }

return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);
int count = 0;

for (int i =0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"{count}");
