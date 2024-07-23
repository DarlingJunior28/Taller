using System;
using System.Collections.Generic;
using System.Linq;

public class Estudiantes
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public static void Main()
    {
        List<Estudiantes> estudiantes = new List<Estudiantes>
        {
            new Estudiantes { Id = 1, Nombre = "Juan", Edad = 20 },
            new Estudiantes { Id = 2, Nombre = "Carlos", Edad = 22 },
            new Estudiantes { Id = 3, Nombre = "Manuel", Edad = 19 },
            new Estudiantes { Id = 4, Nombre = "Perla", Edad = 21 }
        };

        var estudiantesOrdenados = from estudiante in estudiantes
                                   orderby estudiante.Nombre
                                   select estudiante;

        Console.WriteLine("\nEstudiantes Ordenados por Nombre:");
        foreach (var estudiante in estudiantesOrdenados)
        {
            Console.WriteLine(estudiante.Nombre);
        }
    }
}
