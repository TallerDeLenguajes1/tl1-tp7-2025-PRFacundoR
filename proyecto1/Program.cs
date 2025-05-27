// See https://aka.ms/new-console-template for more information
using proyecto1;

Console.WriteLine("Hello, World!");


Calculadora calculadora = new Calculadora();

string Opcion,b;

do
{
    Console.WriteLine("Ingrese una de las siguientes operaciones, sumar, restar, dividir, multiplicar, o limpiar para limpiar el resultado si quiere salir escriba salir");
    Opcion = Console.ReadLine();

    Console.WriteLine("ingrese un numero");
    b = Console.ReadLine();

    if (double.TryParse(b, out double a))
    {
        switch (Opcion)
        {
            case "sumar":
                calculadora.Sumar(a);
                break;

            case "restar":
                calculadora.Restar(a);
                break;

            case "multiplicar":
                calculadora.Multiplicar(a);
                break;

            case "dividir":
                calculadora.Dividir(a);
                break;
                
            case "limpiar":
                calculadora.Limpiar();
                break;
        }
    }
    else
    {
        Console.WriteLine("ingrese un numero, no una letra");
    }

    Console.WriteLine("El resultado de la " + Opcion + " es " + calculadora.Resultado);

} while (Opcion != "salir");