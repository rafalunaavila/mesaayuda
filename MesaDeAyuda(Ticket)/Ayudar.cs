using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MesaDeAyuda_Ticket_.CapaPD;
using MesaDeAyuda_Ticket_.Conexion;

namespace MesaDeAyuda_Ticket_
{
    public partial class Ayudar : Form
    {
        User user = new User();
        private Timer timUpadate;
        public Ayudar()
        {
            InitializeComponent();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargartodoAyuda()
        {
            User obj = new User();
            DataTable dt = new DataTable();
            dt = obj.verSoli();
            if (dt.Rows.Count > 0)
            {
                llenarLista(dt);
            }
        }

        int numerodetickets = 0, antenumtickets = 0;
        string maxitem = "",maxitemn = "";
        public void descarpciondeproblema()
        {
            User obj = new User();
            DataTable table = new DataTable();

            int totalFilas = 0;
            string Area, Problema, DesProblema;
            
            //String id;
            if (obj.verificaridAlerta(maxitem) == true)
            {
                table = obj.AlertasAll(maxitem);
                totalFilas = table.Rows.Count;
                if (table.Rows.Count <= 0) return;
                var datoPer = table.Rows[0];
                foreach (DataRow xitem in table.Rows)
                {
                    Area = Convert.ToString(xitem["Area"]);
                    Problema = Convert.ToString(xitem["TipoAyuda"]);
                    DesProblema = Convert.ToString(xitem["DesProblema"]);
                    if (Problema == "N/A" || Problema == null){Problema = "";}
                    //if (DesProblema == null){DesProblema = "";}

                    Cls_Libreria.Area1 = Area;
                    Cls_Libreria.Problema1 = Problema;
                    Cls_Libreria.DesProblema1 = DesProblema;
                }
            }
        }

        public void mostrarNotificacion()
        {
            descarpciondeproblema();
            if (numerodetickets > antenumtickets)
            {
                notifyIcon1.BalloonTipTitle = Cls_Libreria.Area1;
                notifyIcon1.BalloonTipText = Cls_Libreria.Problema1 +" "+ Cls_Libreria.DesProblema1;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(0);
               
            }
            antenumtickets = numerodetickets;

        }

        public void llenarLista(DataTable data)
        {
            var list = lsv_Tarea;
            list.Columns.Clear();
            list.Items.Clear();
            list.View = View.Details;
            list.GridLines = false;
            list.Scrollable = true;
            list.FullRowSelect = true;
            list.HideSelection = false;
            list.Columns.Add("ID", 35, HorizontalAlignment.Left);
            list.Columns.Add("Accion", 80, HorizontalAlignment.Left);
            list.Columns.Add("Area", 405, HorizontalAlignment.Left);
            list.Columns.Add("Tipo de ayuda", 180, HorizontalAlignment.Left);
            list.Columns.Add("Problema", 250, HorizontalAlignment.Left);
            list.Columns.Add("User", 70, HorizontalAlignment.Left);
            list.Columns.Add("Estado", 50, HorizontalAlignment.Left);
            lsv_Tarea.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {

                DataRow dr = data.Rows[i];
                ListViewItem lista = new ListViewItem(dr["idtickets"].ToString());
                lista.SubItems.Add(dr["Accion"].ToString());
                lista.SubItems.Add(dr["Area"].ToString());
                lista.SubItems.Add(dr["TipoAyuda"].ToString());
                lista.SubItems.Add(dr["DesProblema"].ToString());
                lista.SubItems.Add(dr["User"].ToString());
                lista.SubItems.Add(dr["Estado"].ToString());
                lsv_Tarea.Items.Add(lista);
            }
            lbl_conteo.Text = Convert.ToString(lsv_Tarea.Items.Count);           
            numerodetickets = Convert.ToInt32(lbl_conteo.Text);
            maxitem = Convert.ToString(lsv_Tarea.TopItem.Text);
            mostrarNotificacion();
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            CargartodoAyuda();
        }


        private void Ayudar_Load(object sender, EventArgs e)
        {
            timUpadate = new Timer();
            timUpadate.Interval = 1000;
            timUpadate.Tick += new EventHandler(timUpdate_Tick);
            timUpadate.Start();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea Salir del Sistema?", "Informe del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Login log = new Login();
                log.Show();
            }
        }

        private void timUpdate_Tick(object sender, EventArgs e)
        {
            CargartodoAyuda();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string idTicket = txt_idsend.Text;
            user.ResolverAyuda(idTicket);
            txt_idsend.Text = "";
        }
    }
}
