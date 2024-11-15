﻿using Tyuiu.GizatullinAP.Sprint3.Task6.V5.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Гизатуллин А. П. | ИСПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #6                                                           *");
Console.WriteLine("* Вариант #5                                                           *");
Console.WriteLine("* Выполнил Гизатуллин Артём Павлович | ИСПб-24-1                       *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих    *");
Console.WriteLine("* числовому отрезку [15, 22] количество всех делителей                 *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int startValue = 15, stopValue = 22;
int res = ds.GetSumTheDivisors(startValue, stopValue);
Console.WriteLine("************************************************************************");
Console.WriteLine(res);
Console.ReadLine();