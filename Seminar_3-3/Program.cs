Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N>0)
{
for(int i = 1;i <= N; i++)
{
Console.WriteLine($"{i * i* i}");
}
}
else
{
  for(int i = N;i < 0; i++)
{
Console.WriteLine($"{i * i* i}");
}  
}