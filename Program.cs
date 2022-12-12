// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write ("Введите первое число: ");
int X = int.Parse(Console.ReadLine()!);
Console.Write ("Введите второе число: ");
int Y = int.Parse(Console.ReadLine()!);

void Number ()
{
    double result = Math.Pow(X, Y);

    Console.WriteLine($"{X} ^ {Y} = {result}");
}
Number ();
