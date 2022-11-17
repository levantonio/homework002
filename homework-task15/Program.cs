// Задача №15.
// Написать программу, которая:
// 1. принимает на вход цифру, обозначающую день недели
// 2. определяет выходной ли день или нет


Console.WriteLine("Введите номер дня недели(1...7)");
int dayweek = Convert.ToInt32(Console.ReadLine());

string DaysWEEK(int dayweek)
{
    if (dayweek >= 1 && dayweek < 6)
        return $"День недели под №-{dayweek} -> является рабочим днём недели";
    else if (dayweek > 7)
        return $"{dayweek} -> не является днём недели";
    else
        return $"День недели под №-{dayweek} -> является выходным днём";
}

string result = DaysWEEK(dayweek); 
Console.WriteLine(result);
