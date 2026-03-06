// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escriba un programa que implemente un menú que se repita hasta que el usuario elija la opción de salir.");

string opcion;
int numero;
int suma = 0;
int contador = 0;

do
{
    Console.WriteLine("MENU");
    Console.WriteLine("1. Ingresar número");
    Console.WriteLine("2. Mostrar resultados");
    Console.WriteLine("0. Salir");
    Console.WriteLine("Seleccione una opción: ");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            suma += numero;
            contador++;
            break;

        case "2":
            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine("Suma total: " + suma);
                Console.WriteLine("Cantidad de números: " + contador);
                Console.WriteLine("Promedio: " + promedio);
            }
            else
            {
                Console.WriteLine("No se han ingresado números");
            }
            break;

        case "0":
            Console.WriteLine("Programa finalizado");
            break;
    }

} while (opcion != "0");
