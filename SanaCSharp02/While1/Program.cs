// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Введіть n :");
int n=Convert.ToInt32(Console.ReadLine());
int i = 1;
double a=0;
while (i <= n)
{
     a = (Math.Pow((-1), 2)) / 2 * n + 1;
    i++;
}
Console.WriteLine("a : "+a);
i = 1;
double b = 0;
while (i <= n)
{
    b=1 + (1.0 / Math.Pow(n, 2));
    
    i++;
}

Console.WriteLine("b : "+b);
i=1;
int c = 0;
int l = 1; 
int f=0;
while (i <= n) {
    f = 1;
    while (l <= i)
    {
        f = f * l;
        l++;
    }
    c = c + f;
    l = 1;
    i++;

}
Console.WriteLine("c : " + c);
