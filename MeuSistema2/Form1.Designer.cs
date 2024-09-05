namespace MeuSistema2
{
    partial class FrmMeuSistema
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
            this.txtParc1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParc2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSubtr = new System.Windows.Forms.Button();
            this.btnResto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtParc1
            // 
            this.txtParc1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtParc1.Location = new System.Drawing.Point(112, 68);
            this.txtParc1.Name = "txtParc1";
            this.txtParc1.Size = new System.Drawing.Size(142, 22);
            this.txtParc1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parcela 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parcela 2";
            // 
            // txtParc2
            // 
            this.txtParc2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtParc2.Location = new System.Drawing.Point(112, 117);
            this.txtParc2.Name = "txtParc2";
            this.txtParc2.Size = new System.Drawing.Size(142, 22);
            this.txtParc2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtResult.Location = new System.Drawing.Point(122, 182);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(142, 22);
            this.txtResult.TabIndex = 8;
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(18, 254);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(53, 32);
            this.btnSoma.TabIndex = 10;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(233, 299);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 29);
            this.btnSair.TabIndex = 47;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivi.Location = new System.Drawing.Point(195, 254);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(53, 32);
            this.btnDivi.TabIndex = 48;
            this.btnDivi.Text = "/";
            this.btnDivi.UseVisualStyleBackColor = true;
            this.btnDivi.Click += new System.EventHandler(this.btnDivi_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(136, 254);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(53, 32);
            this.btnMulti.TabIndex = 49;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnSubtr
            // 
            this.btnSubtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtr.Location = new System.Drawing.Point(77, 254);
            this.btnSubtr.Name = "btnSubtr";
            this.btnSubtr.Size = new System.Drawing.Size(53, 32);
            this.btnSubtr.TabIndex = 50;
            this.btnSubtr.Text = "-";
            this.btnSubtr.UseVisualStyleBackColor = true;
            this.btnSubtr.Click += new System.EventHandler(this.btnSubtr_Click);
            // 
            // btnResto
            // 
            this.btnResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResto.Location = new System.Drawing.Point(254, 254);
            this.btnResto.Name = "btnResto";
            this.btnResto.Size = new System.Drawing.Size(53, 32);
            this.btnResto.TabIndex = 51;
            this.btnResto.Text = "%";
            this.btnResto.UseVisualStyleBackColor = true;
            this.btnResto.Click += new System.EventHandler(this.btnResto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Apenas numeros inteiros";
            // 
            // FrmMeuSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResto);
            this.Controls.Add(this.btnSubtr);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParc2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParc1);
            this.Name = "FrmMeuSistema";
            this.Text = "Aplicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtParc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParc2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnSubtr;
        private System.Windows.Forms.Button btnResto;
        private System.Windows.Forms.Label label4;
    }
}

