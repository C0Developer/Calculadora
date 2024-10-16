namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao, Subtracao, Multiplicacao, Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 0;
        }

        private void btUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 1;
        }

        private void btDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 2;
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 3;
        }

        private void btQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 4;
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 5;
        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 6;
        }

        private void btSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 7;
        }

        private void btOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 8;
        }

        private void btNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 9;
        }

        private void btAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            //Apagar ao clicar no operador, dentro da caixa de resultado
            txtResultado.Text = "";
            lblOperacao.Text = "x";
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "÷";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {

            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    //Guarda o Valor digitado dentro do Resultado + o texto que eu digitei após a operação 
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
            //Mostrar o sinal de igual no resultado
            lblOperacao.Text = "=";
        }

        private void btVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            //Limpar o sinal operador dentro do resultado
            lblOperacao.Text = "";
        }

        private void btApagarUm_Click(object sender, EventArgs e)
        {
            // Verifica se há texto no campo de resultado
            if (txtResultado.Text.Length > 0)
            {
                // Remove o último caractere do texto
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
        }
    }
}
