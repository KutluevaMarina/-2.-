﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*6 -> да
7 -> да
1 -> нет*/
/*bool main (int num)
{
    if (num == 6 || num == 7)
    {
        return true;
    }
    else{
        return false;
    }
}
Console.WriteLine($"{main(5)}");*/

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
/*int CutNumber(int num)
{
    int res = (num / 10 % 10);
    return res;
}
Console.WriteLine($" {CutNumber(456)}");*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
/*int ThirdDigit (int num)
{
    if (num >=100)
    {
        while (num > 999)
        {
            num = num /10;
        }
    }
    int res = num % 10;
    return res;
}
int random = new Random().Next(100,1000);
int newNumber = ThirdDigit(random);
Console.WriteLine($"New version of {random} is {newNumber}");*/