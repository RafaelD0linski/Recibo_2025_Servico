using Recibo_2025_Servico.ReciboServicoUseCase;

namespace Recibo_2025_Servico;

public partial class InformacaoServico : Form
{
    public InformacaoServico()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    public void ObterDadosServico()
    {
        DadosServicoRequest request = new(
            Convert.ToDateTime(dataServiço),
            txttipodeservico.Text,
            txtdescricaodoservico.Text,
            txtValorServicoPrestado.Text != string.Empty && Convert.ToDouble(txtValorServicoPrestado.Text) > 0 ? Convert.ToDouble(txtValorServicoPrestado.Text) : 0,
            txtTipoPagamento.Text
            );

        if (request is null)
            return;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
