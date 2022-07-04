using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP7.Tabla_Colas.Clases
{
    public class Persona
    {
        public int id { get; set; }
        public Estado estado { get; set; }
        public Servidor servidor { get; set; }

        public double tiempo_fin_consumicion { get; set; }

        public double tiempo_fin_utilizacion_mesa { get; set; }

        public bool bandera_de_paso { get; set; }

        // Métricas
        public double minuto_entrada_cola_compra { get; set; }

        public double minuto_entrada_cola_entrega { get; set; }

        public double minuto_inicio_ocupacion_mesa { get; set; }





    }
}
