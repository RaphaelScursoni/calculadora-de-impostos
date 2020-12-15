using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos
{
    class PessoaJuridica : Pessoa
    {
        public int NFuncionarios { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(int nFuncionarios, string nome, double rendaAnual)
            : base (nome, rendaAnual)
        {
            NFuncionarios = nFuncionarios;
        }

        double imposto;
        public override double Imposto()
        {
            if (NFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else 
            {
                imposto = RendaAnual * 0.16;
            }
            return imposto;
        }
    }
}
