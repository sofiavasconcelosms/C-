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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtParc1
            // 
            this.txtParc1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtParc1.Location = new System.Drawing.Point(95, 52);
            this.txtParc1.Name = "txtParc1";
            this.txtParc1.Size = new System.Drawing.Size(142, 22);
            this.txtParc1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parcela 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parcela 2";
            // 
            // txtParc2
            // 
            this.txtParc2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtParc2.Location = new System.Drawing.Point(95, 101);
            this.txtParc2.Name = "txtParc2";
            this.txtParc2.Size = new System.Drawing.Size(142, 22);
            this.txtParc2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtResult.Location = new System.Drawing.Point(95, 150);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(142, 22);
            this.txtResult.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(83, 197);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 27);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtSoma
            // 
            this.txtSoma.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSoma.Location = new System.Drawing.Point(83, 12);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(142, 22);
            this.txtSoma.TabIndex = 46;
            this.txtSoma.Text = "Soma";
            this.txtSoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(229, 253);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 29);
            this.btnSair.TabIndex = 47;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmMeuSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 294);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.btnOk);
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
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.Button btnSair;
    }
}

