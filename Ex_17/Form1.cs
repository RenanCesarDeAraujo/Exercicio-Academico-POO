using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Funcionario> listafunc = new List<Funcionario>();
        private void btnPeao_Click(object sender, EventArgs e)
        {
            FuncionarioPeao peao = new FuncionarioPeao();

            peao.Codigo = Convert.ToInt32(txtCodigo.Text);
            peao.Nome = txtNome.Text;
            peao.Salario = Convert.ToDouble(txtSalario.Text);
            peao.HoraExtraEmReais = Convert.ToDouble(txtHrsExtrasValor.Text);

            listafunc.Add(peao);
            MessageBox.Show("Sucesso");
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            FuncionarioVendedor vendedor = new FuncionarioVendedor();

            vendedor.Codigo = Convert.ToInt32(txtCodigo.Text);
            vendedor.Nome = txtNome.Text;
            vendedor.Salario = Convert.ToDouble(txtSalario.Text);
            vendedor.MetaDeVendaMesEmReais = Convert.ToInt32(txtMetaVendas.Text);
            vendedor.VendasdoMesEmReais = Convert.ToDouble(txtTotVendas.Text);
            vendedor.PorcentagemSobreVendas = Convert.ToInt32(txtComissao.Text);

            listafunc.Add(vendedor);
            MessageBox.Show("Sucesso");
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            FuncionarioGerente gerente = new FuncionarioGerente();

            gerente.Codigo = Convert.ToInt32(txtCodigo.Text);
            gerente.Nome = txtNome.Text;
            gerente.Salario = Convert.ToDouble(txtSalario.Text);
            gerente.QtdeFuncionariosSubordinados = Convert.ToInt32(txtQtdFunc.Text);
            gerente.BonusEmReais = Convert.ToDouble(txtBonus.Text);

            listafunc.Add(gerente);
            MessageBox.Show("Sucesso");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach(Funcionario f in listafunc)
            {
                txtListagem.Text += f.ToString();
            }
        }
    }
}
