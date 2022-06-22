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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        
        private void AbrirFormHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnMedios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmVentas());
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Hide();
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmIngresos());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmMenuPrincipal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmCompras());
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmGastos());
        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmValores());
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmProduccion());
        }

        private void btnJefe_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormJefeContador());
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmGestorActivos());
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmAjustes());
        }

        private void btnUtilidad_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmUtilidades());
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmTablero());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmClientes());
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmMaterial());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmProveedores());
        }
    }
}
