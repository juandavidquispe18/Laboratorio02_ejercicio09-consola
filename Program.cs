// See https://aka.ms/new-console-template for more information
//Ingresar datos
Console.WriteLine("Ingrese 3 números enteros diferentes: ");

Console.Write("Numero 1: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Numero 2: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Numero 3: ");
int numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
{
    //Mostrar resultados
    int mayor = Math.Max(numero1, Math.Max(numero2, numero3));
    Console.WriteLine($"El mayor de los 3 números es: {mayor}");
}
else 
{
    Console.WriteLine("Error: Los 3 números ingresados tienen que ser diferentes.");
}
Console.ReadKey();



