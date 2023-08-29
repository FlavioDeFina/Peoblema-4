using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peoblema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alumnosA, alumnosB, alumnosC, minutosA, minutosB, minutosC, tiempototal, minutosRes, horas;
            Console.WriteLine("Ingrese la cantidad de alumnos que hay en el salon A: ");
            alumnosA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de alumnos que hay en el salon B: ");
            alumnosB = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de alumnos que hay en el salon C: ");
            alumnosC = int.Parse(Console.ReadLine());
            minutosA = alumnosA * 5;
            minutosB = alumnosB * 8;
            minutosC = alumnosC * 6;
            tiempototal = minutosA + minutosB + minutosC;
            horas = tiempototal / 60;
            minutosRes = tiempototal % 60;
            Console.WriteLine($"El instructor tardara {horas} horas y {minutosRes} minutos en revisar los examenes de todos los salones");
            Console.ReadKey();
        }
    }
}
