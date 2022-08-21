/*
    Задача 26: Напишите программу, которая принимает
    на вход число и выдаёт количество цифр в числе.
    456 -> 3
    78 -> 2
    89126 -> 5
*/

//Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int indexNumber = GetIndexNumber(number);
PrintIndex(indexNumber);

int GetIndexNumber(int number)
{
    int index = 1;
    while(true)
    {
        if (number < 10)
        {
            if (number == 0) return index = 0;
            break;
        }
        number = number / 10;
        index++; 
    }
    return index;
}

void PrintIndex(int index)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"В числе {number} -> {index}");
    Console.ResetColor();
}