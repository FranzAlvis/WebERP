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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
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
        private bool validar()
        {
            bool esValido = true;
            erpNit.SetError(txtNit, string.Empty);
            erpRazonSocial.SetError(txtRazonSocial, string.Empty);
            erpNombre.SetError(txtNombre, string.Empty);
            erpPaterno.SetError(txtPaterno, string.Empty);
            erpMaterno.SetError(txtMaterno, string.Empty);

            if (string.IsNullOrEmpty(txtNit.Text))
            {
                erpNit.SetError(txtNit, "El NIT es obligatorio"); esValido = false;
            }

            if (string.IsNullOrEmpty(txtRazonSocial.Text))
            {
                erpRazonSocial.SetError(txtRazonSocial, "La Razón Social es obligatorio"); esValido = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpNombre.SetError(txtNombre, "El Nombre es obligatorio"); esValido = false;
            }
            if (string.IsNullOrEmpty(txtPaterno.Text))
            {
                erpPaterno.SetError(txtPaterno, "El apellido paterno es obligatorio"); esValido = false;
            }
            if (string.IsNullOrEmpty(txtMaterno.Text))
            {
                erpMaterno.SetError(txtMaterno, "El apellido materno es obligatorio"); esValido = false;
            }
            return esValido;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1396, 424); 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                
                MessageBox.Show($"Cliente guardado correctamente.", "::: Cliente - Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1396, 424);
            gbxDatos.Enabled = false;
            gbxLista.Enabled = true;
            limpiar();
            txtParametro.Focus();
        }
        private void limpiar()
        {
            txtNit.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPaterno.Text = string.Empty;
            txtMaterno.Text = string.Empty;
        }
    }
}
