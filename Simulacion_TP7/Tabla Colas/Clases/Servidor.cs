using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP7.Tabla_Colas.Clases
{
    public class Servidor
    {
        public int id { get; set; }
        public Estado estado { get; set; }
        public int tipoServidor { get; set; }

        public double tiempoOcupado { get; set; }
    }
}
