namespace Recibo_2025_Servico
{
    partial class InformacaoServico
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
            txtValorServicoPrestado = new TextBox();
            lblvalordoservico = new Label();
            txtDescricaoServico = new TextBox();
            txtdescricaodoservico = new Label();
            dataServiço = new DateTimePicker();
            BtnProximo = new Button();
            SuspendLayout();
            // 
            // txtdatadoservico
            // 
            txtdatadoservico.AutoSize = true;
            txtdatadoservico.Location = new Point(11, 19);
            txtdatadoservico.Name = "txtdatadoservico";
            txtdatadoservico.Size = new Size(89, 15);
            txtdatadoservico.TabIndex = 0;
            txtdatadoservico.Text = "Data do Serviço";
            // 
            // txtTipoServico
            // 
            txtTipoServico.Location = new Point(106, 50);
            txtTipoServico.Margin = new Padding(3, 2, 3, 2);
            txtTipoServico.Name = "txtTipoServico";
            txtTipoServico.Size = new Size(110, 23);
            txtTipoServico.TabIndex = 3;
            // 
            // txttipodeservico
            // 
            txttipodeservico.AutoSize = true;
            txttipodeservico.Location = new Point(11, 53);
            txttipodeservico.Name = "txttipodeservico";
            txttipodeservico.Size = new Size(87, 15);
            txttipodeservico.TabIndex = 2;
            txttipodeservico.Text = "Tipo de Serviço";
            // 
            // txtTipoPagamento
            // 
            txtTipoPagamento.Location = new Point(127, 85);
            txtTipoPagamento.Margin = new Padding(3, 2, 3, 2);
            txtTipoPagamento.Name = "txtTipoPagamento";
            txtTipoPagamento.Size = new Size(110, 23);
            txtTipoPagamento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 88);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de pagamento";
            // 
            // txtValorServicoPrestado
            // 
            txtValorServicoPrestado.Location = new Point(159, 122);
            txtValorServicoPrestado.Margin = new Padding(3, 2, 3, 2);
            txtValorServicoPrestado.Name = "txtValorServicoPrestado";
            txtValorServicoPrestado.Size = new Size(110, 23);
            txtValorServicoPrestado.TabIndex = 9;
            txtValorServicoPrestado.TextChanged += textBox1_TextChanged;
            // 
            // lblvalordoservico
            // 
            lblvalordoservico.AutoSize = true;
            lblvalordoservico.Location = new Point(11, 125);
            lblvalordoservico.Name = "lblvalordoservico";
            lblvalordoservico.Size = new Size(142, 15);
            lblvalordoservico.TabIndex = 8;
            lblvalordoservico.Text = "Valor do serviço prestado ";
            // 
            // txtDescricaoServico
            // 
            txtDescricaoServico.Location = new Point(133, 159);
            txtDescricaoServico.Margin = new Padding(3, 2, 3, 2);
            txtDescricaoServico.Name = "txtDescricaoServico";
            txtDescricaoServico.Size = new Size(110, 23);
            txtDescricaoServico.TabIndex = 7;
            // 
            // txtdescricaodoservico
            // 
            txtdescricaodoservico.AutoSize = true;
            txtdescricaodoservico.Location = new Point(12, 162);
            txtdescricaodoservico.Name = "txtdescricaodoservico";
            txtdescricaodoservico.Size = new Size(115, 15);
            txtdescricaodoservico.TabIndex = 6;
            txtdescricaodoservico.Text = "Descrição de Serviço";
            // 
            // dataServiço
            // 
            dataServiço.Location = new Point(106, 13);
            dataServiço.Margin = new Padding(3, 2, 3, 2);
            dataServiço.Name = "dataServiço";
            dataServiço.Size = new Size(219, 23);
            dataServiço.TabIndex = 10;
            // 
            // BtnProximo
            // 
            BtnProximo.Location = new Point(352, 85);
            BtnProximo.Name = "BtnProximo";
            BtnProximo.Size = new Size(176, 39);
            BtnProximo.TabIndex = 11;
            BtnProximo.Text = "Proximo";
            BtnProximo.UseVisualStyleBackColor = true;
            // 
            // InformacaoServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(575, 204);
            Controls.Add(BtnProximo);
            Controls.Add(dataServiço);
            Controls.Add(txtValorServicoPrestado);
            Controls.Add(lblvalordoservico);
            Controls.Add(txtDescricaoServico);
            Controls.Add(txtdescricaodoservico);
            Controls.Add(txtTipoPagamento);
            Controls.Add(label3);
            Controls.Add(txtTipoServico);
            Controls.Add(txttipodeservico);
            Controls.Add(txtdatadoservico);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InformacaoServico";
            Text = "Recibo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtdatadoservico;
        private TextBox txtTipoServico;
        private Label txttipodeservico;
        private TextBox txtTipoPagamento;
        private Label label3;
        private TextBox txtValorServicoPrestado;
        private Label lblvalordoservico;
        private TextBox txtDescricaoServico;
        private Label txtdescricaodoservico;
        private DateTimePicker dataServiço;
        private Button BtnProximo;
    }
}
