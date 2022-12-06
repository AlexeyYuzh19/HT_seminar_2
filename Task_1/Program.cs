// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Hello, World!");

System.Console.WriteLine("Введите трехзначное число: ");
int nam_3 = Convert.ToInt32(Console.ReadLine());

String nam_2 = (nam_3 > 99 && nam_3 < 1000) ? ($"вторая цифра введенного числа  {((nam_3 - nam_3%10) / 10)%10}") : "задано не трехзначное число";

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine(nam_2);
Console.ResetColor();



/* 
Второй вариант решения, но без проверки на значность
System.Console.WriteLine($"вторая цифра введенного числа  {((nam_3 - nam_3%10) / 10)%10}");
*/
