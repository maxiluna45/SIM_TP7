using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP7.Tabla_Colas.Clases
{
    public class VectorEstado
    {
        public double reloj { get; set; }
        public Evento evento { get; set; }
        public double rnd1_llegada { get; set; }
        public double rnd2_llegada { get; set; }
        public double tiempo_llegada { get; set; }
        public double tiempo_prox_llegada { get; set; }

        public double rnd_accion { get; set; }
        public int accion { get; set; }
        public double rnd_mesa { get; set; }
        public bool ocupa_mesa { get; set; }
        public double fin_compra_ticket { get; set; }
        public double rnd_entrega_pedido { get; set; }
        public double tiempo_entrega_pedido { get; set; }
        public double rnd_tipo_pedido { get; set; }
        public int tipo_pedido { get; set; }

        public double tiempo_preparacion_pedido { get; set; }
        public List<double> tiempo_fin_entrega_pedido { get; set; }

        public double rnd_tiempo_consumision_pedido { get; set; }
        public double tiempo_consumicion_pedido { get; set; }
        public double fin_consumision_pedido { get; set; }
        public double rnd_tiempo_ocupacion_mesa { get; set; }
        public double tiempo_ocupacion_mesa { get; set; }
        public double fin_ocupacion_mesa { get; set; }

        public List<Persona> cola_caja { get; set; }
        public Servidor caja { get; set; }

        public List<Persona> cola_entrega_pedido { get; set; }
        public List<Servidor> empleados { get; set; }

        public List<Persona> personas { get; set; }

        public List<Persona> personas_ocupando_mesa { get; set; }

        // Métricas -----------------------------------------------


        //Métrica 1
        public double porc_ocupacion_caja { get; set; }
        public double porc_ocupacion_empleado1 { get; set; }
        public double porc_ocupacion_empleado2 { get; set; }

        // Métrica 2
        public double tiempoPermanenciaColaCompra { get; set; }

        public double tiempoPermanenciaColaEntrega { get; set; }

        // Métrica 3
        public double personas_promedio_utilizando_mesa { get; set; }

        // Métrica 4

        public double porc_personas_ocupan_mesa_consumiendo { get; set; }
    }
}
