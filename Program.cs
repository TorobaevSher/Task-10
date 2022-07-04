// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает 
// вторю цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число{num}");

int firstDigit = (num % 100) % 10;

Console.WriteLine(firstDigit);

