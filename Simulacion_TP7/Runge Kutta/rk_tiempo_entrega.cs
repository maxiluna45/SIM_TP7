﻿using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_TP7.Runge_Kutta
{
    public partial class rk_tiempo_entrega : Form
    {
        SLDocument oSLDocument = new SLDocument();
        DataTable dt = new DataTable();
        public string pathFile;
        public string archivo;
        public double reloj;
        public double x0;
        public double y0;
        public double h;
        public int tipo_pedido;
        public double valorBuscado;
        public rk_tiempo_entrega(int _tipo_pedido, string _pathFile, double _reloj)
        {
            InitializeComponent();
            añadirColumnas();
            pathFile = _pathFile;
            this.tipo_pedido = _tipo_pedido;
            this.reloj = _reloj;
            archivo = pathFile + $"/excelTiempoPreparacion-" + reloj.ToString("0.00") + ".xlsx";
            this.h = 0.01;
            this.x0 = 0; // El tiempo empieza en t = 0
            this.y0 = 95; // Valor de P(0)
            calcularRK();
        }

        private void añadirColumnas()
        {
            dt.Columns.Add("Valor X", typeof(string));
            dt.Columns.Add("Valor Y", typeof(decimal));
            dt.Columns.Add("dY/dX (K1)", typeof(decimal));
            dt.Columns.Add("K2", typeof(decimal));
            dt.Columns.Add("K3", typeof(decimal));
            dt.Columns.Add("K4", typeof(decimal));
            dt.Columns.Add("Xi+1", typeof(decimal));
            dt.Columns.Add("Yi+1", typeof(decimal));
            dt.Columns.Add("P inicial", typeof(decimal));
            dt.Columns.Add("Tipo Pedido", typeof(decimal));
        }

        private void calcularRK()
        {

            txt_reloj.Text = this.reloj.ToString("0.00");
            txt_tipo_pedido.Text = this.tipo_pedido.ToString("0.00");

            var fila_anterior = new fila_rk();
            fila_anterior.xi1 = this.x0;
            fila_anterior.yi1 = this.y0;

            //imprimirFila(fila_anterior);

            dt.Rows.Add(fila_anterior.x.ToString(), fila_anterior.y, fila_anterior.dy_dx, fila_anterior.K2, fila_anterior.K3, fila_anterior.K4, fila_anterior.xi1, fila_anterior.yi1, this.y0, this.tipo_pedido);


            var fila_actual = new fila_rk();
            do
            {
                fila_actual.x = fila_anterior.xi1;
                fila_actual.y = fila_anterior.yi1;
                fila_actual.dy_dx = -this.tipo_pedido - (0.7 * fila_actual.y);

                fila_actual.a = fila_actual.x * (double)(this.h / 2);
                fila_actual.b = fila_actual.y + ((double)(this.h / 2) * fila_actual.dy_dx);
                fila_actual.K2 = -this.tipo_pedido - (0.7 * fila_actual.b);

                fila_actual.c = fila_actual.x * (double)(this.h / 2);
                fila_actual.d = fila_actual.y + ((double)(this.h / 2) * fila_actual.K2);
                fila_actual.K3 = -this.tipo_pedido - (0.7 * fila_actual.d);

                fila_actual.e = fila_actual.x + this.h;
                fila_actual.f = fila_actual.y + (this.h * fila_actual.K3);
                fila_actual.K4 = -this.tipo_pedido - (0.7 * fila_actual.f);

                fila_actual.xi1 = fila_actual.x + this.h;
                fila_actual.yi1 = fila_actual.y + ((double)(this.h / 6) * (fila_actual.dy_dx + 2 * fila_actual.K2 + 2 * fila_actual.K3 + fila_actual.K4));

                //imprimirFila(fila_actual);

                dt.Rows.Add(fila_actual.x.ToString(), fila_actual.y, fila_actual.dy_dx, fila_actual.K2, fila_actual.K3, fila_actual.K4, fila_actual.xi1, fila_actual.yi1);


                fila_anterior = fila_actual;
            } while (fila_actual.yi1 > 0);
            var t = fila_anterior.x;
            this.valorBuscado = t * 0.1;
            dt.Rows.Add();
            dt.Rows.Add();
            dt.Rows.Add("Valor Buscado", this.valorBuscado);
            oSLDocument.ImportDataTable(1, 1, dt, true);
            oSLDocument.SaveAs(archivo);
        }

        private void imprimirFila(fila_rk fila_imprimir)
        {
            var fila = new string[]

            {
                fila_imprimir.x.ToString(),
                fila_imprimir.y.ToString(),
                fila_imprimir.dy_dx.ToString(),
                fila_imprimir.K2.ToString(),
                fila_imprimir.K3.ToString(),
                fila_imprimir.K4.ToString(),
                fila_imprimir.xi1.ToString(),
                fila_imprimir.yi1.ToString(),

            };
            dgv_rk.Rows.Add(fila);
        }
    }
}