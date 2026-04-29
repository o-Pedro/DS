namespace Desvio_Condicional
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.desvioCondicionalIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desvioCondicionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desvioCondicionalEncadeadoIFELSEIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desvioCondicionalIFToolStripMenuItem,
            this.desvioCondicionalToolStripMenuItem,
            this.desvioCondicionalEncadeadoIFELSEIFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // desvioCondicionalIFToolStripMenuItem
            // 
            this.desvioCondicionalIFToolStripMenuItem.Name = "desvioCondicionalIFToolStripMenuItem";
            this.desvioCondicionalIFToolStripMenuItem.Size = new System.Drawing.Size(177, 20);
            this.desvioCondicionalIFToolStripMenuItem.Text = "Desvio Condicional Simples IF";
            // 
            // desvioCondicionalToolStripMenuItem
            // 
            this.desvioCondicionalToolStripMenuItem.Name = "desvioCondicionalToolStripMenuItem";
            this.desvioCondicionalToolStripMenuItem.Size = new System.Drawing.Size(221, 20);
            this.desvioCondicionalToolStripMenuItem.Text = "Desvio Condicional Composto IF/ELSE";
            // 
            // desvioCondicionalEncadeadoIFELSEIFToolStripMenuItem
            // 
            this.desvioCondicionalEncadeadoIFELSEIFToolStripMenuItem.Name = "desvioCondicionalEncadeadoIFELSEIFToolStripMenuItem";
            this.desvioCondicionalEncadeadoIFELSEIFToolStripMenuItem.Size = new System.Drawing.Size(237, 20);
            this.desvioCondicionalEncadeadoIFELSEIFToolStripMenuItem.Text = "Desvio Condicional Encadeado IF_ELSE/IF";
            this.desvioCondicionalEncadeadoIFELSEIFToolStripMenuItem.Click += new System.EventHandler(this.desvioCondicionalEncadeadoIFELSEIFToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Onyx", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(458, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desvioCondicionalIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desvioCondicionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desvioCondicionalEncadeadoIFELSEIFToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

