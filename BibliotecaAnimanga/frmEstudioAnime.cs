using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace BibliotecaAnimanga
{
    public partial class frmEstudioAnime : Form
    {
        public frmEstudioAnime()
        {
            InitializeComponent();
            gbdatosestAni.Enabled = false;
            ListarEstudioAnime();
            dgvEstudioAnime.ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarVariables()
        {
            txtidestAni.Text = " ";
            txtnomestAni.Text = " ";
            txtdescestAni.Text = " ";
        }

        private void frmGeneroAnime_Load(object sender, EventArgs e)
        {

        }

        public void ListarEstudioAnime()
        {
            dgvEstudioAnime.DataSource = logEstudioAnime.Instancia.ListarEstudioAnime();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbdatosestAni.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
            btnRetirar.Visible = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtidestAni.Enabled = true;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbdatosestAni.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            btnRetirar.Visible = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtidestAni.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbdatosestAni.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnRetirar.Visible = true;
            txtidestAni.Enabled = true;
            txtnomestAni.Enabled = false;
            txtdescestAni.Enabled = false;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                entEstudioAnime estAni =new entEstudioAnime();
                estAni.nombre_estAni = txtnomestAni.Text.Trim();
                estAni.descripcion_estAni = txtdescestAni.Text.Trim();
                logEstudioAnime.Instancia.InsertarEstudioAnime(estAni);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbdatosestAni.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            ListarEstudioAnime();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                entEstudioAnime estAni = new entEstudioAnime();
                estAni.id_estAni = int.Parse(txtidestAni.Text.Trim());
                logEstudioAnime.Instancia.EliminarEstudioAnime(estAni);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Visible = true;
            btnRetirar.Visible = true;
            btnModificar.Visible = true;
            txtidestAni.Enabled = false;
            txtnomestAni.Enabled = true;
            txtdescestAni.Enabled = true;
            gbdatosestAni.Enabled = false;
            ListarEstudioAnime();
            dgvEstudioAnime.ReadOnly = true;
        }

        private void dgvGeneroAnime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgvGeneroAnime_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEstudioAnime estAni = new entEstudioAnime();
                estAni.id_estAni = int.Parse(txtidestAni.Text.Trim());
                estAni.nombre_estAni = txtnomestAni.Text.Trim();
                estAni.descripcion_estAni = txtdescestAni.Text.Trim();
                logEstudioAnime.Instancia.EditarEstudioAnime(estAni);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Visible = true;
            btnRetirar.Visible = true;
            btnModificar.Visible = true;
            gbdatosestAni.Enabled = false;
            ListarEstudioAnime();
            dgvEstudioAnime.ReadOnly = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            btnAgregar.Visible = true;
            btnRetirar.Visible = true;
            btnModificar.Visible = true;

            gbdatosestAni.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbdatosgenAni_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEstudioAnime_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvEstudioAnime.Rows[e.RowIndex];
                txtidestAni.Text = filaActual.Cells[0].Value.ToString();
                txtnomestAni.Text = filaActual.Cells[1].Value.ToString();
                txtdescestAni.Text = filaActual.Cells[2].Value.ToString();
            }
        }
    }
}
