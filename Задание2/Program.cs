// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число:");
string str = Console.ReadLine() ?? "";
int num = Convert.ToInt32(str);

    void Function1(int num)
    {
        if(num > 99)
 {
    Console.WriteLine($"третья цифра: {str[2]}");
 }
 else if(num < (-99))
 {
   Console.WriteLine($"третья цифра: {str[3]}"); 
 }
 else
    Console.WriteLine("В значении отсутствует третья цифра.");

    }

    Function1(num);