// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Hello, World!");

System.Console.WriteLine("Введите число: ");
int nam = Convert.ToInt32(Console.ReadLine());

int nam_1 = Math.Abs(nam); 

string nam_2 = Convert.ToString(nam_1);

string nam_3 = (nam_1 > 99) ? ($"третья цифра введенного числа  {nam_2[2]}") : "третьей цифры в заданном числе нет";

Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine(nam_3);
Console.ResetColor();