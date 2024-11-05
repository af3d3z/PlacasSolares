using PlacasSolares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.ViewModels
{
    public class DetallesVM
    {
        private Cita _citaDetalles;
        
        public Cita CitaDetalles
        {
            get { return _citaDetalles; }
        }

        public DetallesVM() {
            _citaDetalles = new Cita(1, "Tanque roto", "C\\ Maria Teresa 32", new DateTime(2024, 11, 19, 8, 1, 0), "Carlos Pérez");
        }
    }
}
