namespace Calculadora.WinApp
{
    public partial class Form1 : Form
    {
        private Calculadora calculadora;

        public Form1()
        {
            InitializeComponent();

            calculadora = new Calculadora();

            ConfigurarBotoes();
        }

        private void ConfigurarBotoes()
        {
            btn1.Click += AtribuirNumero;
            btn2.Click += AtribuirNumero;
            btn3.Click += AtribuirNumero;
            btn4.Click += AtribuirNumero;
            btn5.Click += AtribuirNumero;
            btn6.Click += AtribuirNumero;
            btn7.Click += AtribuirNumero;
            btn8.Click += AtribuirNumero;
            btn9.Click += AtribuirNumero;
            btn0.Click += AtribuirNumero;

            btnSomar.Click += RegistrarOperacao;
            btnSubtrair.Click += RegistrarOperacao;
            btnMultiplicar.Click += RegistrarOperacao;
            btnDividir.Click += RegistrarOperacao;

            btnIgual.Click += ExecutarCalculo;

            btnLimpar.Click += Limpar;
        }

        private void AtribuirNumero(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            txtNumeros.Text += botaoClicado.Text;
        }

        private void RegistrarOperacao(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeros.Text))
                return;

            calculadora.primeiroNumero = Convert.ToDecimal(txtNumeros.Text);

            Button botaoClicado = (Button)sender;

            calculadora.operacao = Convert.ToChar(botaoClicado.Text);

            txtCalculo.Text = txtNumeros.Text + " " + botaoClicado.Text;

            txtNumeros.Text = "";
        }

        private void ExecutarCalculo(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeros.Text))
                return;

            calculadora.segundoNumero = Convert.ToDecimal(txtNumeros.Text);

            try
            {
                txtCalculo.Text = calculadora.Calcular();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Segundo número inválido");
            }

            txtNumeros.Text = "";
        }

        private void Limpar(object? sender, EventArgs e)
        {
            txtCalculo.ResetText();
            txtNumeros.ResetText();

            calculadora.Limpar();
        }
    }
}