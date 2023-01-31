/*Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int InputInt(string message) //ввод числа
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
int[] InputMassive(int M) // формирование массива введенных чисел
{
    int[] massive = new int[M];
    for (int i = 0; i < M; i++)
    {
        massive[i] = InputInt($"Введите число {i + 1} -> ");
    }
    return massive;
}
int Plus(int[] massive) //Количество чисел в массиве больше 0
{
    int summplus = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0) summplus++;
    }
    return summplus;
}
Console.Clear();
int M = InputInt("Сколько чисел вы хотите ввести? > ");
System.Console.WriteLine($"Количество чисел в массиве больше 0 = {Plus(InputMassive(M))}");