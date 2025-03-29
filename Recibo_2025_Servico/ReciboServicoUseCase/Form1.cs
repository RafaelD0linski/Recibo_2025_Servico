using Recibo_2025_Servico.MensagemDeAvisoUseCase;
using Recibo_2025_Servico.ReciboServicoUseCase;
using System.Net.Http;
using System.Net.Http.Json;

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
            //datadoservico.Value,
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

        _dadosServico = request;
    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {
        ObterDadosServico();
    }

    public void ValidarCampos(DadosServicoRequest request)
    {
          
        if (request is null)
        {
            MensagemAviso mensagem = new("Erro", "Exitem campos incompletos", NivelAviso.Alerta);

            MessageBox.Show(mensagem.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
