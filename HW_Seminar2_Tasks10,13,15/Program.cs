// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine());

//if (number >99 &&  number < 1000)
//{
 //   int secondDigit= (number/10)%10;
 //   Console.WriteLine($"Вторая цифра в числе = {secondDigit}");
//}
//else
//Console.WriteLine("Число не трехзначное");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine());

//if (number> 99 && number < 1000)
//{ 
  //   int thirdDigit = number % 10;
    //Console.WriteLine($"Третья цифра в числе = {thirdDigit}");
//}

//if (number>1000)
//{
  //int thirdDigit = (number /=100)%10;
 // Console.WriteLine($"Третья цифра в числе = {thirdDigit}");
//}
 // else
     
   //   Console.WriteLine($"Третьей цифры в числе нет");
    


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32 (Console.ReadLine());

if (day>= 6 || day>= 7)
{
    Console.WriteLine("День недели выходной");
}
else if (day<=5)
{
    Console.WriteLine("День недели будний");
}