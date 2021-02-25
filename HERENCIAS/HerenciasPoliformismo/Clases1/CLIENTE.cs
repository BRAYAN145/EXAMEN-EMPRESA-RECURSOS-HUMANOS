using System;
using System.Collections.Generic;
using System.Text;

namespace Clases1
{
    public class CLIENTE : PESONA
    {
        //ATRIBUTOS
        private string CATEGORIA;
        private string CODIGODEPEDIDO;
        //PROPIEDADES
        public string CATEGORIA1 
        { 
            get => CATEGORIA; 
            set => CATEGORIA = value;
        }
        public string CODIGODEPEDIDO1 
        { 
            get => CODIGODEPEDIDO;
            set => CODIGODEPEDIDO = value;
        }
        //PROCEDIMIENTOS, OPERCIONES O METODOS
        public void GENERARCODIGODEPEDIDO()
        {
            this.CODIGODEPEDIDO1 = "C" + this.APPARTENO1.Substring(0, 3);
        }


    }
}
