/*Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1,      y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
int InputInt(string message) //ввод числа
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
Console.Clear();
double b1 = InputInt("Введите b1 > ");
double k1 = InputInt("Введите k1 > ");
double b2 = InputInt("Введите b2 > ");
double k2 = InputInt("Введите k2 > ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
System.Console.WriteLine($"Точка пересечения координат = ({x}; {y})");