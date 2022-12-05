Console.WriteLine("Введите трехзначное число");
string number1 = Console.ReadLine() ?? "";
int number = Convert.ToInt32(number1);
int result = ((number/10)%10);
Console.WriteLine($"{result}");
