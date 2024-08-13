// See https://aka.ms/new-console-template for more information
using System;
class Program
{
static void Main()
{
// Mostrar un título en la consola
Console.WriteLine("Bienvenido a mi primera aplicación en C#!");
// Solicitar al usuario su nombre
Console.Write("Por favor, ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine($"Hola, {nombre}! Gracias por usar esta aplicación.");

Console.WriteLine("Presione cualquier tecla para salir.");
Console.ReadKey();
}
}