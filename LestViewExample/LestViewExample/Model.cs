using System;
using System.Collections.Generic;
using System.Text;

namespace LestViewExample
{
    public class Model
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Model(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
