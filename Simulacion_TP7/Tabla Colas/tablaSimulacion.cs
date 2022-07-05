using Simulacion_TP7.Tabla_Colas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulacion_TP7.Runge_Kutta;

namespace Simulacion_TP7.Tabla_Colas
{
    public partial class tablaSimulacion : Form
    {
        public decimal iteraciones;
        public decimal cant_filas;
        public decimal fila_desde;
        public decimal media;
        public decimal desviacion;
        public decimal tiempo_compra;
        public decimal tiempo_entrega;
        public decimal inf_consumision;
        public decimal sup_consumision;
        public decimal inf_utilizacion;
        public decimal sup_utilizacion;
        public string pathFile;
        public bool flag;
        public double N1;
        public double N2;
        public double rnd1;
        public double rnd2;
        public double reloj_anterior;
        //private double diferencia_horaria;
        public int columas_a_agregar_AC;
        public List<int> lista_ids;
        public Persona persona_de_paso;

        public tablaSimulacion(decimal _iteraciones, decimal _cant_filas, decimal _fila_desde, decimal _media, decimal _desviacion, decimal _tiempo_compra, decimal _tiempo_entrega, decimal _inf_consumision, decimal _sup_consumision, decimal _inf_utilizacion, decimal _sup_utilizacion)
        {
            InitializeComponent();
            iteraciones = _iteraciones;
            cant_filas = _cant_filas;
            fila_desde = _fila_desde;
            media = _media/60;
            desviacion = _desviacion/60;
            tiempo_compra = _tiempo_compra;
            tiempo_entrega = _tiempo_entrega;
            inf_consumision = _inf_consumision;
            sup_consumision = _sup_consumision;
            inf_utilizacion = _inf_utilizacion;
            sup_utilizacion = _sup_utilizacion;
            flag = false;

            columas_a_agregar_AC = 0;
            lista_ids = new List<int>();

        }

        private void tablaSimulacion_Load(object sender, EventArgs e)
        {
            borrarArchivos();
            simular();
        }

        private void simular()
        {
            int cant_personas_actual = 0;

            // Contador de id para personas

            int contador_id_persona = 1;

            // Bandera para mostrar o no los Runge Kutta
            bool flag = false;

            // Variables que se asignan con los resultados de Runge Kutta

            double resultado_cafe = 0;
            double resultado_cafe_medialunas = 0;
            double resultado_menu = 0;

            // Contadores y acumuladores para métricas

            double diferencia_horaria = 0;

            int cant_personas_llegaron_caja = 0;
            double acum_permanencia_cola_compra = 0;

            int cant_personas_llegaron_empleado = 0;
            double acum_permanencia_cola_entrega = 0;

            double acum_tiempo_ocupando_mesa = 0;

            int contador_personas_total_ocupan_mesa = 0;
            int contador_personas_consumen_ocupan_mesa = 0;

            // Creo un generador de semillas para los otros generadores, caso contrario todos generarán los mismos random, porque los estamos instanciando al mismo tiempo
            var genSemillas = new Random();

            // Se instancias los generadores y se calculan los rnd iniciales
            var genLlegada = new Random((genSemillas.Next()));
            var genAccion = new Random((genSemillas.Next()));
            var genOcupaMesa = new Random((genSemillas.Next()));
            var genEntregaPedido = new Random((genSemillas.Next()));
            var genTipoPedido = new Random((genSemillas.Next()));
            var genTiempoConsumision = new Random((genSemillas.Next()));

            var resultados = generarRNDNormal(genLlegada, (double)this.media, (double)this.desviacion);

            // Se crea la fila inicial

            var fila_anterior = new VectorEstado();
            fila_anterior.reloj = 0;
            fila_anterior.evento = Evento.inicializacion;
            fila_anterior.rnd1_llegada = resultados[0];
            fila_anterior.rnd2_llegada = resultados[1];
            fila_anterior.tiempo_llegada = resultados[2];
            fila_anterior.tiempo_prox_llegada = fila_anterior.reloj + fila_anterior.tiempo_llegada;
            fila_anterior.rnd_accion = 0;
            fila_anterior.accion = -1;
            fila_anterior.rnd_mesa = 0;
            fila_anterior.ocupa_mesa = false;
            fila_anterior.fin_compra_ticket = 0;
            fila_anterior.rnd_entrega_pedido = 0;
            fila_anterior.tiempo_entrega_pedido = 0;
            fila_anterior.rnd_tipo_pedido = 0;
            fila_anterior.tipo_pedido = 0;
            fila_anterior.tiempo_preparacion_pedido = 0;
            fila_anterior.tiempo_fin_entrega_pedido = new List<double> (new double[2]);
            fila_anterior.rnd_tiempo_consumision_pedido = 0;
            fila_anterior.tiempo_consumicion_pedido = 0;
            fila_anterior.fin_consumision_pedido = 0;
            fila_anterior.rnd_tiempo_ocupacion_mesa = 0;
            fila_anterior.tiempo_ocupacion_mesa = 0;
            fila_anterior.fin_ocupacion_mesa = 0;
            fila_anterior.cola_caja = new List<Persona>();
            fila_anterior.cola_entrega_pedido = new List<Persona>();
            fila_anterior.personas = new List<Persona>();
            fila_anterior.personas_ocupando_mesa = new List<Persona>();

            // Métricas
            fila_anterior.porc_ocupacion_caja = 0;

            //Servidores
            fila_anterior.caja = new Servidor() {
                id = 0,
                estado = Estado.libre,
                tipoServidor = 0,
                tiempoOcupado = 0
            };

            fila_anterior.empleados = new List<Servidor>();

            var empleado1 = new Servidor()
            {
                id = 1,
                estado = Estado.libre,
                tipoServidor = 1,
                tiempoOcupado = 0
            };

            var empleado2 = new Servidor()
            {
                id = 2,
                estado = Estado.libre,
                tipoServidor = 1,
                tiempoOcupado = 0
            };

            fila_anterior.empleados.Add(empleado1);
            fila_anterior.empleados.Add(empleado2);

            cant_personas_actual = imprimirFila(fila_anterior, cant_personas_actual);

            // Se crea la fila actual

            var fila_actual = new VectorEstado();

            // Iteraciones

            for (var i = 0; i < this.iteraciones; i++) {

                reloj_anterior = fila_anterior.reloj;
                

                // Según la fila anterior, se calcula el próximo evento
                var proximoReloj = calcularProximoReloj(fila_anterior.tiempo_prox_llegada, fila_anterior.fin_compra_ticket, fila_anterior.tiempo_fin_entrega_pedido[0], fila_anterior.tiempo_fin_entrega_pedido[1], fila_anterior.personas_ocupando_mesa);
                fila_actual.reloj = proximoReloj[0];
                fila_actual.evento = (Evento) proximoReloj[1];

                // Calculo la diferencia horaria entre iteraciones (se utiliza para las métricas)
                diferencia_horaria = fila_actual.reloj - reloj_anterior;


                // Se arrastran los valores anteriores para modificarlos

                fila_actual.tiempo_prox_llegada = fila_anterior.tiempo_prox_llegada;
                fila_actual.fin_compra_ticket = fila_anterior.fin_compra_ticket;
                fila_actual.tiempo_fin_entrega_pedido = fila_anterior.tiempo_fin_entrega_pedido;
                fila_actual.cola_caja = fila_anterior.cola_caja;
                fila_actual.cola_entrega_pedido = fila_anterior.cola_entrega_pedido;
                fila_actual.caja = fila_anterior.caja;
                fila_actual.empleados = fila_anterior.empleados;
                fila_actual.personas = fila_anterior.personas;
                fila_actual.personas_ocupando_mesa = fila_anterior.personas_ocupando_mesa;

                // Cálculo de métricas de ocupación (se calculan aquí ya que necesitan conocer estados de la fila actual antes de que se arrastren los de la anterior) ------------------------------------------------------------------------

                fila_actual.porc_ocupacion_caja = fila_anterior.porc_ocupacion_caja;

                // Se calcula % de ocupacion de la caja, para ello calculo el tiempo ocupado de la caja (Métrica 1)

                if (fila_anterior.caja.estado == Estado.ocupado)
                {
                    var sumar = diferencia_horaria;
                    fila_actual.caja.tiempoOcupado += sumar;
                }
                fila_actual.porc_ocupacion_caja = (fila_actual.caja.tiempoOcupado / fila_actual.reloj) * 100;


                // Se calcula % de ocupacion de los empleados, para ello calculo el tiempo ocupado de cada uno (Métrica 1)

                if (fila_anterior.empleados[0].estado == Estado.ocupado)
                {
                    var sumar1 = diferencia_horaria;
                    fila_actual.empleados[0].tiempoOcupado += sumar1;
                }
                fila_actual.porc_ocupacion_empleado1 = (fila_actual.empleados[0].tiempoOcupado / fila_actual.reloj) * 100;



                if (fila_anterior.empleados[1].estado == Estado.ocupado)
                {
                    var sumar2 = diferencia_horaria;
                    fila_actual.empleados[1].tiempoOcupado += sumar2;
                }
                fila_actual.porc_ocupacion_empleado2 = (fila_actual.empleados[1].tiempoOcupado / fila_actual.reloj) * 100;

                // Fin de métricas -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                // Reinicio las columnas que no deben arrastrarse
                fila_actual.accion = -1;
                fila_actual.rnd_accion = 0;
                fila_actual.tiempo_consumicion_pedido = 0;
                fila_actual.fin_consumision_pedido = 0;
                fila_actual.rnd_tiempo_consumision_pedido = 0;
                fila_actual.tiempo_ocupacion_mesa = 0;
                fila_actual.fin_ocupacion_mesa = 0;
                fila_actual.rnd_tiempo_ocupacion_mesa = 0;
                fila_actual.rnd_tipo_pedido = 0;
                fila_actual.tipo_pedido = 0;
                fila_actual.rnd_mesa = 0;
                fila_actual.ocupa_mesa = false;
                fila_actual.rnd1_llegada = 0;
                fila_actual.rnd2_llegada = 0;
                fila_actual.tiempo_llegada = 0;
                fila_actual.rnd_entrega_pedido = 0;
                fila_actual.tiempo_entrega_pedido = 0;
                fila_actual.tiempo_preparacion_pedido = 0;

                // Bandera para saber si debo generar o no el excel de Runge Kutta

                if (((i >= this.fila_desde - 1 && i < this.fila_desde + this.cant_filas - 1) || (i == this.iteraciones - 1 && this.iteraciones != this.fila_desde + this.cant_filas - 1)))
                    flag = true;
                else
                    flag = false;
                    

                // Eventos --------------------------------------------------------------------------------------------------------------------------------

                //Evento llegada persona

                if (fila_actual.evento == Evento.llegada_persona)
                {

                    //Creo la persona que llega
                    var persona = new Persona()
                    {
                        id = contador_id_persona,
                        tiempo_fin_consumicion = 0,
                        tiempo_fin_utilizacion_mesa = 0,
                        bandera_de_paso = false,
                        minuto_entrada_cola_compra = 0,
                        minuto_entrada_cola_entrega = 0,
                        minuto_inicio_ocupacion_mesa = 0

                    };
                    contador_id_persona++;

                    // Calculo la próxima llegada
                    var proximaLlegada = generarRNDNormal(genLlegada, (double)this.media, (double)this.desviacion);
                    fila_actual.tiempo_llegada = proximaLlegada[2];
                    fila_actual.rnd1_llegada = proximaLlegada[0];
                    fila_actual.rnd2_llegada = proximaLlegada[1];
                    fila_actual.tiempo_prox_llegada = fila_actual.reloj + fila_actual.tiempo_llegada;

                    // Agrego a la nueva persona a la lista de personas del sistema
                    fila_actual.personas.Add(persona);

                    // Calculo la accion que va a realizar la persona

                    fila_actual.rnd_accion = genAccion.NextDouble();
                    fila_actual.accion = obtenerAccion(fila_actual.rnd_accion);

                    if (fila_actual.accion == (int)Accion.compra)
                    {
                        // La persona viene a comprar

                        if (fila_actual.caja.estado == Estado.libre)
                        {
                            // Cambio el estado de la persona a comprando ticket, le asigno el servidor, y le cambio el estado de la caja a ocupado
                            persona.estado = Estado.comprando_ticket;
                            persona.servidor = fila_actual.caja;
                            fila_actual.caja.estado = Estado.ocupado;

                            // Se calcula el tiempo de fin de compra
                            fila_actual.fin_compra_ticket = fila_actual.reloj + ((double)this.tiempo_compra/60);

                        }
                        else
                        {
                            // La caja está ocupada, pongo estado de persona en esperando compra y la añado a la cola de la caja
                            persona.estado = Estado.esperando_compra;
                            fila_actual.cola_caja.Add(persona);

                            // Métricas
                            persona.minuto_entrada_cola_compra = fila_actual.reloj;

                        }
                    }
                    else if (fila_actual.accion == (int)Accion.utiliza_mesa)
                    {
                        // La persona viene a ocupar una mesa sin comprar nada
                        persona.estado = Estado.utilizando_mesa;
                        fila_actual.personas_ocupando_mesa.Add(persona);
                        persona.minuto_inicio_ocupacion_mesa = fila_actual.reloj;

                        // Métricas
                        contador_personas_total_ocupan_mesa++;

                        // Genero el tiempo de fin de ocupacion de mesa
                        fila_actual.rnd_tiempo_ocupacion_mesa = genOcupaMesa.NextDouble();
                        fila_actual.tiempo_ocupacion_mesa = generarRNDUniforme(fila_actual.rnd_tiempo_ocupacion_mesa, this.inf_utilizacion, this.sup_utilizacion);
                        fila_actual.fin_ocupacion_mesa = fila_actual.tiempo_ocupacion_mesa + fila_actual.reloj;
                        persona.tiempo_fin_utilizacion_mesa = fila_actual.fin_ocupacion_mesa;
                    }
                    else
                    {
                        // La persona sólo está de paso, no compra ni ocupa una mesa
                        persona.estado = Estado.destruccion;
                        persona.bandera_de_paso = true;
                        this.persona_de_paso = persona;
                    }


                }
                // Evento fin de compra de ticket
                else if (fila_actual.evento == Evento.fin_compra_ticket)
                {
                    // Métricas
                    cant_personas_llegaron_caja++;

                    // Pongo el fin de compra de ticket en 0, obtengo la persona que compró el ticket y pongo su servidor en null
                    fila_actual.fin_compra_ticket = 0;
                    Persona persona_a_entregar = obtenerPersona(fila_actual.personas, 0);
                    persona_a_entregar.servidor = null;

                    // Observo si hay empleados libres para la entrega del pedido

                    int idServidorLibre = ServidorLibre(fila_actual.empleados);

                    // No hay empleados libres
                    if (idServidorLibre == -1)
                    {
                        fila_actual.cola_entrega_pedido.Add(persona_a_entregar);
                        persona_a_entregar.estado = Estado.esperando_entrega;
                        persona_a_entregar.servidor = null;
                        persona_a_entregar.minuto_entrada_cola_entrega = fila_actual.reloj;
                    }
                    // Hay un empleado libre
                    else {
                        // A la persona se le cambia el estado a recibiendo pedido, se le asigna el servidor, y al empleado se le asigna el estado ocupado
                        persona_a_entregar.estado = Estado.recibiendo_pedido;
                        persona_a_entregar.servidor = fila_actual.empleados[idServidorLibre - 1];
                        fila_actual.empleados[idServidorLibre - 1].estado = Estado.ocupado;

                        // Cálculo del tiempo de entrega de pedido, que es la suma del tiempo de entrega y el tiempo de preparacion
                        fila_actual.rnd_entrega_pedido = genEntregaPedido.NextDouble();
                        var tiempoEntrega = generarRNDExponencial(fila_actual.rnd_entrega_pedido, (double)this.tiempo_entrega)/60;
                        fila_actual.tiempo_entrega_pedido = tiempoEntrega;

                        // Para calcular el tiempo de preparación necesito saber el tipo de pedido
                        fila_actual.rnd_tipo_pedido = genTipoPedido.NextDouble();
                        fila_actual.tipo_pedido = obtenerTipoPedido(fila_actual.rnd_tipo_pedido);


                        //var tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);

                        // Para que no se generen todos los RK, solo hago que se genere el excel si la bandera de mostrar está activa, caso contrario se toma el valor de las variables resultado
                        double tiempoPreparacion;
                        switch (fila_actual.tipo_pedido) {
                            case 35:
                                if (resultado_cafe == 0) {
                                    tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    resultado_cafe = tiempoPreparacion; }
                                else {
                                    if (flag)
                                        tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    else
                                        tiempoPreparacion = resultado_cafe;
                                }
                                break;
                            case 60:
                                if (resultado_cafe_medialunas == 0)
                                {
                                    tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    resultado_cafe_medialunas = tiempoPreparacion;
                                }
                                else
                                {
                                    if (flag)
                                        tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    else
                                        tiempoPreparacion = resultado_cafe_medialunas;
                                }
                                break;
                            default:
                                if (resultado_menu == 0)
                                {
                                    tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    resultado_menu = tiempoPreparacion;
                                }
                                else
                                {
                                    if (flag)
                                        tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    else
                                        tiempoPreparacion = resultado_menu;
                                }
                                break;
                        }


                        fila_actual.tiempo_preparacion_pedido = tiempoPreparacion;
                        fila_actual.tiempo_fin_entrega_pedido[idServidorLibre - 1] = fila_actual.reloj + tiempoPreparacion + tiempoEntrega;
                    }


                    // La caja observa si hay más personas en la cola
                    if (fila_actual.cola_caja.Count == 0)
                    {
                        // No hay nadie en la cola de caja, dejo la caja en libre
                        fila_actual.caja.estado = Estado.libre;
                    }
                    else {
                        // Hay personas en la cola de caja, obtengo el primero en la cola y cambio los estados y servidor de la persona
                        Persona persona_a_comprar_ticket = fila_actual.cola_caja[0];
                        persona_a_comprar_ticket.estado = Estado.comprando_ticket;
                        persona_a_comprar_ticket.servidor = fila_actual.caja;
                        fila_actual.caja.estado = Estado.ocupado;

                        //Calculo nuevamente el fin de compra de ticket
                        fila_actual.fin_compra_ticket = fila_actual.reloj + ((double)this.tiempo_compra/60);

                        // Calculo métricas

                        acum_permanencia_cola_compra += fila_actual.reloj - persona_a_comprar_ticket.minuto_entrada_cola_compra;

                        // Remuevo a la persona atendida de la cola de la caja
                        fila_actual.cola_caja.RemoveAt(0);
                    };

                }
                // Evento fin de entrega de pedido del empleado 1
                else if (fila_actual.evento == Evento.fin_entrega_pedido1)
                {
                    // Métricas
                    cant_personas_llegaron_empleado++;

                    // Pongo el fin de entrega de pedido en 0, obtengo la persona que recibió el pedido y pongo su servidor en null
                    fila_actual.tiempo_fin_entrega_pedido[0] = 0;
                    var persona_pedido_recibido = obtenerPersona(fila_actual.personas, 1);
                    persona_pedido_recibido.servidor = null;

                    // Calculamos si la persona ocupa una mesa o se va
                    fila_actual.rnd_mesa = genOcupaMesa.NextDouble();
                    fila_actual.ocupa_mesa = (fila_actual.rnd_mesa < 0.5) ? true : false;


                    if (fila_actual.ocupa_mesa)
                    {
                        // La persona se sienta en una mesa y comienza a consumir su pedido
                        fila_actual.personas_ocupando_mesa.Add(persona_pedido_recibido);
                        persona_pedido_recibido.estado = Estado.consumiendo_pedido;

                        // Métricas
                        persona_pedido_recibido.minuto_inicio_ocupacion_mesa = fila_actual.reloj;
                        contador_personas_total_ocupan_mesa++;
                        contador_personas_consumen_ocupan_mesa++;

                        // Se genera el tiempo de consumisión
                        fila_actual.rnd_tiempo_consumision_pedido = genTiempoConsumision.NextDouble();
                        fila_actual.tiempo_consumicion_pedido = generarRNDUniforme(fila_actual.rnd_tiempo_consumision_pedido, this.inf_consumision, this.sup_consumision);
                        fila_actual.fin_consumision_pedido = fila_actual.reloj + fila_actual.tiempo_consumicion_pedido;
                        persona_pedido_recibido.tiempo_fin_consumicion = fila_actual.fin_consumision_pedido;
                    }
                    else
                    {
                        // Solamente la persona se va, no se genera tiempo de consumisión, ni se ocupa una mesa, se destruye automáticamente
                        persona_pedido_recibido.estado = Estado.destruccion;
                    }


                    // El empleado observa si hay más personas en la cola
                    if (fila_actual.cola_entrega_pedido.Count == 0)
                    {
                        // No hay nadie en la cola de caja, dejo al empleado en libre
                        fila_actual.empleados[0].estado = Estado.libre;
                    }
                    else
                    {
                        // Hay personas en la cola de entrega de pedido, obtengo el primero en la cola y cambio los estados y servidor de la persona
                        Persona persona_esperando_entrega = fila_actual.cola_entrega_pedido[0];
                        persona_esperando_entrega.estado = Estado.recibiendo_pedido;
                        persona_esperando_entrega.servidor = fila_actual.empleados[0];
                        fila_actual.empleados[0].estado = Estado.ocupado;

                        // Métricas
                        acum_permanencia_cola_entrega += fila_actual.reloj - persona_esperando_entrega.minuto_entrada_cola_entrega;

                        //Calculo nuevamente el fin de entrega de pedido
                        // Cálculo del tiempo de entrega de pedido, que es la suma del tiempo de entrega y el tiempo de preparacion
                        fila_actual.rnd_entrega_pedido = genEntregaPedido.NextDouble();
                        var tiempoEntrega = generarRNDExponencial(fila_actual.rnd_entrega_pedido, (double)this.tiempo_entrega) / 60;
                        fila_actual.tiempo_entrega_pedido = tiempoEntrega;

                        // Para calcular el tiempo de preparación necesito saber el tipo de pedido
                        fila_actual.rnd_tipo_pedido = genTipoPedido.NextDouble();
                        fila_actual.tipo_pedido = obtenerTipoPedido(fila_actual.rnd_tipo_pedido);


                        //var tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                        // Para que no se generen todos los RK, solo hago que se genere el excel si la bandera de mostrar está activa, caso contrario se toma el valor de las variables resultado
                        double tiempoPreparacion;
                        switch (fila_actual.tipo_pedido)
                        {
                            case 35:
                                if (resultado_cafe == 0)
                                {
                                    tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    resultado_cafe = tiempoPreparacion;
                                }
                                else
                                {
                                    if (flag)
                                        tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    else
                                        tiempoPreparacion = resultado_cafe;
                                }
                                break;
                            case 60:
                                if (resultado_cafe_medialunas == 0)
                                {
                                    tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    resultado_cafe_medialunas = tiempoPreparacion;
                                }
                                else
                                {
                                    if (flag)
                                        tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    else
                                        tiempoPreparacion = resultado_cafe_medialunas;
                                }
                                break;
                            default:
                                if (resultado_menu == 0)
                                {
                                    tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    resultado_menu = tiempoPreparacion;
                                }
                                else
                                {
                                    if (flag)
                                        tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    else
                                        tiempoPreparacion = resultado_menu;
                                }
                                break;
                        }

                        fila_actual.tiempo_preparacion_pedido = tiempoPreparacion;
                        fila_actual.tiempo_fin_entrega_pedido[0] = fila_actual.reloj + tiempoPreparacion + tiempoEntrega;

                        // Remuevo a la persona atendida de la cola de entrega de pedidos
                        fila_actual.cola_entrega_pedido.RemoveAt(0);
                    };

                }
                //Evento fin de entrega de pedido del empleado 2
                else if (fila_actual.evento == Evento.fin_entrega_pedido2)
                {
                    // Métricas
                    cant_personas_llegaron_empleado++;

                    // Pongo el fin de entrega de pedido en 0, obtengo la persona que recibió el pedido y pongo su servidor en null
                    fila_actual.tiempo_fin_entrega_pedido[1] = 0;
                    var persona_pedido_recibido = obtenerPersona(fila_actual.personas, 2);
                    persona_pedido_recibido.servidor = null;

                    // Calculamos si la persona ocupa una mesa o se va
                    fila_actual.rnd_mesa = genOcupaMesa.NextDouble();
                    fila_actual.ocupa_mesa = (fila_actual.rnd_mesa < 0.5) ? true : false;


                    if (fila_actual.ocupa_mesa)
                    {
                        // La persona se sienta en una mesa y comienza a consumir su pedido
                        fila_actual.personas_ocupando_mesa.Add(persona_pedido_recibido);
                        persona_pedido_recibido.estado = Estado.consumiendo_pedido;

                        // Métricas
                        persona_pedido_recibido.minuto_inicio_ocupacion_mesa = fila_actual.reloj;
                        contador_personas_total_ocupan_mesa++;
                        contador_personas_consumen_ocupan_mesa++;

                        // Se genera el tiempo de consumisión
                        fila_actual.rnd_tiempo_consumision_pedido = genTiempoConsumision.NextDouble();
                        fila_actual.tiempo_consumicion_pedido = generarRNDUniforme(fila_actual.rnd_tiempo_consumision_pedido, this.inf_consumision, this.sup_consumision);
                        fila_actual.fin_consumision_pedido = fila_actual.reloj + fila_actual.tiempo_consumicion_pedido;
                        persona_pedido_recibido.tiempo_fin_consumicion = fila_actual.fin_consumision_pedido;
                    }
                    else {
                        // Solamente la persona se va, no se genera tiempo de consumisión, ni se ocupa una mesa, se destruye automáticamente
                        persona_pedido_recibido.estado = Estado.destruccion;
                    }


                    // El empleado observa si hay más personas en la cola
                    if (fila_actual.cola_entrega_pedido.Count == 0)
                    {
                        // No hay nadie en la cola de caja, dejo al empleado en libre
                        fila_actual.empleados[1].estado = Estado.libre;
                    }
                    else
                    {
                        // Hay personas en la cola de entrega de pedido, obtengo el primero en la cola y cambio los estados y servidor de la persona
                        Persona persona_esperando_entrega = fila_actual.cola_entrega_pedido[0];
                        persona_esperando_entrega.estado = Estado.recibiendo_pedido;
                        persona_esperando_entrega.servidor = fila_actual.empleados[1];
                        fila_actual.empleados[1].estado = Estado.ocupado;

                        // Métricas
                        acum_permanencia_cola_entrega += fila_actual.reloj - persona_esperando_entrega.minuto_entrada_cola_entrega;

                        //Calculo nuevamente el fin de entrega de pedido
                        // Cálculo del tiempo de entrega de pedido, que es la suma del tiempo de entrega y el tiempo de preparacion
                        fila_actual.rnd_entrega_pedido = genEntregaPedido.NextDouble();
                        var tiempoEntrega = generarRNDExponencial(fila_actual.rnd_entrega_pedido, (double)this.tiempo_entrega) / 60;
                        fila_actual.tiempo_entrega_pedido = tiempoEntrega;

                        // Para calcular el tiempo de preparación necesito saber el tipo de pedido
                        fila_actual.rnd_tipo_pedido = genTipoPedido.NextDouble();
                        fila_actual.tipo_pedido = obtenerTipoPedido(fila_actual.rnd_tipo_pedido);


                        //var tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                        // Para que no se generen todos los RK, solo hago que se genere el excel si la bandera de mostrar está activa, caso contrario se toma el valor de las variables resultado
                        double tiempoPreparacion;
                        switch (fila_actual.tipo_pedido)
                        {
                            case 35:
                                if (resultado_cafe == 0)
                                {
                                    tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    resultado_cafe = tiempoPreparacion;
                                }
                                else
                                {
                                    if (flag)
                                        tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    else
                                        tiempoPreparacion = resultado_cafe;
                                }
                                break;
                            case 60:
                                if (resultado_cafe_medialunas == 0)
                                {
                                    tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    resultado_cafe_medialunas = tiempoPreparacion;
                                }
                                else
                                {
                                    if (flag)
                                        tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    else
                                        tiempoPreparacion = resultado_cafe_medialunas;
                                }
                                break;
                            default:
                                if (resultado_menu == 0)
                                {
                                    tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    resultado_menu = tiempoPreparacion;
                                }
                                else
                                {
                                    if (flag)
                                        tiempoPreparacion = obtenerTiempoPreparacion(fila_actual.tipo_pedido, fila_actual.reloj);
                                    else
                                        tiempoPreparacion = resultado_menu;
                                }
                                break;
                        }

                        fila_actual.tiempo_preparacion_pedido = tiempoPreparacion;
                        fila_actual.tiempo_fin_entrega_pedido[1] = fila_actual.reloj + tiempoPreparacion + tiempoEntrega;

                        // Remuevo a la persona atendida de la cola de entrega de pedidos
                        fila_actual.cola_entrega_pedido.RemoveAt(0);
                    };

                }
                // Evento fin de consumisión del pedido
                else if (fila_actual.evento == Evento.fin_consumision)
                {
                    Persona persona_consumision_finalizada = obtenerPersonaConsumisionFinalizada(fila_actual.reloj, fila_actual.personas_ocupando_mesa);
                    persona_consumision_finalizada.tiempo_fin_consumicion = 0;
                    int index = 0;
                    foreach (Persona persona in fila_actual.personas_ocupando_mesa) {
                        if (persona.id == persona_consumision_finalizada.id) {
                            fila_actual.personas_ocupando_mesa.RemoveAt(index);
                            break;
                        }
                        index++;
                    }
                    acum_tiempo_ocupando_mesa += fila_actual.reloj - persona_consumision_finalizada.minuto_inicio_ocupacion_mesa;
                    persona_consumision_finalizada.estado = Estado.destruccion;

                }
                //Evento fin de utilización de mesa
                else if (fila_actual.evento == Evento.fin_utilizacion_mesa) {
                    Persona persona_fin_utilizacion_mesa = obtenerPersonaFinUtilizacionMesa(fila_actual.reloj, fila_actual.personas_ocupando_mesa);
                    persona_fin_utilizacion_mesa.tiempo_fin_utilizacion_mesa = 0;
                    int index = 0;
                    foreach (Persona persona in fila_actual.personas_ocupando_mesa)
                    {
                        if (persona.id == persona_fin_utilizacion_mesa.id)
                        {
                            fila_actual.personas_ocupando_mesa.RemoveAt(index);
                            break;
                        }
                        index++;
                    }
                    acum_tiempo_ocupando_mesa += fila_actual.reloj - persona_fin_utilizacion_mesa.minuto_inicio_ocupacion_mesa;
                    persona_fin_utilizacion_mesa.estado = Estado.destruccion;
                }


                // Cálculo de métricas --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                // Cálculo del tiempo promedio de permanencia en cola de compra de ticket (Métrica 2)

                if (cant_personas_llegaron_caja != 0)
                    fila_actual.tiempoPermanenciaColaCompra = acum_permanencia_cola_compra / cant_personas_llegaron_caja;

                else
                    fila_actual.tiempoPermanenciaColaCompra = 0;

                // Cálculo del tiempo promedio de permanencia en cola de entrega de pedido (Métrica 2)

                if (cant_personas_llegaron_empleado != 0)
                    fila_actual.tiempoPermanenciaColaEntrega = acum_permanencia_cola_entrega / cant_personas_llegaron_empleado;

                else
                    fila_actual.tiempoPermanenciaColaEntrega = 0;

                // Cálculo del promedio de personas utilizando una mesa (Métrica 3)

                if (fila_actual.reloj != 0)
                    fila_actual.personas_promedio_utilizando_mesa = acum_tiempo_ocupando_mesa / fila_actual.reloj;

                else
                    fila_actual.personas_promedio_utilizando_mesa = 0;

                // Cálculo del porcentaje de personas que ocupan la mesa despues de consumir sobre las personas que ocupan una mesa sin consumir

                if (contador_personas_total_ocupan_mesa != 0)
                    fila_actual.porc_personas_ocupan_mesa_consumiendo = ((double)contador_personas_consumen_ocupan_mesa / (double)contador_personas_total_ocupan_mesa) * 100;
                else
                    fila_actual.porc_personas_ocupan_mesa_consumiendo = 0;


                // Fin Métricas----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                //Se cambia el orden de las filas y se muestra en la tabla (solo si se debe mostrar)
                if ((i >= this.fila_desde - 1 && i < this.fila_desde + this.cant_filas - 1) || (i == this.iteraciones - 1 && this.iteraciones != this.fila_desde + this.cant_filas - 1))
                    cant_personas_actual = imprimirFila(fila_actual, cant_personas_actual);
                fila_anterior = fila_actual;

                // Lo uso para que la persona de paso, que se destruye automaticamente, se muestre sólo si llega en las filas a mostrar
                if (this.persona_de_paso != null)
                {
                    this.persona_de_paso.bandera_de_paso = false;
                    this.persona_de_paso = null;
                }

            }
        }

        private int imprimirFila(VectorEstado fila_imprimir, int cant_personas_actual)
        {
            int cant_columnas = 37 + fila_imprimir.personas.Count*3;
            var fila = new string[cant_columnas];
            int puntero = 37;
            int contador = 0;

            fila[0] = fila_imprimir.reloj.ToString("0.00");
            fila[1] = fila_imprimir.evento.ToString();
            fila[2] = fila_imprimir.rnd1_llegada.ToString("0.00");
            fila[3] = fila_imprimir.rnd2_llegada.ToString("0.00");
            fila[4] = fila_imprimir.tiempo_llegada.ToString("0.00");
            fila[5] = fila_imprimir.tiempo_prox_llegada.ToString("0.00");
            fila[6] = fila_imprimir.rnd_accion.ToString("0.00");
            switch (fila_imprimir.accion)
            {
                case 0:
                    fila[7] = "Compra";
                    break;
                case 1:
                    fila[7] = "Ocupa mesa";
                    break;
                case 2:
                    fila[7] = "De paso";
                    break;
                default:
                    fila[7] = "-";
                    break;
            }
            fila[8] = fila_imprimir.rnd_mesa.ToString("0.00");
            fila[9] = fila_imprimir.ocupa_mesa ? "SI" : "NO";
            fila[10] = fila_imprimir.fin_compra_ticket.ToString("0.00");
            fila[11] = fila_imprimir.rnd_entrega_pedido.ToString("0.00");
            fila[12] = fila_imprimir.tiempo_entrega_pedido.ToString("0.00");
            fila[13] = fila_imprimir.rnd_tipo_pedido.ToString("0.00");
            switch (fila_imprimir.tipo_pedido) {
                case 35:
                    fila[14] = "Café";
                    break;
                case 60:
                    fila[14] = "Café y medialunas";
                    break;
                case 115:
                    fila[14] = "Menú";
                    break;
               default:
                    fila[14] = "-";
                    break;
            }
            fila[15] = fila_imprimir.tiempo_preparacion_pedido.ToString("0.00");
            fila[16] = fila_imprimir.tiempo_fin_entrega_pedido[0].ToString("0.00");
            fila[17] = fila_imprimir.tiempo_fin_entrega_pedido[1].ToString("0.00");
            fila[18] = fila_imprimir.rnd_tiempo_consumision_pedido.ToString("0.00");
            fila[19] = fila_imprimir.tiempo_consumicion_pedido.ToString("0.00");
            fila[20] = fila_imprimir.fin_consumision_pedido.ToString("0.00");
            fila[21] = fila_imprimir.rnd_tiempo_ocupacion_mesa.ToString("0.00");
            fila[22] = fila_imprimir.tiempo_ocupacion_mesa.ToString("0.00");
            fila[23] = fila_imprimir.fin_ocupacion_mesa.ToString("0.00");
            fila[24] = fila_imprimir.cola_caja.Count.ToString();
            fila[25] = fila_imprimir.tiempoPermanenciaColaCompra.ToString("0.00") + " min.";
            fila[26] = fila_imprimir.caja.estado.ToString();
            fila[27] = fila_imprimir.porc_ocupacion_caja.ToString("0.00") + "%"; 
            fila[28] = fila_imprimir.cola_entrega_pedido.Count.ToString();
            fila[29] = fila_imprimir.tiempoPermanenciaColaEntrega.ToString("0.00") + " min.";
            fila[30] = fila_imprimir.empleados[0].estado.ToString();
            fila[31] = fila_imprimir.porc_ocupacion_empleado1.ToString("0.00") + "%";
            fila[32] = fila_imprimir.empleados[1].estado.ToString();
            fila[33] = fila_imprimir.porc_ocupacion_empleado2.ToString("0.00") + "%";
            fila[34] = fila_imprimir.personas_ocupando_mesa.Count.ToString();
            fila[35] = fila_imprimir.personas_promedio_utilizando_mesa.ToString("0.00");
            fila[36] = fila_imprimir.porc_personas_ocupan_mesa_consumiendo.ToString("0.00") + "%";


            int columnas_a_agregar = (fila_imprimir.personas.Count - cant_personas_actual);

            //for (int i = puntero; i <= fila_imprimir.personas.Count + puntero - 1; i = i + 3)
            //{
            //    fila[i] = fila_imprimir.personas[contador].estado.ToString();
            //    fila[i + 1] = fila_imprimir.personas[contador].tiempo_fin_consumicion.ToString("0.00");
            //    fila[i + 2] = fila_imprimir.personas[contador].tiempo_fin_utilizacion_mesa.ToString("0.00");

            //    contador += 3;
            //};

            //contador = 0;

            for (int i = columnas_a_agregar; i > 0; i--)
            {
                if (fila_imprimir.personas[fila_imprimir.personas.Count - i].estado != Estado.destruccion || fila_imprimir.personas[fila_imprimir.personas.Count - i].bandera_de_paso == true)
                {
                    dgv_colas.Columns.Add($"Persona{fila_imprimir.personas[fila_imprimir.personas.Count - i].id}", $"Persona {fila_imprimir.personas[fila_imprimir.personas.Count - i].id}");
                    dgv_colas.Columns.Add($"FinConsumision{fila_imprimir.personas[fila_imprimir.personas.Count - i].id}", $"Fin Consumision {fila_imprimir.personas[fila_imprimir.personas.Count - i].id}");
                    dgv_colas.Columns.Add($"FinUtilizacion{fila_imprimir.personas[fila_imprimir.personas.Count - i].id}", $"Fin Utilizacion {fila_imprimir.personas[fila_imprimir.personas.Count - i].id}");
                    columas_a_agregar_AC +=3;
                    lista_ids.Add(fila_imprimir.personas[fila_imprimir.personas.Count - i].id);
                }
            }

            for (int i = puntero; i <= columas_a_agregar_AC + puntero - 1; i+=3)
            {
                if (fila_imprimir.personas[lista_ids[contador] - 1].estado == Estado.destruccion)
                    fila[i] = "//////////////";
                else
                    fila[i] = fila_imprimir.personas[lista_ids[contador] - 1].estado.ToString();
                fila[i+1] = fila_imprimir.personas[lista_ids[contador] - 1].tiempo_fin_consumicion.ToString("0.00");
                fila[i+2] = fila_imprimir.personas[lista_ids[contador] - 1].tiempo_fin_utilizacion_mesa.ToString("0.00");
                contador++;
            }
            dgv_colas.Rows.Add(fila);

            return fila_imprimir.personas.Count;
        }

        private Persona obtenerPersonaConsumisionFinalizada(double reloj, List<Persona> personas_ocupando_mesa)
        {
            foreach (Persona persona in personas_ocupando_mesa)
            {
                if (persona.tiempo_fin_consumicion == reloj && persona.estado == Estado.consumiendo_pedido)
                {
                    return persona;
                }
            }
            return new Persona() { id = -1 }; // No debería pasar
        }

        private Persona obtenerPersonaFinUtilizacionMesa(double reloj, List<Persona> personas_ocupando_mesa)
        {
            foreach (Persona persona in personas_ocupando_mesa) {
                if (persona.tiempo_fin_utilizacion_mesa == reloj && persona.estado == Estado.utilizando_mesa) {
                    return persona;
                }
            }
            return new Persona() { id = -1 }; // No debería pasar
        }

        private double obtenerTiempoPreparacion(int tipo_pedido, double reloj)
        {
            var rk_tiempo_entrega = new rk_tiempo_entrega(tipo_pedido, this.pathFile, reloj);
            var tiempo_entrega = rk_tiempo_entrega.valorBuscado;
            return (double)tiempo_entrega;
        }

        private int obtenerTipoPedido(double rnd_tipo_pedido)
        {
            // Devuelve, segun el rnd, el tipo de pedido, todos con igual probabilidad
            if (rnd_tipo_pedido < (0.333333333333333333333333333333))
            {
                return 35;
            }
            else if (rnd_tipo_pedido < (0.666666666666666666666666666666))
            {
                return 60;
            }
            else {
                return 115;
            }

        }

        private int ServidorLibre(List<Servidor> empleados)
        {
            // Devuelve el id del servidor de empleados libre
            if (empleados[0].estado == Estado.libre) {
                return 1;
            }
            if (empleados[1].estado == Estado.libre) {
                return 2;
            }
            // Si no hay servidores libres, devuelve -1
            return -1;
        }

        private double generarRNDUniforme(double rnd, decimal inf_utilizacion, decimal sup_utilizacion)
        {
            double valor = (double)inf_utilizacion + (double)rnd * ((double)sup_utilizacion - (double)inf_utilizacion);
            return valor;
        }

        private Persona obtenerPersona(List<Persona> personas, int idServidor)
        {
            Persona persona = new Persona();
            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].servidor != null && personas[i].servidor.id == idServidor)
                {
                    persona = personas[i];
                }
            }
            return persona;
        }



        private List<double> calcularProximoReloj(double prox_llegada, double fin_compra_ticket, double fin_entrega_pedido1, double fin_entrega_pedido2, List<Persona> personas_ocupando_mesa)
        {
            var proximoReloj = new List<double>();
            double minimo = prox_llegada;
            int evento = 0;
            if (fin_compra_ticket < minimo && fin_compra_ticket != 0) {
                minimo = fin_compra_ticket;
                evento = 1;
            };
            if (fin_entrega_pedido1 < minimo && fin_entrega_pedido1 != 0)
            {
                minimo = fin_entrega_pedido1;
                evento = 2;
            };
            if (fin_entrega_pedido2 < minimo && fin_entrega_pedido2 != 0)
            {
                minimo = fin_entrega_pedido2;
                evento = 3;
            };
            foreach (Persona persona in personas_ocupando_mesa) {
                if (persona.tiempo_fin_consumicion < minimo && persona.tiempo_fin_consumicion != 0 && persona.estado == Estado.consumiendo_pedido) 
                {
                    minimo = persona.tiempo_fin_consumicion;
                    evento = 4;
                };
            }

            foreach (Persona persona in personas_ocupando_mesa)
            {
                if (persona.tiempo_fin_utilizacion_mesa < minimo && persona.tiempo_fin_utilizacion_mesa != 0 && persona.estado == Estado.utilizando_mesa)
                {
                    minimo = persona.tiempo_fin_utilizacion_mesa;
                    evento = 5;
                };
            }
            proximoReloj.Add(minimo);
            proximoReloj.Add(evento);
            return proximoReloj;
        }

        private int obtenerAccion(double rnd_accion)
        {
            if (rnd_accion < 0.30) {
                return (int)Accion.compra;
            } else if (rnd_accion < 0.50) {
                return (int)Accion.utiliza_mesa;
            } else {
                return (int)Accion.de_paso;
            }
        }

        private void borrarArchivos()
        {
            this.pathFile = AppDomain.CurrentDomain.BaseDirectory + "excel";
            Directory.CreateDirectory(this.pathFile);
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "excel");
            FileInfo[] files = di.GetFiles();
            if (files.Length != 0)
            {
                foreach (FileInfo file in files)
                {
                    file.Delete();
                }
            }
        }

        public List<double> generarRNDNormal(Random generador, double media, double desviacion)
        {
            var resultado = new List<double>();
            if (flag == false)
            {
                
                var rnd1 = generador.NextDouble();
                var rnd2 = generador.NextDouble();
                resultado.Add(rnd1);
                resultado.Add(rnd2);
                this.rnd1 = rnd1;
                this.rnd2 = rnd2;

                this.N1 = ((Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Cos(2 * Math.PI * rnd2)) * (double)desviacion) + (double)media;
                this.N2 = ((Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Sin(2 * Math.PI * rnd2)) * (double)desviacion) + (double)media;
                flag = true;

                if (this.N1 >= 0)
                    resultado.Add(this.N1);
                else
                    resultado.Add(-this.N1);
                return resultado;

            }
            else
            {
                resultado.Add(this.rnd1);
                resultado.Add(this.rnd2);

                if (this.N2 >= 0)
                    resultado.Add(this.N2);
                else
                    resultado.Add(-this.N2);

                flag = false;
                return resultado;
            }

        }

        public double generarRNDExponencial(double rnd, double media) { 
            var valor = -(media) * Math.Log(1 - rnd);
            return valor;
        }
    }
}
