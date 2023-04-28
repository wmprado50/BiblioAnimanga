using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace BibliotecaAnimanga
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            customizeDesing();
        } 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void customizeDesing()
        {
            panelSubMenuAnime.Visible = false;
            panelSubMenuManga.Visible = false;
            panelSubMenuUsuarios.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenuAnime.Visible == true)
                panelSubMenuAnime.Visible = false;
            if (panelSubMenuManga.Visible == true)
                panelSubMenuManga.Visible = false;
            if (panelSubMenuUsuarios.Visible == true)
                panelSubMenuUsuarios.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 211)
            {
                MenuVertical.Width = 50;
            }
            else
                MenuVertical.Width = 211;
        }
       
      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnMangas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuManga);
        }

        private void btnAnimes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAnime);
        }

        #region RegistrarAnimes
        private void btnRegistrarAnime_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        #region RegistrarGeneroAnime
        private void btnRegistrarGeneroA_Click(object sender, EventArgs e)
        {



            openChildFormInPanel(new frmGeneroAnime());
            hideSubMenu();
        }
        #endregion
        #region RegistrarEstudio
        private void btnRegistrarEstudio_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmEstudioAnime());
            hideSubMenu();
        }
        #endregion
        #region BuscarAnimes
        private void btnBuscarAnimes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        #region RegistrarGeneroManga
        private void btnRegistrarGeneroM_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }
        #endregion
        #region RegistrarAutor
        private void btnRegistrarAutor_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }
        #endregion
        #region RegistrarIlustrador
        private void btnRegistrarIlus_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }
        #endregion
        #region BuscarMangas
        private void btnBuscarMangas_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }
        #endregion

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuUsuarios);
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnBuscarUsuarios_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro de salir de la aplicación?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                Application.Exit();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar sesion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
