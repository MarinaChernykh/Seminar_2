// Задача 11 (Семинар)
// Напишите программу, которая выводит
// случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int number1 = number / 100;
int number2 = number % 10;
Console.Write(number1);
Console.WriteLine(number2);
