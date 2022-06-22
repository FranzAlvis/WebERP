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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1396, 752);
            gbxDatos.Enabled = true;
            gbxLista.Enabled = false;
            txtNit.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                MessageBox.Show($"Proveedor guardado correctamente.", "::: Proveedor - Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private bool validar()
        {
            bool esValido = true;
            erpNit.SetError(txtNit, string.Empty);
            erpRazonSocial.SetError(txtRazonSocial, string.Empty);
            erpRepresentante.SetError(txtRepresentante, string.Empty);
            erpDireccion.SetError(txtDireccion, string.Empty);
            erpTelefono.SetError(txtTelefono, string.Empty);

            if (string.IsNullOrEmpty(txtNit.Text))
            {
                erpNit.SetError(txtNit, "El NIT es obligatorio"); esValido = false;
            }

            if (string.IsNullOrEmpty(txtRazonSocial.Text))
            {
                erpRazonSocial.SetError(txtRazonSocial, "La Razón Social es obligatorio"); esValido = false;
            }

            if (string.IsNullOrEmpty(txtRepresentante.Text))
            {
                erpRepresentante.SetError(txtRepresentante, "El Representante es obligatorio"); esValido = false;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                erpDireccion.SetError(txtDireccion, "La Dirección es obligatorio"); esValido = false;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                erpTelefono.SetError(txtTelefono, "El Teléfono es obligatorio"); esValido = false;
            }
            return esValido;
        }

        private void limpiar()
        {
            txtNit.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtRepresentante.Text = string.Empty;
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
