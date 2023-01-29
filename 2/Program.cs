/*Напишите программу, которая принимает на вход три числа и
 проверяет, может ли существовать треугольник с сторонами такой длины.*/
int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
int a = InputInt("Введите А > ");
int b = InputInt("Введите B > ");
int c = InputInt("Введите C > ");
bool treugol(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
    return true;
}
return false;
}
if (treugol(a, b, c) == true) 
{
    System.Console.WriteLine("Это треугольник");
}
else System.Console.WriteLine("Это другая фигура");