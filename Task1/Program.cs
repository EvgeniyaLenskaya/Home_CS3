// Задача 19: Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number/10000==number%10 && (number/1000)%10==(number/10)%10)
{
    Console.WriteLine("Это число - палиндром!");
}
else
{
    Console.WriteLine("Это число - не палиндром!");
}
