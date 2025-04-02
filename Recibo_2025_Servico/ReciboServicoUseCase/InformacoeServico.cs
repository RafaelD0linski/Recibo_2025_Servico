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
            return; // Interrompe a execução se houver erro.
        }

        // Lógica de impressão aqui...
    }


    private void btnGerarPDF_Click(object sender, EventArgs e)
    {
        informa
    }


    public void GerarPdf()
    {
        try
        {
            // Caminho onde o PDF será salvo (pasta do projeto)
            string caminho = Path.Combine(Application.StartupPath, "MeuArquivo.pdf");

            // Criar o documento
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();
            doc.Add(new Paragraph("Olá, este é um PDF gerado pelo meu programa!"));

            doc.Add(new Paragraph("Nome: João da Silva"));
            doc.Add(new Paragraph("Data de Nascimento: 10/05/1995"));
            doc.Add(new Paragraph("Endereço: Rua das Flores, 123, Centro"));



            PdfPTable tabela = new PdfPTable(2); // 2 colunas
            tabela.AddCell("Nome:");
            tabela.AddCell("João da Silva");
            tabela.AddCell("Data de Nascimento:");
            tabela.AddCell("10/05/1995");
            tabela.AddCell("Endereço:");
            tabela.AddCell("Rua das Flores, 123, Centro");

            doc.Close();

            Process.Start(new ProcessStartInfo(caminho) { UseShellExecute = true });

            MessageBox.Show("PDF gerado e aberto com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao gerar PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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
