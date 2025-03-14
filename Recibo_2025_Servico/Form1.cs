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
            txttipodeservico.Text,
            descricaoServico.Text,
            txtvalorservico.Text != string.Empty && Convert.ToDouble(txtvalorservico.Text) > 0 ? Convert.ToDouble(txtvalorservico.Text) : 0,
            txttipodopagamento.Text
            );

        if (request is null)
            return;
    }
}
