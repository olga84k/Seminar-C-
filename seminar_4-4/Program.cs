//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
string str = Console.ReadLine() ?? "";
if (!int.TryParse(str, out int val)) return;
int summ = 0;
for (int i = 0; i < str.Length; i++)
   {
    summ = summ + int.Parse(str[i].ToString());
   } 
Console.WriteLine($"{summ}");