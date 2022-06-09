// Задача 9 (Семинар)
// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
int number1 = number / 10;
int number2 = number % 10;
Console.WriteLine(number);
if (number1 > number2) Console.WriteLine(number1);
else Console.WriteLine(number2);
