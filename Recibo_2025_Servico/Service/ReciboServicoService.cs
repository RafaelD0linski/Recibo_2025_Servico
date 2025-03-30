using Recibo_2025_Servico;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private readonly HttpClient _httpClient;

    public Form1()
    {
        InformacoesServico          frm = new();
        frm.InitializeComponent();
        frm.Show();

        _httpClient = new HttpClient();
    }

    private async void btnCarregarProdutos_Click(object sender, EventArgs e)
    {
        try
        {
            // Chama a API para buscar os produtos
            var produtos = await _httpClient.GetFromJsonAsync<string[]>("https://localhost:7015/api/Produto");

            // Exibe os produtos em um ListBox, por exemplo
            listBoxProdutos.Items.Clear();
            listBoxProdutos.Items.AddRange(produtos);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao buscar produtos: " + ex.Message);
        }
    }
}
