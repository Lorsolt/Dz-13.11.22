// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 7)
{
    if (num <= 5)
    {
        Console.WriteLine(" Рабочий день ");
    }
    if (num == 6 || num == 7)
    {
        Console.WriteLine(" Выходной :D ");
    }
}
else
{
    Console.WriteLine("Нет такого дня недели, ты откуда такой 'уникальный'?");
}
