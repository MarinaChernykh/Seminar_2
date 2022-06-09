// Задача 13.
// Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет 

Console.Write("Введите любое число: ");
string Number = Console.ReadLine();
int length = Number.Length;
if (length < 3)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    Console.WriteLine(Number[2]);
}
