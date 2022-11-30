Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine() ?? "";
Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine() ?? "";
int numberfirst = Convert.ToInt32(number1);
int numbersekond = Convert.ToInt32(number2);
int max  = numberfirst;
int min = numbersekond;
if (numberfirst < numbersekond);
{
    max = numbersekond;
    min = numberfirst;
}
Console.WriteLine($"максимальное число: {max}");
Console.WriteLine($"минимальное число: {min}");