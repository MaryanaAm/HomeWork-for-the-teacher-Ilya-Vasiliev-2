// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Пожалуйста, введите трехзначное число от 100 до 999 : ");

string number = Console.ReadLine() ?? "";
int num = Convert.ToInt32(number);

if(num < 1000 && num > 99)
{
    Console.WriteLine($"Вторая цифра числа: {number[1]}");
}

else
{
    Console.WriteLine("Вы ввели некоректное число");
    Console.WriteLine("Пожалуйста, введите трехзначное число от 100 до 999 : ");
}
