/*Напишите программу, которая будет преобразовывать десятичное число 
в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
int[] ToBinary(int a)
{
    int[] result = new int[10];
    int i = result.Length - 1;
    while (a > 0)
    {
        result[i] = a % 2;
        a = a / 2;
        i--;
    }
    return result;
}
void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int a = InputInt("Введите Число -> ");
PrintArray(ToBinary(a));
