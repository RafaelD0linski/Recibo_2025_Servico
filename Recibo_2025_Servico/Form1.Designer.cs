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
            txtCidade = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            txtCep = new TextBox();
            lblvalordoservico = new Label();
            txtEndServico = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            Numero = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            txtDescricaoServico.Size = new Size(316, 23);
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
            txtValorServicoPrestado.Size = new Size(134, 23);
            txtValorServicoPrestado.TabIndex = 9;
            txtValorServicoPrestado.TextChanged += textBox1_TextChanged;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(139, 326);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(211, 27);
            btnImprimir.TabIndex = 11;
            btnImprimir.Text = "Proximo";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtCidade
            // 
            txtCidade.AutoSize = true;
            txtCidade.Location = new Point(10, 261);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(44, 15);
            txtCidade.TabIndex = 14;
            txtCidade.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 290);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 15;
            label5.Text = "Rua";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 287);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 23);
            textBox2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 229);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 17;
            label4.Text = "Cep";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(61, 226);
            txtCep.Margin = new Padding(3, 2, 3, 2);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(110, 23);
            txtCep.TabIndex = 18;
            // 
            // lblvalordoservico
            // 
            lblvalordoservico.AutoSize = true;
            lblvalordoservico.Location = new Point(261, 261);
            lblvalordoservico.Name = "lblvalordoservico";
            lblvalordoservico.Size = new Size(42, 15);
            lblvalordoservico.TabIndex = 21;
            lblvalordoservico.Text = "Estado";
            // 
            // txtEndServico
            // 
            txtEndServico.Location = new Point(64, 256);
            txtEndServico.Margin = new Padding(3, 2, 3, 2);
            txtEndServico.Name = "txtEndServico";
            txtEndServico.Size = new Size(137, 23);
            txtEndServico.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(309, 258);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 23);
            comboBox1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(-1, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 39);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Location = new Point(177, 191);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 26;
            label6.Text = "Descrição de Serviço";
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Location = new Point(242, 229);
            Numero.Name = "Numero";
            Numero.Size = new Size(51, 15);
            Numero.TabIndex = 19;
            Numero.Text = "Numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 226);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 23);
            textBox1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 369);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(txtEndServico);
            Controls.Add(lblvalordoservico);
            Controls.Add(textBox1);
            Controls.Add(Numero);
            Controls.Add(txtCep);
            Controls.Add(label4);
            Controls.Add(textBox2);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Informações de Serviço";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBox2;
        private Label label4;
        private TextBox txtCep;
        private Label lblvalordoservico;
        private TextBox txtEndServico;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label Numero;
        private TextBox textBox1;
    }
}
