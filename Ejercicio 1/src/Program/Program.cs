using System;
using System.Collections.Generic;

namespace SRP
{   
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Dictionary<Libro,string> ubicacion = new Dictionary<Libro, string>();
            Libreria Biblioteca = new Libreria(ubicacion);
            Biblioteca.AlmacenarLibro(libro1,"A","7");
            Biblioteca.AlmacenarLibro(libro2,"B","4");
            Console.WriteLine("La ubicacion del libro en la biblioteca es: "+Biblioteca.ubicacionesDeLibros[libro1]);
        }
    }
}
