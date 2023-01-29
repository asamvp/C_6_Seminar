/* Напишите программу, которая будет создавать копию
 заданного массива с помощью поэлементного копирования.*/

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random Rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Rnd.Next(-9, 10);
    }
    return array;
}
int[] CopyMassive(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i]=array[i];
    }
    return array2;
}
void PrintArray(int[] array)//пишет функцию (массив), написанный выше
{
    foreach (int item in array)//альтернатива циклу фор (работает не с индексами, а с элементами массива
    {
        System.Console.Write($"{item}\t");// выводит элемент массива
    }
    System.Console.WriteLine();//перевод курсора на след строку
}
Console.Clear();
int[] array = GenerateArray(7);
PrintArray(array);
PrintArray(CopyMassive(array));