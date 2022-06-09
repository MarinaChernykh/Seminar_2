// Задача 10.
// Напишите программу, которая принимает на вход 
// трехзначное число и на выходе показывает
// вторую цифру этого числа

Console.Write("Введите трехзначное число: ");
int FullNumber = Convert.ToInt32(Console.ReadLine());
if (FullNumber < 100 || FullNumber > 999) 
{
    Console.WriteLine("Введенное число - не трехзначное");
}
else
{
    int SecondNumber = (FullNumber / 10) % 10;
    Console.WriteLine(SecondNumber);
}
