using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using coordinat.ViewModels;
using modeloDato;
using System.Collections.Generic;
using System;


// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace coordinat.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class vPersona : Page 
    {
       public vmb_Personas vm { get; set; }
       

        public vPersona()
        {
            this.InitializeComponent();
            //byte[] foto = null;
            ///// añado las personas para fase de pruebas, luego lo unire directamente con la bd
            //vm.ModeloPersonas = new List<mdb_Persona>
            //{
            //  new mdb_Persona("id","Carlos","Garcia","Fabra",1,"29189913s", DateTime.Now,true,"1234567899",1,10,false,false,false,false,false),
            //  new mdb_Persona("id","Carlos","Garcia","Fabra",1,"29189913s", DateTime.Now,true,"1234567899",1,10,false,false,false,false,false),
            //  new mdb_Persona("id","Carlos","Garcia","Fabra",1,"29189913s", DateTime.Now,true,"1234567899",1,10,false,false,false,false,false),
            //  new mdb_Persona("id","Carlos","Garcia","Fabra",1,"29189913s", DateTime.Now,true,"1234567899",1,10,false,false,false,false,false),
            //};
            //vm.PersonaActual = vm.ModeloPersonas[0];
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = vm;
        }
    }
}
