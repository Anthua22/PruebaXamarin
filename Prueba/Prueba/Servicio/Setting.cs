using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Servicio
{
    public class Setting
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public bool DarkMode { get; set; }


    }
}
