//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write ("Введите значение a: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write ("Введите значение b: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine ("Число A больше числа B, max = " + numberA);
}

else
{
    Console.WriteLine ("Число B больше числа A, max = " + numberB);
}