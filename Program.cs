/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


// int SecondNumber(int number)
// {
//     int sot = number / 100;
//     int dec = number / 10;
     
//     int result = dec - (sot*10);
//     return result;
// }

// Console.WriteLine("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99 && number < 1000)
// {
//     int secDigit = SecondNumber(number);
//     Console.WriteLine(secDigit);
// }
// else 
// {
//     Console.WriteLine("Введите трёхзначное число!");
// }
    
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Input a number");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 100) 
// {
//     Console.WriteLine("Третьей цифры нет!");
// }
// else
// {
//     int digitIndex = 2; 
//     int thirdDigit = number.ToString()[digitIndex] - '0';
//     Console.WriteLine("Третья цифра числа: " + thirdDigit);
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Input a number of day: ");
int day = Convert.ToInt32(Console.ReadLine());
if ( day < 6)
{
    Console.WriteLine ("Unfortunately, it's time to work...");
}

else if ( day > 5 && day < 8)
{
    Console.WriteLine("Day off. It's time to get some rest!");
}
else 
{
    Console.WriteLine("Please input a number from 1 to 7!");
}