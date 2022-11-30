Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine() ?? "";
Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine() ?? "";
Console.WriteLine("Введите третье число");
string number3 = Console.ReadLine() ?? "";
int numberfirst = Convert.ToInt32(number1);
int numbersekond = Convert.ToInt32(number2);
int numbernext = Convert.ToInt32(number3);
if((numberfirst < numbernext)&&(numbernext < numbersekond));
{
    Console.WriteLine(numbersekond); 
    if((numbersekond < numberfirst)&&(numberfirst < numbernext));
    {
    Console.WriteLine(numbernext);
    }
    
}   
if((numbersekond < numberfirst)&&(numberfirst < numbernext));
{
    Console.WriteLine(numbernext);
}
 if ((numbernext < numbersekond) && (numbersekond < numberfirst));
{
      Console.WriteLine(numberfirst);
}