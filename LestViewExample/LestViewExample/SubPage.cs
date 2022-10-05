using System;
using System.Collections.Generic;
using System.Text;

namespace LestViewExample
{
    public class SubPage : List<Model>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string SegundoNombre { get; set; }
        public SubPage(string nombre, string segundoNombre)
        {
            Nombre = nombre;
            SegundoNombre = segundoNombre;
        }
        public static IList<SubPage> All { private set; get; }
        static SubPage()
        {
            List<SubPage> Groups = new List<SubPage>
            {
                new SubPage("Mecanica", "A")
                {
                    new Model("Melany", "Kiabeth"),
                    new Model("Josue", "Gomez"),
                    new Model("Liam", "Martinez"),
                },
                new SubPage("Videojuegos", "B")
                {
                    new Model("Rosa", "Lopez"),
                    new Model("Tania", "Gutierrez"),
                    new Model("Blanca", "Molina"),
                }
            };
            All = Groups;
        }
    }
}
