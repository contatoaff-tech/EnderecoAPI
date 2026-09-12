namespace WindowsFormsApp1
{
    partial class FormConsultas
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
            this.txt_logradouro = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.dataGridViewEnderecos = new System.Windows.Forms.DataGridView();
            this.button_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.AutoSize = true;
            this.txt_logradouro.Location = new System.Drawing.Point(21, 9);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(131, 13);
            this.txt_logradouro.TabIndex = 0;
            this.txt_logradouro.Text = "Pesquise por Logradouro :";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(24, 25);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(750, 20);
            this.txt_pesquisa.TabIndex = 1;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewEnderecos
            // 
            this.dataGridViewEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnderecos.Location = new System.Drawing.Point(24, 67);
            this.dataGridViewEnderecos.Name = "dataGridViewEnderecos";
            this.dataGridViewEnderecos.Size = new System.Drawing.Size(750, 345);
            this.dataGridViewEnderecos.TabIndex = 2;
            this.dataGridViewEnderecos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnderecos_CellDoubleClick);
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(699, 418);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(75, 23);
            this.button_Voltar.TabIndex = 3;
            this.button_Voltar.Text = "Voltar";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.dataGridViewEnderecos);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.txt_logradouro);
            this.Name = "FormConsultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnderecos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_logradouro;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.DataGridView dataGridViewEnderecos;
        private System.Windows.Forms.Button button_Voltar;
    }
}