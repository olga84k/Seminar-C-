Console.WriteLine($"Введите число");
string number = Console.ReadLine() ?? "";
string str = number.ToString();
if (str.Length>=3)
{
  Console.WriteLine($"{str[2]}");  
}
else
{
    Console.WriteLine("Третьей цифры нет");
} 