namespace Calculadora
{
    partial class Form1
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.txtHist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 23);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDisplay.Size = new System.Drawing.Size(371, 71);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.Location = new System.Drawing.Point(12, 127);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(66, 67);
            this.btnNum1.TabIndex = 1;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.Numero);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.Location = new System.Drawing.Point(84, 127);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(66, 67);
            this.btnNum2.TabIndex = 2;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.Numero);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.Location = new System.Drawing.Point(156, 127);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(66, 67);
            this.btnNum3.TabIndex = 3;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.Numero);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.Location = new System.Drawing.Point(156, 200);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(66, 67);
            this.btnNum6.TabIndex = 6;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.Numero);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.Location = new System.Drawing.Point(84, 200);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(66, 67);
            this.btnNum5.TabIndex = 5;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.Numero);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.Location = new System.Drawing.Point(12, 200);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(66, 67);
            this.btnNum4.TabIndex = 4;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.Numero);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.Location = new System.Drawing.Point(156, 273);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(66, 67);
            this.btnNum9.TabIndex = 9;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.Numero);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.Location = new System.Drawing.Point(84, 273);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(66, 67);
            this.btnNum8.TabIndex = 8;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.Numero);
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.Location = new System.Drawing.Point(12, 273);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(66, 67);
            this.btnNum7.TabIndex = 7;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.Numero);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.Location = new System.Drawing.Point(84, 346);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(66, 67);
            this.btnNum0.TabIndex = 10;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.Numero);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.Location = new System.Drawing.Point(245, 200);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(66, 67);
            this.btnAdicao.TabIndex = 11;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.Operador);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.Location = new System.Drawing.Point(317, 200);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(66, 67);
            this.btnSubtracao.TabIndex = 12;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.Operador);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(245, 273);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(66, 67);
            this.btnDivisao.TabIndex = 13;
            this.btnDivisao.Text = "÷";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.Operador);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.Location = new System.Drawing.Point(317, 273);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(66, 67);
            this.btnMultiplicacao.TabIndex = 14;
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.Operador);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(280, 127);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(66, 67);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(280, 346);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(66, 67);
            this.btnIgual.TabIndex = 16;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(156, 346);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(66, 67);
            this.btnDecimal.TabIndex = 17;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // txtHist
            // 
            this.txtHist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHist.Location = new System.Drawing.Point(14, 43);
            this.txtHist.Multiline = true;
            this.txtHist.Name = "txtHist";
            this.txtHist.ReadOnly = true;
            this.txtHist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHist.Size = new System.Drawing.Size(136, 35);
            this.txtHist.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.txtHist);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.TextBox txtHist;
    }
}

