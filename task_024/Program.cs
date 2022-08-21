/*
    Задача 24: Напишите программу, которая
    принимает на вход число (А) и выдаёт сумму чисел
    от 1 до А.
    7 -> 28
    4 -> 10
    8 -> 36
*/

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int resultSum = GetSum(number);
PrintSum(resultSum);

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

void PrintSum(int sum)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
    Console.ResetColor();
}