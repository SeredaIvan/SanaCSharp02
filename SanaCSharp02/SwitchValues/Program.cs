﻿// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Введіть число від 0 до 9");
int r =Convert.ToInt32(Console.ReadLine());

switch (r)
{

    case 0:
        Console.WriteLine("нуль");
        break;
    case 1:
        Console.WriteLine("один");
        break ;
    case 2:
        Console.WriteLine("два");
        break;
    case 3:
        Console.WriteLine("три");
        break;
    case 4:
        Console.WriteLine("чотири");
        break;
    case 5:
        Console.WriteLine("п'ять");
        break;
    case 6:
        Console.WriteLine("шість");
        break;
    case 7:
        Console.WriteLine("сім");
        break;
    case 8:
        Console.WriteLine("вісім");
        break;
    case 9:
        Console.WriteLine("дев'ять");
        break;
    default:
        Console.WriteLine("Error");
        break;  



}
