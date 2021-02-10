using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Model
{
    public class Auto
    {
        public int IdAuto { get; set; }
        public string Descripcion { get; set; }
        public int Sku{ get; set; }
        public int Cantidad { get; set; }
        public Marca Marca { get; set; }

    }
}