// Задача №10
// Написать программу, которая:
// 1. Принимает на ввод трёхзначное число
// 2. На выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int AverageNumber(int num)
{
    int figure = (num / 10) % 10;
    return figure;
}

int result = AverageNumber(number);
if (number > 99 &&  number <= 999)
{
    Console.WriteLine($"Средняя цифра числа: {number} --> {result}");
}
else
    Console.WriteLine($"{number}-Число не трехзначное");
