// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double k1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (b1-b2)/(k2-k1);
double y;
if ((k1%k2==0) || (k2%k1==0))

    Console.WriteLine("Прямые не пересекаются");
else
{
    
    x = (b1-b2)/(k2-k1);
    y = k1 * x + b1;
    Console.WriteLine ($"{(x,y)}");
}