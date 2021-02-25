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
    public partial class FRMEMPLEADOS : Form
    {
        public FRMEMPLEADOS()
        {
            InitializeComponent();
        }

        private void LblTipoEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Clases1.EMPLEADO EMPLEADO1 = new Clases1.EMPLEADO();
            EMPLEADO1.APPARTENO1 = TxtApPaterno.Text;
            EMPLEADO1.APMATERNO1 = TxtApMaterno.Text;
            EMPLEADO1.NOMBRES1 = TxtNombres.Text;
            EMPLEADO1.SEXO1 = CboSexo.Text;
            EMPLEADO1.NUMEROSEGURIDADSOCIAL1 = TxtNumSegSoc.Text;
            EMPLEADO1.TIPO1 = CboTipoEmpleado.Text;
            EMPLEADO1.TIPOCONTRATO1 = CboTipoContrato.Text;
            EMPLEADO1.CALCULARSUELDO(1250);
            DGVEMPLEADOS.Rows.Insert(0, EMPLEADO1.APPARTENO1, EMPLEADO1.APMATERNO1, EMPLEADO1.NOMBRES1, EMPLEADO1.SEXO1, EMPLEADO1.NUMEROSEGURIDADSOCIAL1, EMPLEADO1.TIPO1, EMPLEADO1.TIPOCONTRATO1, EMPLEADO1.SUELDO1);

        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
