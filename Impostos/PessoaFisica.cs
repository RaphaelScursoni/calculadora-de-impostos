using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos
{
    class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }


        public PessoaFisica() { }

        public PessoaFisica(double gastoSaude, string nome, double rendaAnual)
            : base (nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        double imposto;
        public override double Imposto()
        {
            if(RendaAnual <= 20000)
            {
               imposto = (RendaAnual * 0.15) - (GastoSaude * 0.5);
            }else if(RendaAnual > 20000)
            {
                imposto = (RendaAnual * 0.25) - (GastoSaude * 0.5);
            }
            return imposto;
        }

        
    }
}
