// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine ("Введите цифру");
 int num = Convert.ToInt32(Console.ReadLine());

 if( num < 1 || num > 7)
 {
    Console.WriteLine("Не является днем недели");
 }

 if (num >=1 && num < 6)
 {
    Console.WriteLine("Не является выходным");
 }
 if (num == 6 || num == 7)
 {
    Console.WriteLine("Является выходным");
 }


