Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine() ?? "";
Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine() ?? "";
Console.WriteLine("Введите третье число");
string number3 = Console.ReadLine() ?? "";
int numberfirst = Convert.ToInt32(number1);
int numbersekond = Convert.ToInt32(number2);
int numbernext = Convert.ToInt32(number3);
int max = numberfirst;
if (numberfirst < numbersekond)
{
    max = numbersekond;
    if (max < numbernext)
    {
      max = numbernext; 
    } 
}
Console.WriteLine($"максимальное число: {max}");