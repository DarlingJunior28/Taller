using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerLINQ
{
    public class Class1
    {
        static void Main()
        {
            // Definir una lista de números
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};
            // Consulta LINQ para obtener números pares
            var numerosPares = from numero in numeros
                               where numero % 2 == 0
                               select numero;
            // Mostrar resultados
            Console.WriteLine("Números Pares:");
            foreach (var numero in numerosPares)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
