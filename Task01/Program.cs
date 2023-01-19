// программа, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

Console.WriteLine("введите любое целое трехзначное число");
int number = int.Parse(Console.ReadLine()!);
int result = number % 100;
int and_result = result / 10;
Console.WriteLine($"{and_result} -вторая цифра от введенного числа.");
//  готово.
