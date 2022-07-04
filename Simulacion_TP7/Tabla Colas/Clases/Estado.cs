using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP7.Tabla_Colas.Clases
{
    public enum Estado
    {
        esperando_compra = 0,
        comprando_ticket = 1,
        esperando_entrega = 2,
        recibiendo_pedido = 3,
        consumiendo_pedido = 4,
        utilizando_mesa = 5,
        libre = 6,
        ocupado = 7,
        destruccion = 8

    }
}
