﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());// ToInt32-Преобразует заданное значение в 32-битовое целое число со знаком
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)// условия сравнения если num1>num2 
{
    Console.WriteLine($"первое число= {num1} больше второго числа= {num2}");// если true выводиться надпись 
}
else
{
    Console.WriteLine($"второе число={num2} больше первого числа= {num1}");// если false выводиться надпись
}
