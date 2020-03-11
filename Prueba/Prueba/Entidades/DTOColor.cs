using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Prueba.Entidades
{
    public class DTOColor:INotifyPropertyChanged
    {
        string _name;

        public string Nombre
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                   // PropertyChanged("")
                }
            }
        }
        string _description;
        public string Descripcion { get; set; }

        public DTOColor(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

