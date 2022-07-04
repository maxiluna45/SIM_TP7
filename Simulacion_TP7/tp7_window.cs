using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_TP7
{
    public partial class tp7_window : Form
    {
        public bool activo = false;
        public tp7_window()
        {
            InitializeComponent();
        }


        private void tp7_window_Load(object sender, EventArgs e)
        {

        }

        private void guardar_cambios_Click(object sender, EventArgs e)
        {

        }

        private void cambiar_p_Click(object sender, EventArgs e)
        {
            if (activo)
            {
                p_probabilidades.Visible = false;
                activo = false;
            }
            else {
                p_probabilidades.Visible = true;
                activo = true;
            }
            
        }

        private void simular_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                generar();
            }
        }

        private void generar()
        {
            var form = new Tabla_Colas.tablaSimulacion(this.iteraciones.Value, this.cant_filas.Value, this.fila_desde.Value, this.media.Value, this.desviacion.Value, this.tiempo_compra.Value, this.tiempo_entrega.Value, this.inf_consumision.Value, this.sup_consumision.Value, this.inf_utilizacion.Value, this.sup_utilizacion.Value);
            form.ShowDialog();
        }

        private bool validar()
        {
            if (fila_desde.Value + cant_filas.Value - 1 <= iteraciones.Value)
            {
                return true;
            }
            else
            {
                MessageBox.Show("El numero de filas a mostrar tiene que ser menor a la cantidad de iteraciones", "Alerta", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
