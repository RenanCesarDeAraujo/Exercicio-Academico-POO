using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17
{
    class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalculaSalario()
        {
            return Salario;
        }

        public virtual string ToString()
        {
            return "Código: "+ Codigo + Environment.NewLine +
                "Nome: " + Nome +Environment.NewLine+
                "Salário: "+ CalculaSalario() +Environment.NewLine;
        }
    }
}
