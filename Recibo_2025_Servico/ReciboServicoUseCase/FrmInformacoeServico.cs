using iTextSharp.text.pdf;
using iTextSharp.text;
using Recibo_2025_Servico.MensagemDeAvisoUseCase;
using Recibo_2025_Servico.ReciboServicoUseCase;
using System.Net.Http;
using System.Net.Http.Json;
using System.Diagnostics;

namespace Recibo_2025_Servico;

public partial class InformacoesServico : Form
{
    private readonly HttpClient _httpClient;
    public DadosServicoRequest _dadosServico;

    public InformacoesServico()
    {
        InitializeComponent();
        _httpClient = new HttpClient();
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
        if (!ValidarCampos(_dadosServico))
        {
            return; // Interrompe a execu��o se houver erro.
        }

        // L�gica de impress�o aqui...
    }


    private void btnGerarPDF_Click(object sender, EventArgs e)
    {
        FrmInfromacoesCredor frmInfromacoesCredor = new FrmInfromacoesCredor();
        frmInfromacoesCredor.ShowDialog();
    }



    private async void ObterdadosApi(object sender, EventArgs e)
    {
        try
        {
            var produtos = await _httpClient.GetFromJsonAsync<string[]>("https://localhost:7015/api/Produto");

            if (produtos != null && produtos.Length > 0)
            {
                
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao buscar produtos: " + ex.Message);
        }
    }

    public bool ValidarCampos(DadosServicoRequest request)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.tipoServico) || string.IsNullOrWhiteSpace(request.descricaoServico))
        {
            MensagemAviso mensagem = new("Erro", "Existem campos incompletos", NivelAviso.Alerta);
            MessageBox.Show(mensagem.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

}
