using System.Net.Http.Json;
using System;

using var client = new HttpClient();
// Reemplace el puerto con el que asigne Visual Studio 
client.BaseAddress = new Uri("https://localhost:7199/");

Console.WriteLine("--- CLIENTE CALCULADORA REST ---");

try
{
    // Datos de prueba similares a MathClient2 
    float n1 = 20f;
    float n2 = 2f;

    // Ejecución de operaciones mediante peticiones GET
    var suma = await client.GetStringAsync($"sumar?a={n1}&b={n2}");
    Console.WriteLine($"{n1} + {n2} = {suma}"); 

    var resta = await client.GetStringAsync($"restar?a={n1}&b={n2}");
    Console.WriteLine($"{n1} - {n2} = {resta}");

    var mult = await client.GetStringAsync($"multiplicar?a={n1}&b={n2}");
    Console.WriteLine($"{n1} * {n2} = {mult}"); 

    var div = await client.GetStringAsync($"dividir?a={n1}&b={n2}");
    Console.WriteLine($"{n1} / {n2} = {div}"); 
}
catch (Exception ex)
{
    Console.WriteLine($"Error de comunicación: {ex.Message}");
}
