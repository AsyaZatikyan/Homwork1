/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Bведите первое число");
String NumberOneStr = Console.ReadLine();
int NumberOne = Convert.ToInt32(NumberOneStr);

Console.WriteLine("Bведите второе число");
String NumberTwoStr = Console.ReadLine();
int NumberTwo = Convert.ToInt32(NumberTwoStr);

int max = NumberOne;
if (NumberOne > max) max = NumberOne;
if (NumberTwo > max) max = NumberTwo;

Console.Write("max = ");
Console.WriteLine(max);
