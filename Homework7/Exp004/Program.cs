// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 
Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());
int biginNum = 1;
while (biginNum <= Num)
{
    if (biginNum % 2 == 0)
    {
        Console.WriteLine(biginNum );
     }
biginNum=biginNum+1;
}