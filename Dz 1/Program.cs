//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите число: ");
// string number = (Console.ReadLine());
// int num = number!.Length;
// if (num == 3)
// {
//     Console.WriteLine($"Второе Число: {number[1]} ");
// }
// else
// {
//     Console.WriteLine($"Тебя просят ввести трехзначное число, fratello");
// }




Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 100)
{
    if (num < 999)
        Console.WriteLine((num / 10) % 10);
}
else
{
    Console.WriteLine($"Тебя просят ввести трехзначное число, fratello");
}