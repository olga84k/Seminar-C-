// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
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
double[] InitArray(int dimension)
{
double[] array = new double[dimension];
Random rnd = new Random();

for (int i = 0; i < dimension; i++)
{
array[i] = rnd.NextDouble()*20;
}

return array;
}
//распечатать массив на консоль
void PrintArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}

Console.WriteLine();
}

//найти разность между максимальным и минимальным элементами массива
double GetDifferenzeMaxMin(double[] array)
{
double diff = 0;
double max = array[0];
double min = array[array.Length - 1];

for (int i = 0; i < array.Length; i++)
{
if(array[i]>max)
array[i] = max;
}
Console.WriteLine($"{max}");
for (int i = 0; i < array.Length; i++)
{
if (array[i]<min)
array[i] = min;
}
Console.WriteLine($"{min}");
diff = max-min;
return diff;
}
int dimension = GetNumber("Введите размерность массива:");
double[] array = InitArray(dimension);
PrintArray(array);
double differenzemaxmin = GetDifferenzeMaxMin(array);
Console.WriteLine($"{differenzemaxmin}");