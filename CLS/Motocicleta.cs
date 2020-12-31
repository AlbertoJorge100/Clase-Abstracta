using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagenBytes.CLS
{
    class Motocicleta:MedioTransporte
    {
        private String Marca = "Yamaha";

        public String getMarca()
        {
            return this.Marca;
        }

        public override Opcion getOpcion()
        {
            return Opcion.MOTOCICLETA;
        }
    }
}
