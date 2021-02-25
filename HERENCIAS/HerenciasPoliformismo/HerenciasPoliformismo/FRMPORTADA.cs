using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciasPoliformismo
{
    public partial class FRMPORTADA : Form
    {
        public FRMPORTADA()
        {
            InitializeComponent();
        }
        public static void Main()
        {
            HerenciasPoliformismo.FRMPORTADA PORTADA = new HerenciasPoliformismo.FRMPORTADA();
            PORTADA.ShowDialog();

        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            HerenciasPoliformismo.FRMCLIENTES CLIENTE = new HerenciasPoliformismo.FRMCLIENTES();
            CLIENTE.Show();

        }

        private void BtnEmpledo_Click(object sender, EventArgs e)
        {
            HerenciasPoliformismo.FRMEMPLEADOS EMPLEADOS = new HerenciasPoliformismo.FRMEMPLEADOS();
            EMPLEADOS.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
