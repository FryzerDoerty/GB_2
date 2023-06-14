//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите трёхзначное число:");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA/100==0){Console.WriteLine("Третьей цифры нет");}
else{
int B = (numberA%10);
Console.WriteLine(B);
}
Console.ReadKey();
