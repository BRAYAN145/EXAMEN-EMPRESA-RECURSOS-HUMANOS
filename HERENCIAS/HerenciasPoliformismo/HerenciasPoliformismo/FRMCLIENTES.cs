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
    public partial class FRMCLIENTES : Form
    {
        public FRMCLIENTES()
        {
            InitializeComponent();
        }

        private void GPBCliente_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FRMCLIENTES_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Clases1.CLIENTE CLIENTE1 = new Clases1.CLIENTE();
            CLIENTE1.APPARTENO1 = TxtApPaterno.Text;
            CLIENTE1.APMATERNO1 = TxtApMaterno.Text;
            CLIENTE1.NOMBRES1 = TxtNombres.Text;
            CLIENTE1.SEXO1 = CmbSexo.Text;
            CLIENTE1.NUMEROSEGURIDADSOCIAL1 = TxtNumsegsoc.Text;
            CLIENTE1.CATEGORIA1 = CmbCategoria.Text;
            CLIENTE1.GENERARCODIGODEPEDIDO();
            TxtCodigoPedido.Text = CLIENTE1.CODIGODEPEDIDO1;
            dataGridView1.Rows.Insert(0, CLIENTE1.APPARTENO1, CLIENTE1.APMATERNO1, CLIENTE1.NOMBRES1,CLIENTE1.SEXO1,CLIENTE1.NUMEROSEGURIDADSOCIAL1,CLIENTE1.CATEGORIA1,CLIENTE1.CODIGODEPEDIDO1);
        }

        private void LblSexo_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblApMaterno_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigoPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblCodigoPedido_Click(object sender, EventArgs e)
        {

        }

        private void LblApPaterno_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
