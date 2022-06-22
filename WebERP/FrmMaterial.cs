using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebERP
{
    public partial class FrmMaterial : Form
    {
        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1396, 752);
            gbxDatos.Enabled = true;
            gbxLista.Enabled = false;
            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                MessageBox.Show($"Material guardado correctamente.", "::: Material - Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private bool validar()
        {
            bool esValido = true;
            erpCodigo.SetError(txtCodigo, string.Empty);
            erpDescripcion.SetError(txtDescripcion, string.Empty);
            erpPrecio.SetError(txtPrecio, string.Empty);
            erpSaldo.SetError(txtSaldo, string.Empty);
            erpUnidad.SetError(txtUnidad, string.Empty);

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                erpCodigo.SetError(txtCodigo, "El Código es obligatorio"); esValido = false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                erpDescripcion.SetError(txtDescripcion, "La descripción es obligatoria"); esValido = false;
            }

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                erpPrecio.SetError(txtPrecio, "El precio es obligatorio"); esValido = false;
            }

            if (string.IsNullOrEmpty(txtSaldo.Text))
            {
                erpSaldo.SetError(txtSaldo, "El saldo es obligatorio"); esValido = false;
            }

            if (string.IsNullOrEmpty(txtUnidad.Text))
            {
                erpUnidad.SetError(txtUnidad, "La unidad es obligatoria"); esValido = false;
            }
            return esValido;
        }

        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtSaldo.Text = string.Empty;
            txtUnidad.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1396, 424);
            gbxDatos.Enabled = false;
            gbxLista.Enabled = true;
            limpiar();
            txtParametro.Focus();
        }
    }
}
