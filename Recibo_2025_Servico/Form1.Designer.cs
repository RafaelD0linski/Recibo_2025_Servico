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
            txttipodoservico = new TextBox();
            txttipodeservico = new Label();
            txttipodopagamento = new TextBox();
            label3 = new Label();
            txtvalorservico = new TextBox();
            lblvalordoservico = new Label();
            txtdescricaoservico = new TextBox();
            txtdescricaodoservico = new Label();
            datadoservico = new DateTimePicker();
            SuspendLayout();
            // 
            // txtdatadoservico
            // 
            txtdatadoservico.AutoSize = true;
            txtdatadoservico.Location = new Point(12, 19);
            txtdatadoservico.Name = "txtdatadoservico";
            txtdatadoservico.Size = new Size(115, 20);
            txtdatadoservico.TabIndex = 0;
            txtdatadoservico.Text = "Data do Serviço";
            // 
            // txttipodoservico
            // 
            txttipodoservico.Location = new Point(130, 60);
            txttipodoservico.Name = "txttipodoservico";
            txttipodoservico.Size = new Size(125, 27);
            txttipodoservico.TabIndex = 3;
            // 
            // txttipodeservico
            // 
            txttipodeservico.AutoSize = true;
            txttipodeservico.Location = new Point(12, 63);
            txttipodeservico.Name = "txttipodeservico";
            txttipodeservico.Size = new Size(112, 20);
            txttipodeservico.TabIndex = 2;
            txttipodeservico.Text = "Tipo de Serviço";
            // 
            // txttipodopagamento
            // 
            txttipodopagamento.Location = new Point(159, 109);
            txttipodopagamento.Name = "txttipodopagamento";
            txttipodopagamento.Size = new Size(125, 27);
            txttipodopagamento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 4;
            label3.Text = "Tipo de pagamento";
            // 
            // txtvalorservico
            // 
            txtvalorservico.Location = new Point(524, 63);
            txtvalorservico.Name = "txtvalorservico";
            txtvalorservico.Size = new Size(125, 27);
            txtvalorservico.TabIndex = 9;
            txtvalorservico.TextChanged += textBox1_TextChanged;
            // 
            // lblvalordoservico
            // 
            lblvalordoservico.AutoSize = true;
            lblvalordoservico.Location = new Point(336, 65);
            lblvalordoservico.Name = "lblvalordoservico";
            lblvalordoservico.Size = new Size(182, 20);
            lblvalordoservico.TabIndex = 8;
            lblvalordoservico.Text = "Valor do serviço prestado ";
            // 
            // txtdescricaoservico
            // 
            txtdescricaoservico.Location = new Point(574, 16);
            txtdescricaoservico.Name = "txtdescricaoservico";
            txtdescricaoservico.Size = new Size(125, 27);
            txtdescricaoservico.TabIndex = 7;
            // 
            // txtdescricaodoservico
            // 
            txtdescricaodoservico.AutoSize = true;
            txtdescricaodoservico.Location = new Point(421, 19);
            txtdescricaodoservico.Name = "txtdescricaodoservico";
            txtdescricaodoservico.Size = new Size(147, 20);
            txtdescricaodoservico.TabIndex = 6;
            txtdescricaodoservico.Text = "Descrição de Serviço";
            // 
            // datadoservico
            // 
            datadoservico.Location = new Point(133, 14);
            datadoservico.Name = "datadoservico";
            datadoservico.Size = new Size(250, 27);
            datadoservico.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datadoservico);
            Controls.Add(txtvalorservico);
            Controls.Add(lblvalordoservico);
            Controls.Add(txtdescricaoservico);
            Controls.Add(txtdescricaodoservico);
            Controls.Add(txttipodopagamento);
            Controls.Add(label3);
            Controls.Add(txttipodoservico);
            Controls.Add(txttipodeservico);
            Controls.Add(txtdatadoservico);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtdatadoservico;
        private TextBox txttipodoservico;
        private Label txttipodeservico;
        private TextBox txttipodopagamento;
        private Label label3;
        private TextBox txtvalorservico;
        private Label lblvalordoservico;
        private TextBox txtdescricaoservico;
        private Label txtdescricaodoservico;
        private DateTimePicker datadoservico;
    }
}
