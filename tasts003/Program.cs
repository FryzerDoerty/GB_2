// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите число, от 1, до 7, соответствующее дню недели:");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 6 | numberA == 7){Console.WriteLine("Да");}
else if (numberA<6){
Console.WriteLine("Нет");
}
else if (numberA > 7){
   Console.WriteLine("В неделе 7 дней"); 
}

Console.ReadKey();
