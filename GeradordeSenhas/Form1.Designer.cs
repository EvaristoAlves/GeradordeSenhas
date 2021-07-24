
namespace GeradordeSenhas
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
            this.lista_senhas = new System.Windows.Forms.ListBox();
            this.check_maiuscula = new System.Windows.Forms.CheckBox();
            this.cmd_gerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.count_chars = new System.Windows.Forms.NumericUpDown();
            this.check_numeros = new System.Windows.Forms.CheckBox();
            this.check_simbolos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.count_chars)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_senhas
            // 
            this.lista_senhas.FormattingEnabled = true;
            this.lista_senhas.Location = new System.Drawing.Point(0, 0);
            this.lista_senhas.Name = "lista_senhas";
            this.lista_senhas.Size = new System.Drawing.Size(292, 355);
            this.lista_senhas.TabIndex = 0;
            // 
            // check_maiuscula
            // 
            this.check_maiuscula.AutoSize = true;
            this.check_maiuscula.Location = new System.Drawing.Point(333, 104);
            this.check_maiuscula.Name = "check_maiuscula";
            this.check_maiuscula.Size = new System.Drawing.Size(108, 17);
            this.check_maiuscula.TabIndex = 1;
            this.check_maiuscula.Text = "Utilizar Maiúscula";
            this.check_maiuscula.UseVisualStyleBackColor = true;
            // 
            // cmd_gerar
            // 
            this.cmd_gerar.Location = new System.Drawing.Point(333, 332);
            this.cmd_gerar.Name = "cmd_gerar";
            this.cmd_gerar.Size = new System.Drawing.Size(75, 23);
            this.cmd_gerar.TabIndex = 2;
            this.cmd_gerar.Text = "Gerar Senha";
            this.cmd_gerar.UseVisualStyleBackColor = true;
            this.cmd_gerar.Click += new System.EventHandler(this.cmd_gerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numeros Caracteres\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // count_chars
            // 
            this.count_chars.Location = new System.Drawing.Point(333, 53);
            this.count_chars.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.count_chars.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.count_chars.Name = "count_chars";
            this.count_chars.Size = new System.Drawing.Size(120, 20);
            this.count_chars.TabIndex = 4;
            this.count_chars.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.count_chars.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // check_numeros
            // 
            this.check_numeros.AutoSize = true;
            this.check_numeros.Location = new System.Drawing.Point(333, 127);
            this.check_numeros.Name = "check_numeros";
            this.check_numeros.Size = new System.Drawing.Size(102, 17);
            this.check_numeros.TabIndex = 5;
            this.check_numeros.Text = "Utilizar Números";
            this.check_numeros.UseVisualStyleBackColor = true;
            // 
            // check_simbolos
            // 
            this.check_simbolos.AutoSize = true;
            this.check_simbolos.Location = new System.Drawing.Point(333, 150);
            this.check_simbolos.Name = "check_simbolos";
            this.check_simbolos.Size = new System.Drawing.Size(104, 17);
            this.check_simbolos.TabIndex = 6;
            this.check_simbolos.Text = "Utilizar Símbolos";
            this.check_simbolos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.check_simbolos);
            this.Controls.Add(this.check_numeros);
            this.Controls.Add(this.count_chars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_gerar);
            this.Controls.Add(this.check_maiuscula);
            this.Controls.Add(this.lista_senhas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.count_chars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista_senhas;
        private System.Windows.Forms.CheckBox check_maiuscula;
        private System.Windows.Forms.Button cmd_gerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown count_chars;
        private System.Windows.Forms.CheckBox check_numeros;
        private System.Windows.Forms.CheckBox check_simbolos;
    }
}

