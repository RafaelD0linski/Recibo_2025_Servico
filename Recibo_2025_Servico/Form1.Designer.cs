namespace Recibo_2025_Servico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtdatadoservico = new Label();
            txtTipoServico = new TextBox();
            txttipodeservico = new Label();
            txtTipoPagamento = new TextBox();
            label3 = new Label();
            datadoservico = new DateTimePicker();
            label1 = new Label();
            txtDescricaoServico = new TextBox();
            label2 = new Label();
            txtValorServicoPrestado = new TextBox();
            btnImprimir = new Button();
            SuspendLayout();
            // 
            // txtdatadoservico
            // 
            txtdatadoservico.AutoSize = true;
            txtdatadoservico.Location = new Point(10, 24);
            txtdatadoservico.Name = "txtdatadoservico";
            txtdatadoservico.Size = new Size(89, 15);
            txtdatadoservico.TabIndex = 0;
            txtdatadoservico.Text = "Data do Serviço";
            // 
            // txtTipoServico
            // 
            txtTipoServico.Location = new Point(116, 50);
            txtTipoServico.Margin = new Padding(3, 2, 3, 2);
            txtTipoServico.Name = "txtTipoServico";
            txtTipoServico.Size = new Size(110, 23);
            txtTipoServico.TabIndex = 3;
            // 
            // txttipodeservico
            // 
            txttipodeservico.AutoSize = true;
            txttipodeservico.Location = new Point(10, 53);
            txttipodeservico.Name = "txttipodeservico";
            txttipodeservico.Size = new Size(87, 15);
            txttipodeservico.TabIndex = 2;
            txttipodeservico.Text = "Tipo de Serviço";
            // 
            // txtTipoPagamento
            // 
            txtTipoPagamento.Location = new Point(139, 82);
            txtTipoPagamento.Margin = new Padding(3, 2, 3, 2);
            txtTipoPagamento.Name = "txtTipoPagamento";
            txtTipoPagamento.Size = new Size(110, 23);
            txtTipoPagamento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 85);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de pagamento";
            // 
            // datadoservico
            // 
            datadoservico.Location = new Point(105, 18);
            datadoservico.Margin = new Padding(3, 2, 3, 2);
            datadoservico.Name = "datadoservico";
            datadoservico.Size = new Size(219, 23);
            datadoservico.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 150);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 6;
            label1.Text = "Descrição de Serviço";
            // 
            // txtDescricaoServico
            // 
            txtDescricaoServico.Location = new Point(139, 147);
            txtDescricaoServico.Margin = new Padding(3, 2, 3, 2);
            txtDescricaoServico.Name = "txtDescricaoServico";
            txtDescricaoServico.Size = new Size(110, 23);
            txtDescricaoServico.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 117);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 8;
            label2.Text = "Valor do serviço prestado ";
            // 
            // txtValorServicoPrestado
            // 
            txtValorServicoPrestado.Location = new Point(158, 114);
            txtValorServicoPrestado.Margin = new Padding(3, 2, 3, 2);
            txtValorServicoPrestado.Name = "txtValorServicoPrestado";
            txtValorServicoPrestado.Size = new Size(110, 23);
            txtValorServicoPrestado.TabIndex = 9;
            txtValorServicoPrestado.TextChanged += textBox1_TextChanged;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(373, 82);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(104, 47);
            btnImprimir.TabIndex = 11;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 190);
            Controls.Add(btnImprimir);
            Controls.Add(datadoservico);
            Controls.Add(txtValorServicoPrestado);
            Controls.Add(label2);
            Controls.Add(txtDescricaoServico);
            Controls.Add(label1);
            Controls.Add(txtTipoPagamento);
            Controls.Add(label3);
            Controls.Add(txtTipoServico);
            Controls.Add(txttipodeservico);
            Controls.Add(txtdatadoservico);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Informações de Serviço";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtdatadoservico;
        private TextBox txtTipoServico;
        private Label txttipodeservico;
        private TextBox txtTipoPagamento;
        private Label label3;
        private DateTimePicker datadoservico;
        private Label label1;
        private TextBox txtDescricaoServico;
        private Label label2;
        private TextBox txtValorServicoPrestado;
        private Button btnImprimir;
    }
}
