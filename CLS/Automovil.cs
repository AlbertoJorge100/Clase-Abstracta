using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagenBytes.CLS
{
    public class Automovil : MedioTransporte
    {
        private String Marca="Toyota";

        public String getMarca()
        {
            return this.Marca;
        }
        
        public override Opcion getOpcion()
        {
            return Opcion.AUTOMOVIL;
        }
    }
}
