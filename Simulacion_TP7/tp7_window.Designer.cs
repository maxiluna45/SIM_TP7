
namespace Simulacion_TP7
{
    partial class tp7_window
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fila_desde = new System.Windows.Forms.NumericUpDown();
            this.cant_filas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iteraciones = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.simular = new System.Windows.Forms.Button();
            this.cambiar_p = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.p_probabilidades = new System.Windows.Forms.Panel();
            this.sup_utilizacion = new System.Windows.Forms.NumericUpDown();
            this.inf_utilizacion = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sup_consumision = new System.Windows.Forms.NumericUpDown();
            this.inf_consumision = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.desviacion = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tiempo_entrega = new System.Windows.Forms.NumericUpDown();
            this.tiempo_compra = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.guardar_cambios = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fila_desde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_filas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteraciones)).BeginInit();
            this.p_probabilidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sup_utilizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inf_utilizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup_consumision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inf_consumision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desviacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiempo_entrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiempo_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.fila_desde);
            this.panel1.Controls.Add(this.cant_filas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iteraciones);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.simular);
            this.panel1.Controls.Add(this.cambiar_p);
            this.panel1.Location = new System.Drawing.Point(18, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 254);
            this.panel1.TabIndex = 0;
            // 
            // fila_desde
            // 
            this.fila_desde.Location = new System.Drawing.Point(186, 120);
            this.fila_desde.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.fila_desde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fila_desde.Name = "fila_desde";
            this.fila_desde.Size = new System.Drawing.Size(198, 22);
            this.fila_desde.TabIndex = 7;
            this.fila_desde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cant_filas
            // 
            this.cant_filas.Location = new System.Drawing.Point(186, 72);
            this.cant_filas.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.cant_filas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cant_filas.Name = "cant_filas";
            this.cant_filas.Size = new System.Drawing.Size(198, 22);
            this.cant_filas.TabIndex = 6;
            this.cant_filas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fila Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de filas";
            // 
            // iteraciones
            // 
            this.iteraciones.Location = new System.Drawing.Point(186, 25);
            this.iteraciones.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.iteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iteraciones.Name = "iteraciones";
            this.iteraciones.Size = new System.Drawing.Size(198, 22);
            this.iteraciones.TabIndex = 3;
            this.iteraciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iteraciones";
            // 
            // simular
            // 
            this.simular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simular.Location = new System.Drawing.Point(32, 180);
            this.simular.Name = "simular";
            this.simular.Size = new System.Drawing.Size(165, 43);
            this.simular.TabIndex = 1;
            this.simular.Text = "Simular";
            this.simular.UseVisualStyleBackColor = false;
            this.simular.Click += new System.EventHandler(this.simular_Click);
            // 
            // cambiar_p
            // 
            this.cambiar_p.Location = new System.Drawing.Point(236, 180);
            this.cambiar_p.Name = "cambiar_p";
            this.cambiar_p.Size = new System.Drawing.Size(148, 43);
            this.cambiar_p.TabIndex = 0;
            this.cambiar_p.Text = "Cambiar Probabilidades";
            this.cambiar_p.UseVisualStyleBackColor = true;
            this.cambiar_p.Click += new System.EventHandler(this.cambiar_p_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trabajo Práctico Nº7 - Simulación";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p_probabilidades
            // 
            this.p_probabilidades.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p_probabilidades.Controls.Add(this.label19);
            this.p_probabilidades.Controls.Add(this.label18);
            this.p_probabilidades.Controls.Add(this.label17);
            this.p_probabilidades.Controls.Add(this.label16);
            this.p_probabilidades.Controls.Add(this.sup_utilizacion);
            this.p_probabilidades.Controls.Add(this.inf_utilizacion);
            this.p_probabilidades.Controls.Add(this.label15);
            this.p_probabilidades.Controls.Add(this.label14);
            this.p_probabilidades.Controls.Add(this.label13);
            this.p_probabilidades.Controls.Add(this.sup_consumision);
            this.p_probabilidades.Controls.Add(this.inf_consumision);
            this.p_probabilidades.Controls.Add(this.label12);
            this.p_probabilidades.Controls.Add(this.label11);
            this.p_probabilidades.Controls.Add(this.label10);
            this.p_probabilidades.Controls.Add(this.desviacion);
            this.p_probabilidades.Controls.Add(this.label9);
            this.p_probabilidades.Controls.Add(this.label8);
            this.p_probabilidades.Controls.Add(this.tiempo_entrega);
            this.p_probabilidades.Controls.Add(this.tiempo_compra);
            this.p_probabilidades.Controls.Add(this.label5);
            this.p_probabilidades.Controls.Add(this.label6);
            this.p_probabilidades.Controls.Add(this.media);
            this.p_probabilidades.Controls.Add(this.label7);
            this.p_probabilidades.Controls.Add(this.guardar_cambios);
            this.p_probabilidades.Location = new System.Drawing.Point(511, 12);
            this.p_probabilidades.Margin = new System.Windows.Forms.Padding(20);
            this.p_probabilidades.Name = "p_probabilidades";
            this.p_probabilidades.Size = new System.Drawing.Size(439, 432);
            this.p_probabilidades.TabIndex = 8;
            this.p_probabilidades.Visible = false;
            // 
            // sup_utilizacion
            // 
            this.sup_utilizacion.DecimalPlaces = 2;
            this.sup_utilizacion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.sup_utilizacion.Location = new System.Drawing.Point(304, 324);
            this.sup_utilizacion.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.sup_utilizacion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.sup_utilizacion.Name = "sup_utilizacion";
            this.sup_utilizacion.Size = new System.Drawing.Size(99, 22);
            this.sup_utilizacion.TabIndex = 20;
            this.sup_utilizacion.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // inf_utilizacion
            // 
            this.inf_utilizacion.DecimalPlaces = 2;
            this.inf_utilizacion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inf_utilizacion.Location = new System.Drawing.Point(88, 324);
            this.inf_utilizacion.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.inf_utilizacion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inf_utilizacion.Name = "inf_utilizacion";
            this.inf_utilizacion.Size = new System.Drawing.Size(99, 22);
            this.inf_utilizacion.TabIndex = 19;
            this.inf_utilizacion.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(220, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Superior";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Inferior";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(99, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tiempo utilizacion mesas";
            // 
            // sup_consumision
            // 
            this.sup_consumision.DecimalPlaces = 2;
            this.sup_consumision.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.sup_consumision.Location = new System.Drawing.Point(304, 243);
            this.sup_consumision.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.sup_consumision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.sup_consumision.Name = "sup_consumision";
            this.sup_consumision.Size = new System.Drawing.Size(99, 22);
            this.sup_consumision.TabIndex = 15;
            this.sup_consumision.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // inf_consumision
            // 
            this.inf_consumision.DecimalPlaces = 2;
            this.inf_consumision.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inf_consumision.Location = new System.Drawing.Point(88, 243);
            this.inf_consumision.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.inf_consumision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inf_consumision.Name = "inf_consumision";
            this.inf_consumision.Size = new System.Drawing.Size(99, 22);
            this.inf_consumision.TabIndex = 14;
            this.inf_consumision.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(220, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Superior";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Inferior";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tiempo consumisión";
            // 
            // desviacion
            // 
            this.desviacion.DecimalPlaces = 2;
            this.desviacion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.desviacion.Location = new System.Drawing.Point(304, 59);
            this.desviacion.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.desviacion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.desviacion.Name = "desviacion";
            this.desviacion.Size = new System.Drawing.Size(99, 22);
            this.desviacion.TabIndex = 10;
            this.desviacion.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(206, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Desviación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Media";
            // 
            // tiempo_entrega
            // 
            this.tiempo_entrega.DecimalPlaces = 2;
            this.tiempo_entrega.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tiempo_entrega.Location = new System.Drawing.Point(263, 165);
            this.tiempo_entrega.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.tiempo_entrega.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tiempo_entrega.Name = "tiempo_entrega";
            this.tiempo_entrega.Size = new System.Drawing.Size(99, 22);
            this.tiempo_entrega.TabIndex = 7;
            this.tiempo_entrega.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // tiempo_compra
            // 
            this.tiempo_compra.DecimalPlaces = 2;
            this.tiempo_compra.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tiempo_compra.Location = new System.Drawing.Point(263, 117);
            this.tiempo_compra.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.tiempo_compra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tiempo_compra.Name = "tiempo_compra";
            this.tiempo_compra.Size = new System.Drawing.Size(99, 22);
            this.tiempo_compra.TabIndex = 6;
            this.tiempo_compra.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tiempo entrega pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tiempo compra ticket";
            // 
            // media
            // 
            this.media.DecimalPlaces = 2;
            this.media.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.media.Location = new System.Drawing.Point(88, 59);
            this.media.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.media.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(99, 22);
            this.media.TabIndex = 3;
            this.media.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tiempo llegada";
            // 
            // guardar_cambios
            // 
            this.guardar_cambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guardar_cambios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guardar_cambios.Location = new System.Drawing.Point(36, 366);
            this.guardar_cambios.Name = "guardar_cambios";
            this.guardar_cambios.Size = new System.Drawing.Size(357, 43);
            this.guardar_cambios.TabIndex = 0;
            this.guardar_cambios.Text = "Guardar cambios";
            this.guardar_cambios.UseVisualStyleBackColor = false;
            this.guardar_cambios.Click += new System.EventHandler(this.guardar_cambios_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(368, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "seg.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(286, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 20);
            this.label17.TabIndex = 22;
            this.label17.Text = "exp(-)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(368, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "seg.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(290, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 20);
            this.label19.TabIndex = 24;
            this.label19.Text = "cte";
            // 
            // tp7_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(988, 523);
            this.Controls.Add(this.p_probabilidades);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "tp7_window";
            this.Text = "tp7_window";
            this.Load += new System.EventHandler(this.tp7_window_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fila_desde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_filas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteraciones)).EndInit();
            this.p_probabilidades.ResumeLayout(false);
            this.p_probabilidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sup_utilizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inf_utilizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup_consumision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inf_consumision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desviacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiempo_entrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiempo_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button simular;
        private System.Windows.Forms.Button cambiar_p;
        private System.Windows.Forms.NumericUpDown fila_desde;
        private System.Windows.Forms.NumericUpDown cant_filas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown iteraciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel p_probabilidades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown tiempo_entrega;
        private System.Windows.Forms.NumericUpDown tiempo_compra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown media;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button guardar_cambios;
        private System.Windows.Forms.NumericUpDown desviacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown sup_consumision;
        private System.Windows.Forms.NumericUpDown inf_consumision;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown sup_utilizacion;
        private System.Windows.Forms.NumericUpDown inf_utilizacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}