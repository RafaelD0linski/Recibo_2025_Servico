using Recibo_2025_Servico.MensagemDeAvisoUseCase;
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
            datadoservico is null ? DateTime.Now : Convert.ToDateTime(datadoservico),
            txtTipoServico.Text,
            txtDescricaoServico.Text,
            txtValorServicoPrestado.Text.Length > 0 ? Convert.ToDouble(txtValorServicoPrestado.Text) : 0,
            txtTipoPagamento.Text,
            txtCep.Text,
            txtCidade.Text,
            txtrua.Text,
            txtnumEnd.Text,
            cbestado.Text
            );

        if (request.descricaoServico == string.Empty )
        {
            //MensagemAviso mensagem = new("Erro", "Exitem campos incompletos", NivelAviso.Critico);
            //mensagem
        }

        _dadosServico = request;
    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {
        ObterDadosServico();
    }
}
