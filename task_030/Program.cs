/*
    Задача 30: Напишите программу, которая
    выводит массив из 8 элементов, заполненный
    нулями и единицами в случайном порядке.
    [1,0,1,1,0,1,0,0]

*/
 Console.Clear();

 Console.Write("Введите число элементов в массиве: ");
 int length = int.Parse(Console.ReadLine());
 int[] array = CreateArray(length);
 PrintArray(array);

int[] CreateArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }

    return array;
} 

 void PrintArray(int[] array)
 {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length -1)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine("]");
    Console.ResetColor();
 }