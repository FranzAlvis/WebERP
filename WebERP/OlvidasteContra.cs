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
    public partial class OlvidasteContra : Form
    {
        public OlvidasteContra()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                MessageBox.Show("Se le envio un mensaje a su Correo Electronico");
                Hide();
                new FrmLogin().ShowDialog();
            }
        }

        private bool validar()
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, string.Empty);
            erpClave.SetError(CBcompa, string.Empty);
            

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El usuario es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrEmpty(CBcompa.Text))
            {
                erpClave.SetError(CBcompa, "La sucursal es obligatoria");
                esValido = false;
            }
            
            return esValido;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            new FrmLogin().ShowDialog();
        }
    }
}
