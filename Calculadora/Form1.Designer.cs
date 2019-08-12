namespace WindowsFormsApp2
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNumeroDois = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNumeroDois = new System.Windows.Forms.TextBox();
            this.lblNumeroUm = new System.Windows.Forms.Label();
            this.txtNumeroUm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(16, 165);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(213, 32);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.Location = new System.Drawing.Point(253, 165);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(89, 32);
            this.btnMultiplicacao.TabIndex = 21;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(253, 114);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(89, 32);
            this.btnDivisao.TabIndex = 20;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.Location = new System.Drawing.Point(253, 62);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(89, 32);
            this.btnSubtracao.TabIndex = 19;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(253, 15);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(89, 32);
            this.btnSoma.TabIndex = 18;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(14, 105);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 17;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblNumeroDois
            // 
            this.lblNumeroDois.AutoSize = true;
            this.lblNumeroDois.Location = new System.Drawing.Point(16, 62);
            this.lblNumeroDois.Name = "lblNumeroDois";
            this.lblNumeroDois.Size = new System.Drawing.Size(56, 13);
            this.lblNumeroDois.TabIndex = 16;
            this.lblNumeroDois.Text = "Número 2:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(86, 104);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(143, 20);
            this.txtResultado.TabIndex = 15;
            // 
            // txtNumeroDois
            // 
            this.txtNumeroDois.Location = new System.Drawing.Point(86, 59);
            this.txtNumeroDois.Name = "txtNumeroDois";
            this.txtNumeroDois.Size = new System.Drawing.Size(143, 20);
            this.txtNumeroDois.TabIndex = 14;
            // 
            // lblNumeroUm
            // 
            this.lblNumeroUm.AutoSize = true;
            this.lblNumeroUm.Location = new System.Drawing.Point(14, 21);
            this.lblNumeroUm.Name = "lblNumeroUm";
            this.lblNumeroUm.Size = new System.Drawing.Size(56, 13);
            this.lblNumeroUm.TabIndex = 13;
            this.lblNumeroUm.Text = "Número 1:";
            // 
            // txtNumeroUm
            // 
            this.txtNumeroUm.Location = new System.Drawing.Point(86, 18);
            this.txtNumeroUm.Name = "txtNumeroUm";
            this.txtNumeroUm.Size = new System.Drawing.Size(143, 20);
            this.txtNumeroUm.TabIndex = 12;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 213);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNumeroDois);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumeroDois);
            this.Controls.Add(this.lblNumeroUm);
            this.Controls.Add(this.txtNumeroUm);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNumeroDois;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNumeroDois;
        private System.Windows.Forms.Label lblNumeroUm;
        private System.Windows.Forms.TextBox txtNumeroUm;
    }
}

