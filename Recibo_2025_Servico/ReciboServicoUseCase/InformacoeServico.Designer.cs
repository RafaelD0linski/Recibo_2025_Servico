namespace Recibo_2025_Servico
{
    partial class InformacoesServico
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
            txtCidade = new Label();
            label5 = new Label();
            txtrua = new TextBox();
            label4 = new Label();
            txtCep = new TextBox();
            lblvalordoservico = new Label();
            txtEndServico = new TextBox();
            cbestado = new ComboBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            Numero = new Label();
            txtnumEnd = new TextBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtdatadoservico
            // 
            txtdatadoservico.AutoSize = true;
            txtdatadoservico.Location = new Point(6, 67);
            txtdatadoservico.Name = "txtdatadoservico";
            txtdatadoservico.Size = new Size(115, 20);
            txtdatadoservico.TabIndex = 0;
            txtdatadoservico.Text = "Data do Serviço";
            // 
            // txtTipoServico
            // 
            txtTipoServico.Location = new Point(129, 95);
            txtTipoServico.Name = "txtTipoServico";
            txtTipoServico.Size = new Size(125, 27);
            txtTipoServico.TabIndex = 3;
            // 
            // txttipodeservico
            // 
            txttipodeservico.AutoSize = true;
            txttipodeservico.Location = new Point(8, 99);
            txttipodeservico.Name = "txttipodeservico";
            txttipodeservico.Size = new Size(112, 20);
            txttipodeservico.TabIndex = 2;
            txttipodeservico.Text = "Tipo de Serviço";
            // 
            // txtTipoPagamento
            // 
            txtTipoPagamento.Location = new Point(157, 131);
            txtTipoPagamento.Name = "txtTipoPagamento";
            txtTipoPagamento.Size = new Size(125, 27);
            txtTipoPagamento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 135);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 4;
            label3.Text = "Tipo de pagamento";
            // 
            // datadoservico
            // 
            datadoservico.Location = new Point(114, 59);
            datadoservico.Name = "datadoservico";
            datadoservico.Size = new Size(250, 27);
            datadoservico.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 207);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 6;
            label1.Text = "Descrição de Serviço";
            // 
            // txtDescricaoServico
            // 
            txtDescricaoServico.Location = new Point(157, 203);
            txtDescricaoServico.Name = "txtDescricaoServico";
            txtDescricaoServico.Size = new Size(361, 27);
            txtDescricaoServico.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 171);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 8;
            label2.Text = "Valor do serviço prestado ";
            // 
            // txtValorServicoPrestado
            // 
            txtValorServicoPrestado.Location = new Point(178, 167);
            txtValorServicoPrestado.Name = "txtValorServicoPrestado";
            txtValorServicoPrestado.Size = new Size(153, 27);
            txtValorServicoPrestado.TabIndex = 9;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.White;
            btnImprimir.Location = new Point(202, 489);
            btnImprimir.Margin = new Padding(3, 4, 3, 4);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(129, 36);
            btnImprimir.TabIndex = 11;
            btnImprimir.Text = "Proximo";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnGerarPDF_Click;
            // 
            // txtCidade
            // 
            txtCidade.AutoSize = true;
            txtCidade.Location = new Point(18, 339);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(56, 20);
            txtCidade.TabIndex = 14;
            txtCidade.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 375);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 15;
            label5.Text = "Rua";
            // 
            // txtrua
            // 
            txtrua.Location = new Point(53, 371);
            txtrua.Name = "txtrua";
            txtrua.Size = new Size(244, 27);
            txtrua.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 303);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 17;
            label4.Text = "Cep";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(53, 299);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(125, 27);
            txtCep.TabIndex = 18;
            // 
            // lblvalordoservico
            // 
            lblvalordoservico.AutoSize = true;
            lblvalordoservico.Location = new Point(18, 448);
            lblvalordoservico.Name = "lblvalordoservico";
            lblvalordoservico.Size = new Size(54, 20);
            lblvalordoservico.TabIndex = 21;
            lblvalordoservico.Text = "Estado";
            // 
            // txtEndServico
            // 
            txtEndServico.Location = new Point(75, 335);
            txtEndServico.Name = "txtEndServico";
            txtEndServico.Size = new Size(156, 27);
            txtEndServico.TabIndex = 23;
            // 
            // cbestado
            // 
            cbestado.FormattingEnabled = true;
            cbestado.Location = new Point(73, 444);
            cbestado.Margin = new Padding(3, 4, 3, 4);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(123, 28);
            cbestado.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 52);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(200, 12);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 26;
            label6.Text = "Descrição de Serviço";
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Location = new Point(18, 411);
            Numero.Name = "Numero";
            Numero.Size = new Size(63, 20);
            Numero.TabIndex = 19;
            Numero.Text = "Numero";
            // 
            // txtnumEnd
            // 
            txtnumEnd.Location = new Point(83, 407);
            txtnumEnd.Name = "txtnumEnd";
            txtnumEnd.Size = new Size(65, 27);
            txtnumEnd.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox2.Location = new Point(-5, 240);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(587, 52);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(200, 255);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 28;
            label7.Text = "Endereço do  Serviço";
            // 
            // InformacoesServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 532);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(cbestado);
            Controls.Add(txtEndServico);
            Controls.Add(lblvalordoservico);
            Controls.Add(txtnumEnd);
            Controls.Add(Numero);
            Controls.Add(txtCep);
            Controls.Add(label4);
            Controls.Add(txtrua);
            Controls.Add(label5);
            Controls.Add(txtCidade);
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
            Name = "InformacoesServico";
            Text = "Informações de Serviço";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label txtCidade;
        private Label label5;
        private TextBox txtrua;
        private Label label4;
        private TextBox txtCep;
        private Label lblvalordoservico;
        private TextBox txtEndServico;
        private ComboBox cbestado;
        private PictureBox pictureBox1;
        private Label label6;
        private Label Numero;
        private TextBox txtnumEnd;
        private PictureBox pictureBox2;
        private Label label7;
    }
}
