int number =  new Random().Next(1,8);
Console.WriteLine($"{number}");
if (number==6||number==7)
{
    Console.WriteLine("выходной день"); 
}
else
{
   Console.WriteLine("невыходной день"); 
}