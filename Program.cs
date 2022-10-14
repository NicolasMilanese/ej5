using System;
namespace ejercicio
{
class Program
{
static void Main (string[] args)
{
Console.Clear();

int num1,num2;
string numero1,numero2;

Console.WriteLine("Ingrese numero");
numero1= Console.ReadLine();
num1 = Convert.ToInt32 (numero1);
Console.WriteLine("Ingrese numero");
numero2 = Console.ReadLine();
num2 = Convert.ToInt32 (numero2);

if (num1>num2)
{
Console.WriteLine("El primer numero es mayor al segundo numero");
}
else
{
Console.WriteLine("El primer numero es menor al segundo numero");
}
}
}
}
