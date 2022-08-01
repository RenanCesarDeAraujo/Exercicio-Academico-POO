using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17
{
    class FuncionarioVendedor: Funcionario
    {
        private int porcentagemSobreVendas;
        public double MetaDeVendaMesEmReais { get; set; }
        public double VendasdoMesEmReais { get; set; }
        public int PorcentagemSobreVendas
        {
            get
            {
                return porcentagemSobreVendas;
            }
            set
            {
                if (VendasdoMesEmReais >= MetaDeVendaMesEmReais)
                    porcentagemSobreVendas = value;
                else
                    throw new Exception("A meta de vendas não foi atingida");
            }
        }
        public override double CalculaSalario()
        {
            return Salario + ((Salario * PorcentagemSobreVendas) / 100);
        }
        public override string ToString()
        {
            return base.ToString()+ "Vendedor" + Environment.NewLine;
        }



    }
}
