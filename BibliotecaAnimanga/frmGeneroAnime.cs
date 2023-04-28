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
    public partial class frmGeneroAnime : Form
    {
        public frmGeneroAnime()
        {
            InitializeComponent();
            gbdatosgenAni.Enabled = false;
            ListarGeneroAnime();
            dgvGeneroAnime.ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarVariables()
        {
            txtidgenAni.Text = " ";
            txtnomgenAni.Text = " ";
            txtdescgenAni.Text = " ";
        }

        private void frmGeneroAnime_Load(object sender, EventArgs e)
        {

        }

        public void ListarGeneroAnime()
        {
            dgvGeneroAnime.DataSource = logGeneroAnime.Instancia.ListarGeneroAnime();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbdatosgenAni.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
            btnRetirar.Visible = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtidgenAni.Enabled = true;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbdatosgenAni.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            btnRetirar.Visible = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtidgenAni.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbdatosgenAni.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnRetirar.Visible = true;
            txtidgenAni.Enabled = true;
            txtnomgenAni.Enabled = false;
            txtdescgenAni.Enabled = false;


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
                entGeneroAnime genAni =new entGeneroAnime();
                genAni.nombre_genAni = txtnomgenAni.Text.Trim();
                genAni.descripcion_genAni = txtdescgenAni.Text.Trim();
                logGeneroAnime.Instancia.InsertarGeneroAnime(genAni);
                MessageBox.Show("Se inserto correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbdatosgenAni.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            ListarGeneroAnime();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                entGeneroAnime genAni = new entGeneroAnime();
                genAni.id_genAni = int.Parse(txtidgenAni.Text.Trim());
                logGeneroAnime.Instancia.EliminarGeneroAnime(genAni);
                MessageBox.Show("Se retiro correctamente");
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
            txtidgenAni.Enabled = false;
            txtnomgenAni.Enabled = true;
            txtdescgenAni.Enabled = true;
            gbdatosgenAni.Enabled = false;
            ListarGeneroAnime();
            dgvGeneroAnime.ReadOnly = true;
        }

        private void dgvGeneroAnime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgvGeneroAnime_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvGeneroAnime.Rows[e.RowIndex];
                txtidgenAni.Text = filaActual.Cells[0].Value.ToString();
                txtnomgenAni.Text = filaActual.Cells[1].Value.ToString();
                txtdescgenAni.Text = filaActual.Cells[2].Value.ToString();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entGeneroAnime genAni = new entGeneroAnime();
                genAni.id_genAni = int.Parse(txtidgenAni.Text.Trim());
                genAni.nombre_genAni = txtnomgenAni.Text.Trim();
                genAni.descripcion_genAni = txtdescgenAni.Text.Trim();
                logGeneroAnime.Instancia.EditarGeneroAnime(genAni);
                MessageBox.Show("Se modifico  correctamente");
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
            gbdatosgenAni.Enabled = false;
            ListarGeneroAnime();
            dgvGeneroAnime.ReadOnly = true;
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

            gbdatosgenAni.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
