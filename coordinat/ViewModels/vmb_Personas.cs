using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modeloDato;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
namespace coordinat.ViewModels

{
   public class vmb_Personas: ViewModelBase
    {
        public List<mdb_Persona> ModeloPersonas { get; set; }
        public mdb_Persona PersonaActual { get; set; }

    }
}
