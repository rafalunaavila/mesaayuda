using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MesaDeAyuda_Ticket_.CapaPD;
using System.IO;



namespace MesaDeAyuda_Ticket_
{
    public partial class Ayuda : Form
    {
        User user = new User();        
        public Ayuda()
        {
            InitializeComponent();
            cbo_Accion.SelectedItem = "N/A";
            cbo_Tayuda.SelectedItem = 1;
            cbo_Area.SelectedItem = "N/A";
     
            lbl_Fecha.Text = DateTime.Now.ToString("dddd, dd MMM");
            pnl_Incidente.Size = new Size(644, 80);
            pnl_Incidente.Visible = false;
            cbo_Tayuda.Visible = false;
            lbl_tAyuda.Visible = false;
            txt_Problema.Visible = false;
            lbl_Solicitud.Visible = false;
            lbl_Problema.Visible = false;
            txt_Problema.Visible = false;
            txt_pSolucion.Visible = false;
            this.AutoSize = true;
            lbl_seSoliciono.Visible = false;
            btn_check.Visible = false;
            btn_cross.Visible = false;
            lbl_send.Visible = false;
            btn_send.Visible = false;

            //this.Size = new Size(687,170);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbo_Accion_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Save the selected employee's name, because we will remove
            // the employee's name from the list.
            string selectedEmployee = (string)cbo_Accion.SelectedItem;
            if (cbo_Accion.SelectedIndex == 0)
            {
                //this.Size = new Size(687, 200);
                pnl_Incidente.Visible = true;
                pnl_Incidente.Size = new Size(644, 50);   
                cbo_Tayuda.Visible = true;
                lbl_tAyuda.Visible = true;
                txt_Problema.Visible = false;
                lbl_Solicitud.Visible = false;
                txt_pSolucion.Visible = false;
                lbl_pSolucion.Visible = false;
                lbl_seSoliciono.Visible = false;
                btn_check.Visible = false;
                btn_cross.Visible = false;
                
            }
            else
            {
                pnl_Incidente.Visible = true;
                pnl_Incidente.Size = new Size(644, 80);
                txt_Problema.Location = new Point(88, 9);
                cbo_Tayuda.Visible = false;
                lbl_tAyuda.Visible = false;
                txt_Problema.Visible = true;
                lbl_Solicitud.Visible = true;
                txt_pSolucion.Visible = false;
                lbl_pSolucion.Visible = false;
                lbl_Problema.Visible = false;
                btn_send.Visible = true;
                lbl_send.Visible = true;
            }

            int count = 0;
            int resultIndex = -1;

            // Call the FindStringExact method to find the first 
            // occurrence in the list.
            resultIndex = cbo_Accion.FindStringExact(selectedEmployee);

            // Remove the name as it is found, and increment the found count. 
            // Then call the FindStringExact method again, passing in the 
            // index of the current found item so the search starts there 
            // instead of at the beginning of the list.
           
            // Update the text in Textbox1.
        }

        private void cbo_Tayuda_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbo_Tayuda.SelectedIndex)
        {
            case 0:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
            case 1:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
            case 2:
                    lbl_pSolucion.Visible = true;   
                pnl_Incidente.Size = new Size(644, 130); 
                txt_pSolucion.Visible = true;
                txt_pSolucion.Text = "1.- REVISE LA CONEXIÓN DE CABLE DE AMBAS PUERTOS (DE LA COMPUTADORA Y  DEL NODO)." + "\r\n"
                                    + "2.- CONECTE Y DESCONECTE EL CABLE ETHERNET." + "\r\n"
                                    + "3.- REINICIE LA COMPUTADORA.";
                    lbl_Problema.Visible = false;
                    txt_Problema.Visible = false;
                    txt_Problema.Text = "";
                    lbl_seSoliciono.Visible = true;
                    btn_check.Visible = true;
                    btn_cross.Visible = true;
                    lbl_send.Visible = false;
                    btn_send.Visible = false ;
                
                    break;                       
            case 3:                              
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true; 
                    txt_Problema.Visible = true; 
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
                   
            case 4:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
            case 5:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
                case 6:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
                case 7:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
                case 8:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
                case 9:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
                case 10:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
                case 11:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
                case 12:
                    pnl_Incidente.Size = new Size(644, 130);
                    txt_pSolucion.Visible = false;
                    lbl_Problema.Location = new Point(13, 50);
                    txt_Problema.Location = new Point(88, 50);
                    lbl_Problema.Visible = true;
                    txt_Problema.Visible = true;
                    lbl_pSolucion.Visible = false;
                    txt_Problema.Text = "";
                    lbl_send.Visible = true;
                    btn_send.Visible = true;
                    lbl_seSoliciono.Visible = false;
                    btn_check.Visible = false;
                    btn_cross.Visible = false;
                    break;
                default:
                    cbo_Tayuda.Text = "Seleccione";
                    break;
        }
        }

        private void lbl_pSolucion_Click(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar las opciones sugeridas =)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            pnl_Incidente.Size = new Size(644, 150);
            txt_pSolucion.Visible = false;
            lbl_Problema.Location = new Point(13, 50);
            txt_Problema.Location = new Point(88, 50);
            lbl_Problema.Visible = true;
            txt_Problema.Visible = true;
            lbl_pSolucion.Visible = false;
            txt_Problema.Text = "";
            lbl_seSoliciono.Visible = false;
            btn_check.Visible = false;
            btn_cross.Visible = false;
            btn_send.Visible = true;
            lbl_send.Visible = true;
        }

        private void cbo_Accion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_Tayuda.Text = "Seleccione";
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            if(cbo_Accion.SelectedItem == null || cbo_Area.SelectedItem == null)
            {
                MessageBox.Show("Llena todos los campos", "Informe del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(cbo_Tayuda.SelectedItem == null)
            {
                string usernom = Cls_Libreria.User1;
                string accion = cbo_Accion.SelectedItem.ToString();
                string area = cbo_Area.SelectedItem.ToString();
                string ayuda = cbo_Tayuda.ValueMember = "N/A";
                string problema = txt_Problema.Text.ToString();
                user.InsrtAyuda(accion, area, ayuda, problema.ToUpper(), usernom);
            }
            else
            {
                string usernom = Cls_Libreria.User1;
                string accion = cbo_Accion.SelectedItem.ToString();
                string area = cbo_Area.SelectedItem.ToString();
                string ayuda = cbo_Tayuda.SelectedItem.ToString();
                string problema = txt_Problema.Text.ToString();
                user.InsrtAyuda(accion, area, ayuda, problema.ToUpper(), usernom);

            }
           
            MessageBox.Show("Gracias por usar el sistema " + Cls_Libreria.User1 +" =)" , "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }
        string imge = @"\scorpio_mini.png";

        private void Ayuda_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void lbl_Fecha_MouseMove(object sender, MouseEventArgs e)
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
    }
}
