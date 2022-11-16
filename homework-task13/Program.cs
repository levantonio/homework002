// Задача №13.
// Написать программу, которая:
// 1. выводит 3 цифру заданного числа
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int ThirdDigit(int number)
{
    int result = -1; // на семинаре говорили, что можго использовать -1 если числа нет
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;

} 
int result = ThirdDigit(number);
if(result == -1) Console.WriteLine($"{number} --> двузначное число");
else Console.WriteLine($"{number} -- > {result}");

