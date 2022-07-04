
namespace Simulacion_TP7.Tabla_Colas
{
    partial class tablaSimulacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_colas = new System.Windows.Forms.DataGridView();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd1_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd2_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_prox_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupa_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_compra_ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_entrega_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_entrega_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_tipo_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_preparacion_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_fin_entrega_pedido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_fin_entrega_pedido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_tiempo_consumicion_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_consumicion_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_consumicion_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_tiempo_ocupacion_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_ocupacion_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_ocupacion_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prom_permanencia_cola_caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porc_ocupacion_caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_entrega_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prom_permanencia_cola_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_empleado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porc_ocupacion_empleado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_empleado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje_ocupacion_empleado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personas_ocupando_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prom_personas_ocupando_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porc_personas_ocupan_mesa_consumiendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_colas
            // 
            this.dgv_colas.AllowUserToAddRows = false;
            this.dgv_colas.AllowUserToDeleteRows = false;
            this.dgv_colas.AllowUserToResizeRows = false;
            this.dgv_colas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_colas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_colas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.evento,
            this.rnd1_llegada,
            this.rnd2_llegada,
            this.tiempo_llegada,
            this.tiempo_prox_llegada,
            this.rnd_accion,
            this.accion,
            this.rnd_mesa,
            this.ocupa_mesa,
            this.fin_compra_ticket,
            this.rnd_entrega_pedido,
            this.tiempo_entrega_pedido,
            this.rnd_tipo_pedido,
            this.tipo_pedido,
            this.tiempo_preparacion_pedido,
            this.tiempo_fin_entrega_pedido1,
            this.tiempo_fin_entrega_pedido2,
            this.rnd_tiempo_consumicion_pedido,
            this.tiempo_consumicion_pedido,
            this.fin_consumicion_pedido,
            this.rnd_tiempo_ocupacion_mesa,
            this.tiempo_ocupacion_mesa,
            this.fin_ocupacion_mesa,
            this.cola_caja,
            this.prom_permanencia_cola_caja,
            this.estado_caja,
            this.porc_ocupacion_caja,
            this.cola_entrega_pedido,
            this.prom_permanencia_cola_entrega,
            this.estado_empleado1,
            this.porc_ocupacion_empleado1,
            this.estado_empleado2,
            this.porcentaje_ocupacion_empleado2,
            this.personas_ocupando_mesa,
            this.prom_personas_ocupando_mesa,
            this.porc_personas_ocupan_mesa_consumiendo});
            this.dgv_colas.Location = new System.Drawing.Point(13, 13);
            this.dgv_colas.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_colas.Name = "dgv_colas";
            this.dgv_colas.ReadOnly = true;
            this.dgv_colas.RowHeadersWidth = 51;
            this.dgv_colas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_colas.Size = new System.Drawing.Size(1326, 628);
            this.dgv_colas.TabIndex = 1;
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj";
            this.reloj.MinimumWidth = 6;
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            this.reloj.Width = 69;
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.MinimumWidth = 6;
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Width = 81;
            // 
            // rnd1_llegada
            // 
            this.rnd1_llegada.HeaderText = "RND 1 Llegada";
            this.rnd1_llegada.MinimumWidth = 6;
            this.rnd1_llegada.Name = "rnd1_llegada";
            this.rnd1_llegada.ReadOnly = true;
            this.rnd1_llegada.Width = 123;
            // 
            // rnd2_llegada
            // 
            this.rnd2_llegada.HeaderText = "RND 2 Llegada";
            this.rnd2_llegada.MinimumWidth = 6;
            this.rnd2_llegada.Name = "rnd2_llegada";
            this.rnd2_llegada.ReadOnly = true;
            this.rnd2_llegada.Width = 123;
            // 
            // tiempo_llegada
            // 
            this.tiempo_llegada.HeaderText = "Tiempo Llegada";
            this.tiempo_llegada.MinimumWidth = 6;
            this.tiempo_llegada.Name = "tiempo_llegada";
            this.tiempo_llegada.ReadOnly = true;
            this.tiempo_llegada.Width = 127;
            // 
            // tiempo_prox_llegada
            // 
            this.tiempo_prox_llegada.HeaderText = "Tiempo Prox Llegada";
            this.tiempo_prox_llegada.MinimumWidth = 6;
            this.tiempo_prox_llegada.Name = "tiempo_prox_llegada";
            this.tiempo_prox_llegada.ReadOnly = true;
            this.tiempo_prox_llegada.Width = 156;
            // 
            // rnd_accion
            // 
            this.rnd_accion.HeaderText = "RND Accion";
            this.rnd_accion.MinimumWidth = 6;
            this.rnd_accion.Name = "rnd_accion";
            this.rnd_accion.ReadOnly = true;
            this.rnd_accion.Width = 104;
            // 
            // accion
            // 
            this.accion.HeaderText = "Accion";
            this.accion.MinimumWidth = 6;
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            this.accion.Width = 79;
            // 
            // rnd_mesa
            // 
            this.rnd_mesa.HeaderText = "RND Mesa";
            this.rnd_mesa.MinimumWidth = 6;
            this.rnd_mesa.Name = "rnd_mesa";
            this.rnd_mesa.ReadOnly = true;
            this.rnd_mesa.Width = 97;
            // 
            // ocupa_mesa
            // 
            this.ocupa_mesa.HeaderText = "Ocupa Mesa";
            this.ocupa_mesa.MinimumWidth = 6;
            this.ocupa_mesa.Name = "ocupa_mesa";
            this.ocupa_mesa.ReadOnly = true;
            this.ocupa_mesa.Width = 108;
            // 
            // fin_compra_ticket
            // 
            this.fin_compra_ticket.HeaderText = "Fin Compra Ticket";
            this.fin_compra_ticket.MinimumWidth = 6;
            this.fin_compra_ticket.Name = "fin_compra_ticket";
            this.fin_compra_ticket.ReadOnly = true;
            this.fin_compra_ticket.Width = 138;
            // 
            // rnd_entrega_pedido
            // 
            this.rnd_entrega_pedido.HeaderText = "RND Entrega Pedido";
            this.rnd_entrega_pedido.MinimumWidth = 6;
            this.rnd_entrega_pedido.Name = "rnd_entrega_pedido";
            this.rnd_entrega_pedido.ReadOnly = true;
            this.rnd_entrega_pedido.Width = 154;
            // 
            // tiempo_entrega_pedido
            // 
            this.tiempo_entrega_pedido.HeaderText = "Tiempo Entrega Pedido";
            this.tiempo_entrega_pedido.MinimumWidth = 6;
            this.tiempo_entrega_pedido.Name = "tiempo_entrega_pedido";
            this.tiempo_entrega_pedido.ReadOnly = true;
            this.tiempo_entrega_pedido.Width = 170;
            // 
            // rnd_tipo_pedido
            // 
            this.rnd_tipo_pedido.HeaderText = "RND Tipo Pedido";
            this.rnd_tipo_pedido.MinimumWidth = 6;
            this.rnd_tipo_pedido.Name = "rnd_tipo_pedido";
            this.rnd_tipo_pedido.ReadOnly = true;
            this.rnd_tipo_pedido.Width = 135;
            // 
            // tipo_pedido
            // 
            this.tipo_pedido.HeaderText = "Tipo Pedido";
            this.tipo_pedido.MinimumWidth = 6;
            this.tipo_pedido.Name = "tipo_pedido";
            this.tipo_pedido.ReadOnly = true;
            this.tipo_pedido.Width = 104;
            // 
            // tiempo_preparacion_pedido
            // 
            this.tiempo_preparacion_pedido.HeaderText = "Tiempo Preparacion Pedido";
            this.tiempo_preparacion_pedido.MinimumWidth = 6;
            this.tiempo_preparacion_pedido.Name = "tiempo_preparacion_pedido";
            this.tiempo_preparacion_pedido.ReadOnly = true;
            this.tiempo_preparacion_pedido.Width = 194;
            // 
            // tiempo_fin_entrega_pedido1
            // 
            this.tiempo_fin_entrega_pedido1.HeaderText = "Tiempo Fin Entrega Pedido (E1)";
            this.tiempo_fin_entrega_pedido1.MinimumWidth = 6;
            this.tiempo_fin_entrega_pedido1.Name = "tiempo_fin_entrega_pedido1";
            this.tiempo_fin_entrega_pedido1.ReadOnly = true;
            this.tiempo_fin_entrega_pedido1.Width = 194;
            // 
            // tiempo_fin_entrega_pedido2
            // 
            this.tiempo_fin_entrega_pedido2.HeaderText = "Tiempo Fin Entrega Pedido (E2))";
            this.tiempo_fin_entrega_pedido2.MinimumWidth = 6;
            this.tiempo_fin_entrega_pedido2.Name = "tiempo_fin_entrega_pedido2";
            this.tiempo_fin_entrega_pedido2.ReadOnly = true;
            this.tiempo_fin_entrega_pedido2.Width = 194;
            // 
            // rnd_tiempo_consumicion_pedido
            // 
            this.rnd_tiempo_consumicion_pedido.HeaderText = "RND Tiempo Consumicion Pedido";
            this.rnd_tiempo_consumicion_pedido.MinimumWidth = 6;
            this.rnd_tiempo_consumicion_pedido.Name = "rnd_tiempo_consumicion_pedido";
            this.rnd_tiempo_consumicion_pedido.ReadOnly = true;
            this.rnd_tiempo_consumicion_pedido.Width = 188;
            // 
            // tiempo_consumicion_pedido
            // 
            this.tiempo_consumicion_pedido.HeaderText = "Tiempo Consumicion Pedido";
            this.tiempo_consumicion_pedido.MinimumWidth = 6;
            this.tiempo_consumicion_pedido.Name = "tiempo_consumicion_pedido";
            this.tiempo_consumicion_pedido.ReadOnly = true;
            this.tiempo_consumicion_pedido.Width = 197;
            // 
            // fin_consumicion_pedido
            // 
            this.fin_consumicion_pedido.HeaderText = "Fin Consumicion Pedido";
            this.fin_consumicion_pedido.MinimumWidth = 6;
            this.fin_consumicion_pedido.Name = "fin_consumicion_pedido";
            this.fin_consumicion_pedido.ReadOnly = true;
            this.fin_consumicion_pedido.Width = 172;
            // 
            // rnd_tiempo_ocupacion_mesa
            // 
            this.rnd_tiempo_ocupacion_mesa.HeaderText = "RND Tiempo Ocupacion Mesa";
            this.rnd_tiempo_ocupacion_mesa.MinimumWidth = 6;
            this.rnd_tiempo_ocupacion_mesa.Name = "rnd_tiempo_ocupacion_mesa";
            this.rnd_tiempo_ocupacion_mesa.ReadOnly = true;
            this.rnd_tiempo_ocupacion_mesa.Width = 177;
            // 
            // tiempo_ocupacion_mesa
            // 
            this.tiempo_ocupacion_mesa.HeaderText = "Tiempo Ocupacion Mesa";
            this.tiempo_ocupacion_mesa.MinimumWidth = 6;
            this.tiempo_ocupacion_mesa.Name = "tiempo_ocupacion_mesa";
            this.tiempo_ocupacion_mesa.ReadOnly = true;
            this.tiempo_ocupacion_mesa.Width = 146;
            // 
            // fin_ocupacion_mesa
            // 
            this.fin_ocupacion_mesa.HeaderText = "Fin Ocupacion Mesa";
            this.fin_ocupacion_mesa.MinimumWidth = 6;
            this.fin_ocupacion_mesa.Name = "fin_ocupacion_mesa";
            this.fin_ocupacion_mesa.ReadOnly = true;
            this.fin_ocupacion_mesa.Width = 152;
            // 
            // cola_caja
            // 
            this.cola_caja.HeaderText = "Cola Caja";
            this.cola_caja.MinimumWidth = 6;
            this.cola_caja.Name = "cola_caja";
            this.cola_caja.ReadOnly = true;
            this.cola_caja.Width = 90;
            // 
            // prom_permanencia_cola_caja
            // 
            this.prom_permanencia_cola_caja.HeaderText = "Promedio Permanencia Cola Caja";
            this.prom_permanencia_cola_caja.MinimumWidth = 6;
            this.prom_permanencia_cola_caja.Name = "prom_permanencia_cola_caja";
            this.prom_permanencia_cola_caja.ReadOnly = true;
            this.prom_permanencia_cola_caja.Width = 200;
            // 
            // estado_caja
            // 
            this.estado_caja.HeaderText = "Estado Caja";
            this.estado_caja.MinimumWidth = 6;
            this.estado_caja.Name = "estado_caja";
            this.estado_caja.ReadOnly = true;
            this.estado_caja.Width = 104;
            // 
            // porc_ocupacion_caja
            // 
            this.porc_ocupacion_caja.HeaderText = "Porcentaje Ocupacion Caja";
            this.porc_ocupacion_caja.MinimumWidth = 6;
            this.porc_ocupacion_caja.Name = "porc_ocupacion_caja";
            this.porc_ocupacion_caja.ReadOnly = true;
            this.porc_ocupacion_caja.Width = 165;
            // 
            // cola_entrega_pedido
            // 
            this.cola_entrega_pedido.HeaderText = "Cola Entrega Pedido";
            this.cola_entrega_pedido.MinimumWidth = 6;
            this.cola_entrega_pedido.Name = "cola_entrega_pedido";
            this.cola_entrega_pedido.ReadOnly = true;
            this.cola_entrega_pedido.Width = 153;
            // 
            // prom_permanencia_cola_entrega
            // 
            this.prom_permanencia_cola_entrega.HeaderText = "Promedio Permanencia Cola Entrega";
            this.prom_permanencia_cola_entrega.MinimumWidth = 6;
            this.prom_permanencia_cola_entrega.Name = "prom_permanencia_cola_entrega";
            this.prom_permanencia_cola_entrega.ReadOnly = true;
            this.prom_permanencia_cola_entrega.Width = 200;
            // 
            // estado_empleado1
            // 
            this.estado_empleado1.HeaderText = "Estado E1";
            this.estado_empleado1.MinimumWidth = 6;
            this.estado_empleado1.Name = "estado_empleado1";
            this.estado_empleado1.ReadOnly = true;
            this.estado_empleado1.Width = 94;
            // 
            // porc_ocupacion_empleado1
            // 
            this.porc_ocupacion_empleado1.HeaderText = "Porcentaje Ocupacion Empleado 1";
            this.porc_ocupacion_empleado1.MinimumWidth = 6;
            this.porc_ocupacion_empleado1.Name = "porc_ocupacion_empleado1";
            this.porc_ocupacion_empleado1.ReadOnly = true;
            this.porc_ocupacion_empleado1.Width = 233;
            // 
            // estado_empleado2
            // 
            this.estado_empleado2.HeaderText = "Estado E2";
            this.estado_empleado2.MinimumWidth = 6;
            this.estado_empleado2.Name = "estado_empleado2";
            this.estado_empleado2.ReadOnly = true;
            this.estado_empleado2.Width = 94;
            // 
            // porcentaje_ocupacion_empleado2
            // 
            this.porcentaje_ocupacion_empleado2.HeaderText = "Porcentaje Ocupacion Empleado 2";
            this.porcentaje_ocupacion_empleado2.MinimumWidth = 6;
            this.porcentaje_ocupacion_empleado2.Name = "porcentaje_ocupacion_empleado2";
            this.porcentaje_ocupacion_empleado2.ReadOnly = true;
            this.porcentaje_ocupacion_empleado2.Width = 233;
            // 
            // personas_ocupando_mesa
            // 
            this.personas_ocupando_mesa.HeaderText = "Personas Ocupando Mesa";
            this.personas_ocupando_mesa.MinimumWidth = 6;
            this.personas_ocupando_mesa.Name = "personas_ocupando_mesa";
            this.personas_ocupando_mesa.ReadOnly = true;
            this.personas_ocupando_mesa.Width = 156;
            // 
            // prom_personas_ocupando_mesa
            // 
            this.prom_personas_ocupando_mesa.HeaderText = "Promedio de personas Ocupando Mesa";
            this.prom_personas_ocupando_mesa.MinimumWidth = 6;
            this.prom_personas_ocupando_mesa.Name = "prom_personas_ocupando_mesa";
            this.prom_personas_ocupando_mesa.ReadOnly = true;
            this.prom_personas_ocupando_mesa.Width = 231;
            // 
            // porc_personas_ocupan_mesa_consumiendo
            // 
            this.porc_personas_ocupan_mesa_consumiendo.HeaderText = "Porcentaje personas ocupan mesa consumiendo / total personas ocupan mesa";
            this.porc_personas_ocupan_mesa_consumiendo.MinimumWidth = 6;
            this.porc_personas_ocupan_mesa_consumiendo.Name = "porc_personas_ocupan_mesa_consumiendo";
            this.porc_personas_ocupan_mesa_consumiendo.ReadOnly = true;
            this.porc_personas_ocupan_mesa_consumiendo.Width = 253;
            // 
            // tablaSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 654);
            this.Controls.Add(this.dgv_colas);
            this.Name = "tablaSimulacion";
            this.Text = "tablaSimulacion";
            this.Load += new System.EventHandler(this.tablaSimulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_colas;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd1_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd2_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_prox_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupa_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_compra_ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_entrega_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_entrega_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_tipo_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_preparacion_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_fin_entrega_pedido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_fin_entrega_pedido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_tiempo_consumicion_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_consumicion_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_consumicion_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_tiempo_ocupacion_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_ocupacion_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_ocupacion_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom_permanencia_cola_caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn porc_ocupacion_caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_entrega_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom_permanencia_cola_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_empleado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn porc_ocupacion_empleado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_empleado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje_ocupacion_empleado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personas_ocupando_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom_personas_ocupando_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn porc_personas_ocupan_mesa_consumiendo;
    }
}