using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
namespace BibliotecaAnimanga
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Ingrese usuario aquí") {
                if (txtContraseña.Text != "Ingrese contraseña aquí") {
                    UserModel user = new UserModel();
                    var validlogin = user.LoginUser(txtUsuario.Text,txtContraseña.Text);
                    if (validlogin == true)
                    {
                        Principal frmPrincipal = new Principal();
                        frmPrincipal.Show();
                        frmPrincipal.FormClosed += Logout;

                        this.Hide();

                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrectos. \n  Porfavor vuelva a intentar.");
                        txtUsuario.Clear();
                        txtContraseña.Clear();
                        txtUsuario.Focus();
                    }

                }
                else msgError("Porfavor ingrese contraseña");
                    }
            else msgError("Porfavor ingrese usuario");

            //Principal frmPrincipal = new Principal();
            //frmPrincipal.Show();
            //this.Hide();
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = msg;
            lblErrorMessage.Visible = true;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese usuario aquí")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese usuario aquí";
                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese contraseña aquí")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Ingrese contraseña aquí";
                txtContraseña.ForeColor = Color.DarkGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            lblErrorMessage.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }
    }
}
