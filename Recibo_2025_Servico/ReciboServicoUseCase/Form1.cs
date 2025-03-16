using Recibo_2025_Servico.ReciboServicoUseCase;

namespace Recibo_2025_Servico;

public partial class InformacoesServico : Form
{
    public DadosServicoRequest _dadosServico;
    public InformacoesServico()
    {
        InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        datadoservico.Focus();
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

        _dadosServico = request;


    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {
        if (_dadosServico is null)
            return;



    }
}
