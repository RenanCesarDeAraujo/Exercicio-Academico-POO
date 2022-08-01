using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17
{
    class FuncionarioPeao:Funcionario
    {
        public double HoraExtraEmReais { get; set; }
        public override double CalculaSalario()
        {
            return (Salario + HoraExtraEmReais);
        }
        public override string ToString()
        {
            return base.ToString()+ "peão" + Environment.NewLine;
        }
    }
}
