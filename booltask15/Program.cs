// Задача №15.
// Написать программу, которая:
// 1. принимает на вход цифру, обозначающую день недели
// 2. определяет выходной ли день или нет

Console.WriteLine("Введите номер дня недели(1...7)");
int dayweek = Convert.ToInt32(Console.ReadLine());

bool DaysWEEK(int num)
{
    return num >= 1 && num < 6;
}

bool result = DaysWEEK(dayweek); //Выводит false/true

if (result == true)
    Console.WriteLine($"{dayweek} --> Будний день");
else Console.WriteLine($"{dayweek} --> Выходной, или несуществующий день");
//Вопрос про тип данных bool- тут возможен третий вариант, например если пользователь ввёл 8? и если да - в какой строке начать проверку?
