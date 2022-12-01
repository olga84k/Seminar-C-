Console.WriteLine("Введите  число");
string number1 = Console.ReadLine() ?? "";
int number = Convert.ToInt32(number1);
int rem = number%2;
if (rem==0)

    Console.WriteLine("Число четное"); 
    else
    
        Console.WriteLine("Число нечетное"); 