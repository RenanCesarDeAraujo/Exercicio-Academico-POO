using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17
{
    class FuncionarioGerente:Funcionario
    {
        public double BonusEmReais { get; set; }
        public int QtdeFuncionariosSubordinados { get; set; }
        public override double CalculaSalario()
        {
            return (Salario + BonusEmReais);
        }
        public override string ToString()
        {
            return base.ToString()+ "Gerente" + Environment.NewLine;
        }
    }
}
