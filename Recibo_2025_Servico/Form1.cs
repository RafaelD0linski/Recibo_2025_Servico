using Recibo_2025_Servico.ReciboServicoUseCase;

namespace Recibo_2025_Servico;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    public void ObterDadosServico()
    {
        DadosServicoRequest request = new(
            Convert.ToDateTime(datadoservico),
            txtTipoServico.Text,
            txtDescricaoServico.Text,
            txtValorServicoPrestado.Text.Length > 0 ? Convert.ToDouble(txtValorServicoPrestado.Text) : 0,
            txtTipoPagamento.Text
            );

        if (request is null)
            return;
    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {

    }
}
