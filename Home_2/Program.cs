// Задача 13.
// Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет 

Console.Write("Введите любое число: ");
string Number = Console.ReadLine();
if (Convert.ToString(Number[0]) == "-") // ветка для отрицательных чисел
    if (Number.Length < 4)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine($"Третья цифра числа = {Number[3]}");
    }
}
else
{
    if (Number.Length < 3) // ветка для положительных чисел и 0
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine($"Третья цифра числа = {Number[2]}");
    }
}
