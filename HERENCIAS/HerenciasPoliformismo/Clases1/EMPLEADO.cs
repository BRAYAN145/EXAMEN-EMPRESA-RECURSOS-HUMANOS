using System;
using System.Collections.Generic;
using System.Text;

namespace Clases1
{
    public class EMPLEADO : PESONA
    {
        //ATRIBUTOS
        private string TIPO;
        private string TIPOCONTRATO;
        private double SUELDO;
        //PROPIEDADES
        public string TIPO1
        {
            get => TIPO; 
            set => TIPO = value;
        }
        public string TIPOCONTRATO1 
        { 
            get => TIPOCONTRATO;
            set => TIPOCONTRATO = value;
        }
        public double SUELDO1 
        { 
            get => SUELDO;
            set => SUELDO = value; 
        }
        //PROCEDIMIENTOS, OPERACIONES O METODOS
        public void CALCULARSUELDO(Double SUELDOBASE)
        {
            if(this.TIPO1=="GERENTE")
            {
                if (this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 1500;
                }
            }
            else if (this.TIPO1 =="VENDEDOR")
            {
                if (this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = SUELDOBASE + 1500;
                }
            }
            
            else
            {
                this.SUELDO1 = 0;
            }

        }

    }
}
