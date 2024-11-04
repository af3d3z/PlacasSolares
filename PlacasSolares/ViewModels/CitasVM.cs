using PlacasSolares.DAL;
using PlacasSolares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.ViewModels
{
    public class CitasVM
    {
        private List<Cita> _listaCitas;

        public List<Cita> ListaCitas {
            get { return _listaCitas; }
            set { _listaCitas = value; }
        }

        public CitasVM() {
            _listaCitas = ListadoCitas.GetCitas();
        }
    }
}
