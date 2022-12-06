// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Hello, World!");

System.Console.WriteLine("Введите цифру соответствующую дню недели по возрастанию от понедельника(1) до воскресенья(7): ");
int nam_day = Convert.ToInt32(Console.ReadLine());

if ( nam_day > 0 && nam_day < 8 ) 
{
   // усложнил алгоритм - определим дополнительно день недели
   Console.ForegroundColor = ConsoleColor.Green;
   switch (nam_day)
   {
     case 1:
        Console.Write("Понедельник - бездельник");
        break;
     case 2:
        Console.Write("Вторник - полуторник");
        break;
     case 3:
        Console.Write("Среда - бреда");
        break;
     case 4:
        Console.Write("Четверг - чертегдерг");
        break;
     case 5:
        Console.Write("Пятница - расслаблядница");
        break;
     case 6:
        Console.Write("Суббота - клуббота");
        break;
     case 7:
        Console.Write("Воскресенье - высплюсенье");
        break;
   }
    
    // если следовать строго условиям задачи - то все решение в одной строке :
    Console.ForegroundColor = ConsoleColor.Blue;
    string nam_D = (nam_day == 6 || nam_day == 7) ? " - выходной день" : " - не выходной день"; 
    System.Console.WriteLine(nam_D);

    Console.ResetColor();
}
else
{
Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine("Упс.. у бабы семь пятниц на неделе, а у Вас иначе! Требовалось задать число от 1 до 7.");
Console.ResetColor();
}