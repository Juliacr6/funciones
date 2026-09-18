using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_SEMANA4
{
    internal class Program
    {
        static public void ejercicio4()
        {
            Console.Write("Ingrese el numero N de alumnos: ");
            int n = int.Parse(Console.ReadLine());

            double[] notas = new double[n];
            double suma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
                suma = suma + notas[i];
            }

            double promedio = suma / n;
            double maxima = notas[0];
            double minima = notas[0];

            for (int i = 0; i < n; i++)
            {
                if (notas[i] > maxima)
                {
                    maxima = notas[i];
                }
                if (notas[i] < minima)
                {
                    minima = notas[i];
                }
            }
            Console.WriteLine("Promedio de notas: " + promedio);
            Console.WriteLine("La maxima nota: " + maxima);
            Console.WriteLine("La minima nota: " + minima);
        }

        static public void ejercicio5()
        {
            Console.Write("Ingrese el numero N de alumnos (maximo 10): ");
            int n = int.Parse(Console.ReadLine());
            double[] notas = new double[n];
            int cantCeros = 0;
            int cantVeintes = 0;
            int aprobados = 0;
            int desaprobados = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
                if (notas[i] == 0)
                {
                    cantCeros++;
                }
                if (notas[i] == 20)
                {
                    cantVeintes++;
                }
                if (notas[i] >= 13)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }
            Console.WriteLine("Cantidad de personas que obtuvieron 00: " + cantCeros);
            Console.WriteLine("Cantidad de personas que obtuvieron 20: " + cantVeintes);
            Console.WriteLine("Cantidad de personas aprobadas: " + aprobados);
            Console.WriteLine("Cantidad de personas desaprobadas: " + desaprobados);
        }

        static void Main(string[] args)
        {
            ejercicio4();
            ejercicio5();
            Console.ReadKey();
        }
    }
}
