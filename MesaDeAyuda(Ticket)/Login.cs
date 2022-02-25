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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '*';
            
        }

        int veces = 0;
        private void AccederalSistema()
        {
            User obj = new User();
            DataTable table = new DataTable();
           
            String usu, pass;
          
            usu = txt_user.Text.Trim();
            pass = txt_pass.Text.Trim();
            Cls_Libreria.User1 = usu;
            if (obj.Login(usu, pass) == true)
            {
                Cls_Libreria.User1 = usu;
                if (usu == "root")
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido al sistema " + usu, "Informe del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Ayudar ayudar = new Ayudar();
                    ayudar.Show();
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido al sistema " + usu, "Informe del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Ayuda ayuda = new Ayuda();
                    ayuda.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contrseña incorrectos", "Advetrencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_pass.Text = "";
                txt_user.Text = "";
                txt_user.Focus();
                veces += 1;
                if (veces == 3)
                {
                    MessageBox.Show("El numero maximo de intentos fue superado", "Advetrencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }

        }


 
        private void btn_login_Click(object sender, EventArgs e)
        {
            AccederalSistema();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
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
    }
}
