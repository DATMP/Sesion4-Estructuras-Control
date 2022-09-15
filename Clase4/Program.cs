// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Reyner!");

int nNumero = 0;
Console.WriteLine("ingrese un numero");
nNumero = int.Parse(Console.ReadLine());

if (nNumero > 12)
    Console.WriteLine("El numero es mayor a 12");
else
    Console.WriteLine("El numero es menor o igual a 12");
Thread.Sleep(9000);