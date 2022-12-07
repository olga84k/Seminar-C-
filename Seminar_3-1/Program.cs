int number =  new Random().Next(10000,100000);
Console.WriteLine($"{number}");
string str = number.ToString();
if (str[0]==str[4] && str[1]==str[3])
{
  Console.WriteLine($" {number} палиндром");  
}
else
{
    Console.WriteLine($" {number} непалиндром");
} 