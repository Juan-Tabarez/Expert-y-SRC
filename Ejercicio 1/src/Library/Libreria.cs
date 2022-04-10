using System;
using System.Collections.Generic;

namespace SRP
{
    public class Libreria
    {
        public Dictionary<Libro, string> ubicacionesDeLibros { get;}
    
        public Libreria(Dictionary<Libro, string> ubicaciones)
        {
            this.ubicacionesDeLibros = ubicaciones;
        }
        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            this.ubicacionesDeLibros.Add(libro, sector+estante);
        }
    } 
}