Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int A = number2 % number1;
if (A == 0) Console.WriteLine("Кратно");
else
{
    Console.Write("Не кратно, остаток от деления = ");
    Console.WriteLine(A);
}
