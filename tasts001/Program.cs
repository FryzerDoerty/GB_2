// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int B = (numberA%100)/10;
Console.WriteLine(B);
Console.ReadKey();