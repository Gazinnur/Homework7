//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int NumberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int NumberB = int.Parse(Console.ReadLine());
int max = NumberA;
int min = NumberB;
if (NumberB > max)
{
    max = NumberB;
}
Console.WriteLine("Max =" + max);
