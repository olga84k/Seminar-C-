Console.WriteLine("Введите  число");
string number1 = Console.ReadLine() ?? "";
int N = Convert.ToInt32(number1);
int number = 1;
if (N>0)
{
   while (number < N)
{
   int rem = number%2; 
    if (rem==0)
    {
       Console.Write($"  {number}"); 
    }
    number = number + 1;
}
}
else
{
   Console.WriteLine("не принадлежит области определения");
}