// программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("введите любое целое число.");
int number = int.Parse(Console.ReadLine()!);
int result = number / 100;
int and_result = result % 10;
if (result <=0) Console.WriteLine("данное число третьей цифры не имеет.");
else
{
Console.WriteLine($"цифра- {and_result} является третьей цифрой числа {number}. ");
}
//  готово.