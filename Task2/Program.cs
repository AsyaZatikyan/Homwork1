/*
Задача 4: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Bведите первое число");
String NumberOneStr = Console.ReadLine();
int NumberOne = Convert.ToInt32(NumberOneStr);

Console.WriteLine("Bведите второе число");
String NumberTwoStr = Console.ReadLine();
int NumberTwo = Convert.ToInt32(NumberOneStr);

Console.WriteLine("Bведите третье число");
String NumberThirdStr = Console.ReadLine();
int NumberThird = Convert.ToInt32(NumberThirdStr);

int max = NumberOne;
if (NumberOne > max) max = NumberOne;
if (NumberTwo > max) max = NumberTwo;
if (NumberThird > max) max = NumberThird;

Console.Write("max = ");
Console.WriteLine(max);