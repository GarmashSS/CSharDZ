/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine ("Введите число");
 int num = Convert.ToInt32(Console.ReadLine());
 int res1 = 0;


 if (num < 0)
 {
     num = -num;
 }

if (num < 100)    
 {
   Console.WriteLine("Третьей цифры нет");
 }
while (num >= 1000 )
{
   num = num / 10;
}

if ( num >= 100 && num < 1000)
{
   res1 = num % 10;
   Console.WriteLine($"Третья цифра {res1}");
}


 
  

  


