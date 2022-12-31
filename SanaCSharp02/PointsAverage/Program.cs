// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть 5 оцінок : ");

int q, w, e, r, t;


q = Convert.ToInt32(Console.ReadLine());
w = Convert.ToInt32(Console.ReadLine());
e = Convert.ToInt32(Console.ReadLine());
r = Convert.ToInt32(Console.ReadLine());
t = Convert.ToInt32(Console.ReadLine());

int y = (q + w + e + r + t) / 5;
Console.WriteLine("Середній бал : " + y);
if (y < 4)
{
    Console.WriteLine("Студент не допущений до екзамену");
}
else
{
    Console.WriteLine("Студент допущений до екзамену");
}