//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Пожалуйста, введите число от 1 до 7");
string numFor = Console.ReadLine() ?? "";
int number = Convert.ToInt32(numFor);

void Result(int number)
{
if(number < 1 || number > 7)
    {
        Console.WriteLine("--> Вы ввели неправильное число!");
    }

else if(number > 5)
{
    Console.WriteLine("--> Да, это выходной день!");
}
else
{
    Console.WriteLine("--> Нет! Это рабочий день!");
}
}

Result(number);