using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.Models
{
    public class Cita
    {
        #region atributos
        private int _id;
        private string _descripcion;
        private string _direccion;
        private DateTime _fecha;
        private string _duenio;
        #endregion

        #region propiedades
        public int Id
        {
            get { return _id; }
        }

        public string Descripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string Direccion {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Duenio { 
            get { return _duenio; }
        }

        public DateTime Fecha {
            get { return _fecha;  }
            set { _fecha = value; }
        }

        #endregion

        #region constructores
        public Cita(int id, string descripcion, string direccion, DateTime fecha, string duenio) {
            this._id = id;
            this._descripcion = descripcion;
            this._direccion = direccion;
            this._fecha = fecha;
            this._duenio = duenio;
        }

        #endregion
    }
}
