// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Введіть а :");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть b :");
int b= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть c :");
int c= Convert.ToInt32(Console.ReadLine());
double D = (b*b)-4*a*c;
Console.WriteLine(D);
if (D > 0)
{
    double x1 = (-b + Math.Pow(D, 1.0 / 2)) / (2.0 * a);
    double x2 = (-b - Math.Pow(D, 1.0 / 2)) / (2.0 * a);
    Console.WriteLine("D>0");
    Console.WriteLine("x1 :");
    Console.WriteLine(x1);
    Console.WriteLine("x2 :");
    Console.WriteLine(x2);
}
else if (D == 0)
{
    double x = (-b) / 2.0 * a;
    Console.WriteLine("D=0 \nx :");
    Console.WriteLine(x);
} 
else
{
    Console.WriteLine("Коренів не існує");
}
