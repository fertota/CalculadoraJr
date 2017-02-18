namespace CalculadoraJr
{
    partial class Calc1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicao
            // 
            this.btnAdicao.Location = new System.Drawing.Point(188, 30);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(83, 32);
            this.btnAdicao.TabIndex = 0;
            this.btnAdicao.Text = "Adição";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(188, 68);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(83, 34);
            this.btnSubtracao.TabIndex = 1;
            this.btnSubtracao.Text = "Subtração";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(188, 108);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(83, 33);
            this.btnMultiplicacao.TabIndex = 2;
            this.btnMultiplicacao.Text = "Multiplicação";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(188, 147);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(83, 33);
            this.btnDivisao.TabIndex = 3;
            this.btnDivisao.Text = "Divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(28, 54);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 4;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(28, 110);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(25, 147);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 6;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(28, 35);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(40, 13);
            this.lblValor1.TabIndex = 7;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(28, 91);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(40, 13);
            this.lblValor2.TabIndex = 8;
            this.lblValor2.Text = "Valor 2";
            // 
            // Calc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 222);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Name = "Calc1";
            this.Text = "Calculadora v 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
    }
}

