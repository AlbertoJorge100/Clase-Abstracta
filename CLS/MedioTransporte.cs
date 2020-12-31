using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagenBytes.CLS
{
    public abstract class MedioTransporte
    {
        public enum Opcion {AUTOMOVIL, MOTOCICLETA, AUTOBUS};
        public abstract Opcion getOpcion();
    }
}
