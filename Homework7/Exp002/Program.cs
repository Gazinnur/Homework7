// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int NumA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int NumB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int NumC = int.Parse(Console.ReadLine());

int Max = NumA;
if (Max < NumB)
{
    Max = NumB;
}
if (Max < NumC)
{
    Max = NumC;
};
Console.WriteLine("Max = " + Max);