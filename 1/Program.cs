/*Задача 1: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/
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
int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
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
int[] array = GenerateArray(5);
PrintArray(array);
PrintArray(Reverse(array));