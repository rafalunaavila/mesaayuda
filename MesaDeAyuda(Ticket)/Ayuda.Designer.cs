
namespace MesaDeAyuda_Ticket_
{
    partial class Ayuda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Accion = new System.Windows.Forms.ComboBox();
            this.cbo_Area = new System.Windows.Forms.ComboBox();
            this.lbl_tAyuda = new System.Windows.Forms.Label();
            this.cbo_Tayuda = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Incidente = new System.Windows.Forms.Panel();
            this.btn_check = new System.Windows.Forms.Button();
            this.lbl_seSoliciono = new System.Windows.Forms.Label();
            this.btn_cross = new System.Windows.Forms.Button();
            this.lbl_Problema = new System.Windows.Forms.Label();
            this.lbl_pSolucion = new System.Windows.Forms.Label();
            this.txt_pSolucion = new System.Windows.Forms.TextBox();
            this.lbl_Solicitud = new System.Windows.Forms.Label();
            this.txt_Problema = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_send = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnl_Incidente.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Coolvetica Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "INCIDETES Y SOLICITUDES ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Coolvetica Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_Fecha.Location = new System.Drawing.Point(486, 5);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(48, 19);
            this.lbl_Fecha.TabIndex = 1;
            this.lbl_Fecha.Text = "Fecha";
            this.lbl_Fecha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Fecha_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Coolvetica Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Accion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Coolvetica Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area:";
            // 
            // cbo_Accion
            // 
            this.cbo_Accion.Font = new System.Drawing.Font("Coolvetica Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Accion.FormattingEnabled = true;
            this.cbo_Accion.Items.AddRange(new object[] {
            "INCIDENTE ",
            "SOLICITUD "});
            this.cbo_Accion.Location = new System.Drawing.Point(74, 11);
            this.cbo_Accion.Name = "cbo_Accion";
            this.cbo_Accion.Size = new System.Drawing.Size(121, 27);
            this.cbo_Accion.TabIndex = 4;
            this.cbo_Accion.Text = "Selecciona";
            this.cbo_Accion.SelectedIndexChanged += new System.EventHandler(this.cbo_Accion_SelectedIndexChanged);
            this.cbo_Accion.SelectedValueChanged += new System.EventHandler(this.cbo_Accion_SelectedValueChanged);
            // 
            // cbo_Area
            // 
            this.cbo_Area.Font = new System.Drawing.Font("Coolvetica Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Area.FormattingEnabled = true;
            this.cbo_Area.Items.AddRange(new object[] {
            "DIRECCIÓN GENERAL",
            "MCYSCP",
            "VINCULACIÓN CON INSTITUCIONES Y SOCIEDAD CIVIL",
            "COORDINACIÓN DE EJECUCIÓN PENAL",
            "UNIDAD DE ARCHIVO Y ESTADÍSTICA",
            "COORDINACIÓN DE SERVICIOS LEGALES",
            "COORDINACIÓN DE LIBERTAD CONDICIONAL",
            "UNIDAD ESPECIALIZADA DE SEGUIMIENTO DE PERSONAS ADOLESCENTES",
            "ÁREA PSICOLÓGICA",
            "DEPARTAMENTO DE ADMINISTRACIÓN",
            "COORDINACIÓN OPERATIVA"});
            this.cbo_Area.Location = new System.Drawing.Point(74, 44);
            this.cbo_Area.Name = "cbo_Area";
            this.cbo_Area.Size = new System.Drawing.Size(424, 27);
            this.cbo_Area.TabIndex = 5;
            this.cbo_Area.Text = "Selecciona ";
            // 
            // lbl_tAyuda
            // 
            this.lbl_tAyuda.AutoSize = true;
            this.lbl_tAyuda.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tAyuda.Location = new System.Drawing.Point(4, 18);
            this.lbl_tAyuda.Name = "lbl_tAyuda";
            this.lbl_tAyuda.Size = new System.Drawing.Size(88, 16);
            this.lbl_tAyuda.TabIndex = 6;
            this.lbl_tAyuda.Text = "Tipo de Ayuda:";
            // 
            // cbo_Tayuda
            // 
            this.cbo_Tayuda.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Tayuda.FormattingEnabled = true;
            this.cbo_Tayuda.Items.AddRange(new object[] {
            "ACTUALIZACIÓN DE SOFTWARE",
            "CONFIGURACIÓN DE SOFTWARE",
            "REVISIÓN DE INTERNET",
            "APOYO OFIMÁTICO",
            "BIOMÉTRICO",
            "ADMINISTRACIÓN DE CUENTAS",
            "REVISIÓN DE IMPRESORA",
            "MOVIMIENTO DE COMPUTADORA",
            "REVISIÓN DE COMPUTADORA",
            "INSTALACIÓN DE CAÑON",
            "REVISIÓN DE ESCANER",
            "BÚSQUEDA DE DOCUMENTO",
            "FORMATEO"});
            this.cbo_Tayuda.Location = new System.Drawing.Point(96, 15);
            this.cbo_Tayuda.Name = "cbo_Tayuda";
            this.cbo_Tayuda.Size = new System.Drawing.Size(424, 24);
            this.cbo_Tayuda.TabIndex = 7;
            this.cbo_Tayuda.Text = "Selcciona";
            this.cbo_Tayuda.SelectedValueChanged += new System.EventHandler(this.cbo_Tayuda_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cbo_Area);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbo_Accion);
            this.panel1.Location = new System.Drawing.Point(15, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 75);
            this.panel1.TabIndex = 9;
            // 
            // pnl_Incidente
            // 
            this.pnl_Incidente.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Incidente.Controls.Add(this.btn_check);
            this.pnl_Incidente.Controls.Add(this.lbl_seSoliciono);
            this.pnl_Incidente.Controls.Add(this.btn_cross);
            this.pnl_Incidente.Controls.Add(this.lbl_Problema);
            this.pnl_Incidente.Controls.Add(this.lbl_pSolucion);
            this.pnl_Incidente.Controls.Add(this.txt_pSolucion);
            this.pnl_Incidente.Controls.Add(this.lbl_Solicitud);
            this.pnl_Incidente.Controls.Add(this.txt_Problema);
            this.pnl_Incidente.Controls.Add(this.cbo_Tayuda);
            this.pnl_Incidente.Controls.Add(this.lbl_tAyuda);
            this.pnl_Incidente.Location = new System.Drawing.Point(14, 122);
            this.pnl_Incidente.Name = "pnl_Incidente";
            this.pnl_Incidente.Size = new System.Drawing.Size(644, 160);
            this.pnl_Incidente.TabIndex = 10;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.SystemColors.Control;
            this.btn_check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_check.BackgroundImage")));
            this.btn_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_check.Location = new System.Drawing.Point(238, 105);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(22, 19);
            this.btn_check.TabIndex = 12;
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_seSoliciono
            // 
            this.lbl_seSoliciono.AutoSize = true;
            this.lbl_seSoliciono.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seSoliciono.Location = new System.Drawing.Point(84, 106);
            this.lbl_seSoliciono.Name = "lbl_seSoliciono";
            this.lbl_seSoliciono.Size = new System.Drawing.Size(156, 16);
            this.lbl_seSoliciono.TabIndex = 11;
            this.lbl_seSoliciono.Text = "¿Se solucionó su problema?";
            // 
            // btn_cross
            // 
            this.btn_cross.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cross.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cross.BackgroundImage")));
            this.btn_cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cross.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cross.Location = new System.Drawing.Point(273, 104);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(22, 19);
            this.btn_cross.TabIndex = 10;
            this.btn_cross.UseVisualStyleBackColor = false;
            this.btn_cross.Click += new System.EventHandler(this.btn_cross_Click);
            // 
            // lbl_Problema
            // 
            this.lbl_Problema.AutoSize = true;
            this.lbl_Problema.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Problema.Location = new System.Drawing.Point(13, 31);
            this.lbl_Problema.Name = "lbl_Problema";
            this.lbl_Problema.Size = new System.Drawing.Size(70, 32);
            this.lbl_Problema.TabIndex = 9;
            this.lbl_Problema.Text = "Describa su\r\nProblema";
            // 
            // lbl_pSolucion
            // 
            this.lbl_pSolucion.AutoSize = true;
            this.lbl_pSolucion.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pSolucion.Location = new System.Drawing.Point(11, 64);
            this.lbl_pSolucion.Name = "lbl_pSolucion";
            this.lbl_pSolucion.Size = new System.Drawing.Size(68, 32);
            this.lbl_pSolucion.TabIndex = 0;
            this.lbl_pSolucion.Text = "Posibles \r\nSoluciones;";
            this.lbl_pSolucion.Click += new System.EventHandler(this.lbl_pSolucion_Click);
            // 
            // txt_pSolucion
            // 
            this.txt_pSolucion.BackColor = System.Drawing.Color.Gold;
            this.txt_pSolucion.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pSolucion.Location = new System.Drawing.Point(98, 38);
            this.txt_pSolucion.Multiline = true;
            this.txt_pSolucion.Name = "txt_pSolucion";
            this.txt_pSolucion.Size = new System.Drawing.Size(535, 65);
            this.txt_pSolucion.TabIndex = 1;
            // 
            // lbl_Solicitud
            // 
            this.lbl_Solicitud.AutoSize = true;
            this.lbl_Solicitud.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Solicitud.Location = new System.Drawing.Point(11, 19);
            this.lbl_Solicitud.Name = "lbl_Solicitud";
            this.lbl_Solicitud.Size = new System.Drawing.Size(62, 32);
            this.lbl_Solicitud.TabIndex = 8;
            this.lbl_Solicitud.Text = "Escriba su\r\nSolicitud\r\n";
            // 
            // txt_Problema
            // 
            this.txt_Problema.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Problema.Location = new System.Drawing.Point(88, 9);
            this.txt_Problema.Multiline = true;
            this.txt_Problema.Name = "txt_Problema";
            this.txt_Problema.Size = new System.Drawing.Size(536, 64);
            this.txt_Problema.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.White;
            this.btn_send.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_send.BackgroundImage")));
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_send.Location = new System.Drawing.Point(624, 279);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(31, 23);
            this.btn_send.TabIndex = 11;
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lbl_send
            // 
            this.lbl_send.AutoSize = true;
            this.lbl_send.BackColor = System.Drawing.Color.White;
            this.lbl_send.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_send.Location = new System.Drawing.Point(584, 284);
            this.lbl_send.Name = "lbl_send";
            this.lbl_send.Size = new System.Drawing.Size(40, 16);
            this.lbl_send.TabIndex = 12;
            this.lbl_send.Text = "Enviar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.btn_Salir);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_Fecha);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 29);
            this.panel2.TabIndex = 13;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(645, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(20, 25);
            this.btn_Salir.TabIndex = 14;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 29);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(671, 305);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_send);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.pnl_Incidente);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesa de ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Incidente.ResumeLayout(false);
            this.pnl_Incidente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Accion;
        private System.Windows.Forms.ComboBox cbo_Area;
        private System.Windows.Forms.Label lbl_tAyuda;
        private System.Windows.Forms.ComboBox cbo_Tayuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Incidente;
        private System.Windows.Forms.TextBox txt_Problema;
        private System.Windows.Forms.Label lbl_Solicitud;
        private System.Windows.Forms.Label lbl_pSolucion;
        private System.Windows.Forms.TextBox txt_pSolucion;
        private System.Windows.Forms.Label lbl_Problema;
        private System.Windows.Forms.Label lbl_seSoliciono;
        private System.Windows.Forms.Button btn_cross;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_send;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button btn_Salir;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

