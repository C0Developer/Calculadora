namespace Calculadora
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
            txtResultado = new TextBox();
            btSete = new Button();
            btOito = new Button();
            btNove = new Button();
            btDivisao = new Button();
            btMultiplicacao = new Button();
            btSeis = new Button();
            btCinco = new Button();
            btQuatro = new Button();
            btSubtracao = new Button();
            btTres = new Button();
            btDois = new Button();
            btUm = new Button();
            btAdicao = new Button();
            btIgual = new Button();
            btZero = new Button();
            btLimpar = new Button();
            lblOperacao = new Label();
            btVirgula = new Button();
            label1 = new Label();
            btApagarUm = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.ButtonHighlight;
            txtResultado.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(5, 4);
            txtResultado.Margin = new Padding(3, 2, 3, 2);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(178, 52);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btSete
            // 
            btSete.BackColor = Color.Gainsboro;
            btSete.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btSete.Location = new Point(5, 59);
            btSete.Margin = new Padding(3, 2, 3, 2);
            btSete.Name = "btSete";
            btSete.Size = new Size(56, 36);
            btSete.TabIndex = 1;
            btSete.Text = "7";
            btSete.UseVisualStyleBackColor = false;
            btSete.Click += btSete_Click;
            // 
            // btOito
            // 
            btOito.BackColor = Color.Gainsboro;
            btOito.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btOito.Location = new Point(67, 59);
            btOito.Margin = new Padding(3, 2, 3, 2);
            btOito.Name = "btOito";
            btOito.Size = new Size(56, 36);
            btOito.TabIndex = 2;
            btOito.Text = "8";
            btOito.UseVisualStyleBackColor = false;
            btOito.Click += btOito_Click;
            // 
            // btNove
            // 
            btNove.BackColor = Color.Gainsboro;
            btNove.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btNove.Location = new Point(129, 59);
            btNove.Margin = new Padding(3, 2, 3, 2);
            btNove.Name = "btNove";
            btNove.Size = new Size(56, 35);
            btNove.TabIndex = 3;
            btNove.Text = "9";
            btNove.UseVisualStyleBackColor = false;
            btNove.Click += btNove_Click;
            // 
            // btDivisao
            // 
            btDivisao.BackColor = Color.Gainsboro;
            btDivisao.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btDivisao.Location = new Point(189, 60);
            btDivisao.Margin = new Padding(3, 2, 3, 2);
            btDivisao.Name = "btDivisao";
            btDivisao.Size = new Size(56, 34);
            btDivisao.TabIndex = 4;
            btDivisao.Text = "÷";
            btDivisao.UseVisualStyleBackColor = false;
            btDivisao.Click += btDivisao_Click;
            // 
            // btMultiplicacao
            // 
            btMultiplicacao.BackColor = Color.Gainsboro;
            btMultiplicacao.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btMultiplicacao.Location = new Point(191, 98);
            btMultiplicacao.Margin = new Padding(3, 2, 3, 2);
            btMultiplicacao.Name = "btMultiplicacao";
            btMultiplicacao.Size = new Size(54, 36);
            btMultiplicacao.TabIndex = 8;
            btMultiplicacao.Text = "x";
            btMultiplicacao.UseVisualStyleBackColor = false;
            btMultiplicacao.Click += btMultiplicacao_Click;
            // 
            // btSeis
            // 
            btSeis.BackColor = Color.Gainsboro;
            btSeis.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btSeis.Location = new Point(129, 98);
            btSeis.Margin = new Padding(3, 2, 3, 2);
            btSeis.Name = "btSeis";
            btSeis.Size = new Size(56, 36);
            btSeis.TabIndex = 7;
            btSeis.Text = "6";
            btSeis.UseVisualStyleBackColor = false;
            btSeis.Click += btSeis_Click;
            // 
            // btCinco
            // 
            btCinco.BackColor = Color.Gainsboro;
            btCinco.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btCinco.Location = new Point(67, 98);
            btCinco.Margin = new Padding(3, 2, 3, 2);
            btCinco.Name = "btCinco";
            btCinco.Size = new Size(56, 36);
            btCinco.TabIndex = 6;
            btCinco.Text = "5";
            btCinco.UseVisualStyleBackColor = false;
            btCinco.Click += btCinco_Click;
            // 
            // btQuatro
            // 
            btQuatro.BackColor = Color.Gainsboro;
            btQuatro.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btQuatro.Location = new Point(5, 98);
            btQuatro.Margin = new Padding(3, 2, 3, 2);
            btQuatro.Name = "btQuatro";
            btQuatro.Size = new Size(56, 36);
            btQuatro.TabIndex = 5;
            btQuatro.Text = "4";
            btQuatro.UseVisualStyleBackColor = false;
            btQuatro.Click += btQuatro_Click;
            // 
            // btSubtracao
            // 
            btSubtracao.BackColor = Color.Gainsboro;
            btSubtracao.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btSubtracao.Location = new Point(191, 139);
            btSubtracao.Margin = new Padding(3, 2, 3, 2);
            btSubtracao.Name = "btSubtracao";
            btSubtracao.Size = new Size(54, 35);
            btSubtracao.TabIndex = 12;
            btSubtracao.Text = "-";
            btSubtracao.UseVisualStyleBackColor = false;
            btSubtracao.Click += btSubtracao_Click;
            // 
            // btTres
            // 
            btTres.BackColor = Color.Gainsboro;
            btTres.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btTres.Location = new Point(129, 139);
            btTres.Margin = new Padding(3, 2, 3, 2);
            btTres.Name = "btTres";
            btTres.Size = new Size(56, 35);
            btTres.TabIndex = 11;
            btTres.Text = "3";
            btTres.UseVisualStyleBackColor = false;
            btTres.Click += btTres_Click;
            // 
            // btDois
            // 
            btDois.BackColor = Color.Gainsboro;
            btDois.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btDois.Location = new Point(67, 138);
            btDois.Margin = new Padding(3, 2, 3, 2);
            btDois.Name = "btDois";
            btDois.Size = new Size(56, 36);
            btDois.TabIndex = 10;
            btDois.Text = "2";
            btDois.UseVisualStyleBackColor = false;
            btDois.Click += btDois_Click;
            // 
            // btUm
            // 
            btUm.BackColor = Color.Gainsboro;
            btUm.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btUm.Location = new Point(5, 138);
            btUm.Margin = new Padding(3, 2, 3, 2);
            btUm.Name = "btUm";
            btUm.Size = new Size(56, 36);
            btUm.TabIndex = 9;
            btUm.Text = "1";
            btUm.UseVisualStyleBackColor = false;
            btUm.Click += btUm_Click;
            // 
            // btAdicao
            // 
            btAdicao.BackColor = Color.Gainsboro;
            btAdicao.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btAdicao.Location = new Point(191, 178);
            btAdicao.Margin = new Padding(3, 2, 3, 2);
            btAdicao.Name = "btAdicao";
            btAdicao.Size = new Size(54, 36);
            btAdicao.TabIndex = 16;
            btAdicao.Text = "+";
            btAdicao.UseVisualStyleBackColor = false;
            btAdicao.Click += btAdicao_Click;
            // 
            // btIgual
            // 
            btIgual.BackColor = Color.Gainsboro;
            btIgual.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btIgual.Location = new Point(129, 178);
            btIgual.Margin = new Padding(3, 2, 3, 2);
            btIgual.Name = "btIgual";
            btIgual.Size = new Size(56, 36);
            btIgual.TabIndex = 15;
            btIgual.Text = "=";
            btIgual.UseVisualStyleBackColor = false;
            btIgual.Click += btIgual_Click;
            // 
            // btZero
            // 
            btZero.BackColor = Color.Gainsboro;
            btZero.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btZero.Location = new Point(67, 178);
            btZero.Margin = new Padding(3, 2, 3, 2);
            btZero.Name = "btZero";
            btZero.Size = new Size(56, 36);
            btZero.TabIndex = 14;
            btZero.Text = "0";
            btZero.UseVisualStyleBackColor = false;
            btZero.Click += btZero_Click;
            // 
            // btLimpar
            // 
            btLimpar.BackColor = Color.Gainsboro;
            btLimpar.Font = new Font("BankGothic Md BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLimpar.ForeColor = Color.Maroon;
            btLimpar.Location = new Point(189, 34);
            btLimpar.Margin = new Padding(3, 2, 3, 2);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(56, 22);
            btLimpar.TabIndex = 13;
            btLimpar.Text = "CE";
            btLimpar.UseVisualStyleBackColor = false;
            btLimpar.Click += btLimpar_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.BackColor = Color.Transparent;
            lblOperacao.Font = new Font("BankGothic Md BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperacao.ForeColor = SystemColors.ActiveBorder;
            lblOperacao.Location = new Point(12, 9);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 19);
            lblOperacao.TabIndex = 17;
            lblOperacao.TextAlign = ContentAlignment.TopCenter;
            // 
            // btVirgula
            // 
            btVirgula.BackColor = Color.Gainsboro;
            btVirgula.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btVirgula.Location = new Point(5, 178);
            btVirgula.Margin = new Padding(3, 2, 3, 2);
            btVirgula.Name = "btVirgula";
            btVirgula.Size = new Size(56, 36);
            btVirgula.TabIndex = 18;
            btVirgula.Text = ",";
            btVirgula.UseVisualStyleBackColor = false;
            btVirgula.Click += btVirgula_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("BankGothic Md BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(33, 235);
            label1.Name = "label1";
            label1.Size = new Size(212, 13);
            label1.TabIndex = 19;
            label1.Text = "Desenvolvido por Eduardo. ©";
            // 
            // btApagarUm
            // 
            btApagarUm.BackColor = Color.Gainsboro;
            btApagarUm.Font = new Font("BankGothic Md BT", 12F, FontStyle.Bold);
            btApagarUm.ForeColor = Color.FromArgb(255, 128, 0);
            btApagarUm.Location = new Point(189, 4);
            btApagarUm.Name = "btApagarUm";
            btApagarUm.Size = new Size(56, 25);
            btApagarUm.TabIndex = 20;
            btApagarUm.Text = "<";
            btApagarUm.UseVisualStyleBackColor = false;
            btApagarUm.Click += btApagarUm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(249, 248);
            Controls.Add(btApagarUm);
            Controls.Add(label1);
            Controls.Add(btVirgula);
            Controls.Add(lblOperacao);
            Controls.Add(btAdicao);
            Controls.Add(btIgual);
            Controls.Add(btZero);
            Controls.Add(btLimpar);
            Controls.Add(btSubtracao);
            Controls.Add(btTres);
            Controls.Add(btDois);
            Controls.Add(btUm);
            Controls.Add(btMultiplicacao);
            Controls.Add(btSeis);
            Controls.Add(btCinco);
            Controls.Add(btQuatro);
            Controls.Add(btDivisao);
            Controls.Add(btNove);
            Controls.Add(btOito);
            Controls.Add(btSete);
            Controls.Add(txtResultado);
            Font = new Font("SansSerif", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btSete;
        private Button btOito;
        private Button btNove;
        private Button btDivisao;
        private Button btMultiplicacao;
        private Button btSeis;
        private Button btCinco;
        private Button btQuatro;
        private Button btSubtracao;
        private Button btTres;
        private Button btDois;
        private Button btUm;
        private Button btAdicao;
        private Button btIgual;
        private Button btZero;
        private Button btLimpar;
        private Label lblOperacao;
        private Button btVirgula;
        private Label label1;
        private Button btApagarUm;
    }
}
