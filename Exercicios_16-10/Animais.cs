using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_16_10
{
    public class Animais
    {
        private String nome;


        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private String tipo;

        public String Tipo
        {  // tipos = Cachorro, Gato e Peixe.
            get { return tipo; }
            set {
                if (value=="Cachorro" || value=="Gato" || value=="Peixe")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "Peixe";
                }
            }
        }




    }
}