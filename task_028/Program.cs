/*
    Задача 28: Напишите программу, которая
    принимает на вход число N и выдаёт
    произведение чисел от 1 до N.
    4 -> 24
    5 -> 120
*/

//Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int workNumber = GetWorkNumber(number);
PrintWork(workNumber);

int GetWorkNumber(int number)
{
    int work = 1;
    for (int i = 1; i <= number; i++)
    {
        work *= i; 
    }
    return work;
}

void PrintWork(int work)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Произведение чисел от 1 до {number} = {work}");
    Console.ResetColor();
}