    using System;
using Entidades;
using Interfaces;
using Negosio;
namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            // inyeccion de dependencias 
            //  fecha del video de clase = 12 de enero del 2021
            Console.WriteLine("Hello World!");
            IPersistencia persistencia = null; // deberia instanciarse 
           // IPersistencia  persistencia = new Persistencia2();
            Secretaria secretaria = new Secretaria(persistencia);
            Estudiante estudiante = new Estudiante("Steven", "Chinchin");
            Curso curso = new Curso("Programacion");
            secretaria.Matricular(estudiante, curso);
        }
    }

}
