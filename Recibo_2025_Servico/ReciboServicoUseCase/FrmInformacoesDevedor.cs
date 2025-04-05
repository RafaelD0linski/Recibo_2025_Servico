using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recibo_2025_Servico.ReciboServicoUseCase
{
    public partial class InformacoesDevedor : Form
    {
        public InformacoesDevedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerarPdf();
            //Validar opção de usar o quest pdf para gerar o pdf 
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
    }
}
