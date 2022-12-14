// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//получить размерность массива с консоли
int GetNumber(string message)
{
int result;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result > 0)
{
break;
}
else
{
Console.WriteLine("Ввели не число. Введите корректное число");
}
}
return result;
}

//получить заполненный массив рандомными числами
int[] InitArray(int dimension)
{
int[] array = new int[dimension];
Random rnd = new Random();

for (int i = 0; i < dimension; i++)
{
array[i] = rnd.Next(100, 1000);
}

return array;
}
//распечатать массив на консоль
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}

Console.WriteLine();
}

//найти количество четных элементов
int GetEvenNumber(int[] array)
{
int count = 0;

for (int i = 0; i < array.Length; i++)
{
if(array[i]%2==0)
count++;
}
return count;
}
int dimension = GetNumber("Введите размерность массива:");
int[] array = InitArray(dimension);
PrintArray(array);
int evennumber = GetEvenNumber(array);
Console.WriteLine($"{evennumber}");
