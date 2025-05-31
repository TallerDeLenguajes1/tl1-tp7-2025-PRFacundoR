// See https://aka.ms/new-console-template for more information
using SisPersonal;

Console.WriteLine("Hello, World!");


Empleado[] empleados =
[
    new Empleado("Pérez", "Juan", new DateTime(1980, 5, 12), 'S', new DateTime(2010, 3, 1), 50000,Cargos.Administrativo),
    new Empleado("Pepe", "Juan", new DateTime(1980, 5, 12), 'C', new DateTime(2010, 3, 1), 650000, Cargos.Ingeniero),
    new Empleado("Gómez", "Lucía", new DateTime(1990, 8, 25), 'C', new DateTime(2015, 7, 10), 720000, Cargos.Administrativo),
];

for (int i = 0; i < empleados.Length; i++)
{
    Empleado e = empleados[i];

    Console.WriteLine("Empleado #" + (i + 1));
    Console.WriteLine("Nombre completo: " + e.Nombre + " " + e.Apellido);

    DateTime hoy = DateTime.Now;

    int edad = e.Edad(hoy);
    int antiguedad = e.Antiguedad(hoy);
    int edadFaltanteJubilacion = e.EdadfaltanteJubi(edad);

    Console.WriteLine("Edad: " + edad);
    Console.WriteLine("Antigüedad: " + antiguedad);
    Console.WriteLine("Años para jubilarse: " + edadFaltanteJubilacion);
    Console.WriteLine("Salario: " + e.Salario(hoy,e.SueldoB1,e.Cargos,e.EstadoCivil));
    // Para calcular salario necesitamos pasar los parámetros requeridos
    // SueldoB ya lo tiene como propiedad, así que lo usamos
    // También usamos el cargo y estado civil del empleado
    e.Salario(hoy, e.SueldoB1, e.Cargos, e.EstadoCivil);

    Console.WriteLine(); // Línea en blanco entre empleados
}