namespace LoopFor
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.lista2 = new System.Windows.Forms.ListBox();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NImpares = new System.Windows.Forms.ListBox();
            this.btnImpares = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Npar = new System.Windows.Forms.ListBox();
            this.btnPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(97, 346);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 16;
            this.lista.Location = new System.Drawing.Point(71, 56);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(120, 260);
            this.lista.TabIndex = 1;
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.ItemHeight = 16;
            this.lista2.Location = new System.Drawing.Point(256, 56);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(120, 260);
            this.lista2.TabIndex = 3;
            // 
            // btnOk2
            // 
            this.btnOk2.Location = new System.Drawing.Point(282, 346);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(75, 23);
            this.btnOk2.TabIndex = 2;
            this.btnOk2.Text = "Ok";
            this.btnOk2.UseVisualStyleBackColor = true;
            this.btnOk2.Click += new System.EventHandler(this.btnOk2_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(703, 435);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista crescente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista decrescente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Impar";
            // 
            // NImpares
            // 
            this.NImpares.FormattingEnabled = true;
            this.NImpares.ItemHeight = 16;
            this.NImpares.Location = new System.Drawing.Point(443, 56);
            this.NImpares.Name = "NImpares";
            this.NImpares.Size = new System.Drawing.Size(120, 260);
            this.NImpares.TabIndex = 8;
            // 
            // btnImpares
            // 
            this.btnImpares.Location = new System.Drawing.Point(469, 346);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(75, 23);
            this.btnImpares.TabIndex = 7;
            this.btnImpares.Text = "Ok";
            this.btnImpares.UseVisualStyleBackColor = true;
            this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Par";
            // 
            // Npar
            // 
            this.Npar.FormattingEnabled = true;
            this.Npar.ItemHeight = 16;
            this.Npar.Location = new System.Drawing.Point(620, 56);
            this.Npar.Name = "Npar";
            this.Npar.Size = new System.Drawing.Size(120, 260);
            this.Npar.TabIndex = 11;
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(646, 346);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(75, 23);
            this.btnPar.TabIndex = 10;
            this.btnPar.Text = "Ok";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Npar);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NImpares);
            this.Controls.Add(this.btnImpares);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.btnOk2);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnOk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.ListBox lista2;
        private System.Windows.Forms.Button btnOk2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox NImpares;
        private System.Windows.Forms.Button btnImpares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Npar;
        private System.Windows.Forms.Button btnPar;
    }
}

