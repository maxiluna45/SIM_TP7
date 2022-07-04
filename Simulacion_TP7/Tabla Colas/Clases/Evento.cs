using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP7.Tabla_Colas.Clases
{
    public enum Evento
    {
        llegada_persona = 0,
        fin_compra_ticket = 1,
        fin_entrega_pedido1 = 2,
        fin_entrega_pedido2 = 3,
        fin_consumision = 4,
        fin_utilizacion_mesa = 5,
        inicializacion = 6
    }
}
