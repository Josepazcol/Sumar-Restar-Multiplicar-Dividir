using Sumar__Restar__Multiplicar__Dividir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumar__Restar__Multiplicar__Dividir
{
    public class OperacionesBasicas
    {
        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancia de la clase OperacionesBasicas
        OperacionesBasicas operaciones = new OperacionesBasicas();

        // Pedir los dos números al usuario
        Console.WriteLine("Introduzca el primer número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca el segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        // Mostrar el resultado de cada operación
        Console.WriteLine("Suma: " + operaciones.Sumar(num1, num2));
        Console.WriteLine("Resta: " + operaciones.Restar(num1, num2));
        Console.WriteLine("Multiplicación: " + operaciones.Multiplicar(num1, num2));
        Console.WriteLine("División: " + operaciones.Dividir(num1, num2));
    }
}
