using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LestViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ListViewGroup()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e) 
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
            this.GroupedView.ItemsSource = Groups;
        }
    }
}