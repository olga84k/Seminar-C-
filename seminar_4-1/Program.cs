// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int  number2 = Convert.ToInt32(Console.ReadLine());

int result = 1;
int number =  Math.Abs(number2); 
for (int i = number; i > 0; i--)
{
    result = result * number1;
}
Console.WriteLine($"{result}");