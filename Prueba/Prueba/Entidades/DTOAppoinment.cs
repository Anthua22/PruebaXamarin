using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Entidades
{
    public class DTOAppoinment
    {
        public string Header { get; set; }
        public string Detail { get; set; }

        private string poblation, postal_code;
        public string address { get; set; }
        public string province { get; set; }
        private DateTime fecha;

        public DTOAppoinment(string address, string poblation, string postal_code, string province, DateTime fecha)
        {
            this.address = address;
            this.fecha = fecha;
            this.poblation = poblation;
            this.province = province;
            this.postal_code = postal_code;
        }
        public DTOAppoinment(string address, string poblation, string postal_code, string province)
        {
            this.address = address;
            this.poblation = poblation;
            this.postal_code = postal_code;
            this.province = province;
        }

        public void TemplatePicker()
        {
            Header = this.address + ", " + postal_code + ", " + province + ", " + poblation;
            if(this.fecha != null)
            {
                Detail = "Fecha: " + fecha.ToShortDateString();
            }
        }
    }
}
