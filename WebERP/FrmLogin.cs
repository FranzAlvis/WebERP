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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            CBcompa.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                FrmPrincipal fp = new FrmPrincipal();
                fp.lblDemo.Text = txtUsuario.Text;
                fp.Show();
                this.Close();
            }
        }

        private bool validar()
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, string.Empty);
            erpClave.SetError(txtClave, string.Empty);
            erpcomp.SetError(CBcompa, string.Empty);
            
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El usuario es obligatorio"); 
                esValido = false;
            }

            if (string.IsNullOrEmpty(txtClave.Text))
            {
                erpClave.SetError(txtClave, "La clave es obligatoria"); 
                esValido = false;
            }
            if (string.IsNullOrEmpty(CBcompa.Text))
            {
                erpcomp.SetError(CBcompa, "La sucursal es obligatoria");
                esValido = false;
            }
            return esValido;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            new OlvidasteContra().ShowDialog();
        }
    }
}
