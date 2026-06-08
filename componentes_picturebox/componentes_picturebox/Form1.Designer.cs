namespace componentes_picturebox
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
            this.radioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radioButtonToolStripMenuItem,
            this.checkBoxToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // radioButtonToolStripMenuItem
            // 
            this.radioButtonToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.radioButtonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.radioButtonToolStripMenuItem.Name = "radioButtonToolStripMenuItem";
            this.radioButtonToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.radioButtonToolStripMenuItem.Text = "RadioButton";
            this.radioButtonToolStripMenuItem.Click += new System.EventHandler(this.radioButtonToolStripMenuItem_Click);
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.checkBoxToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.listBoxToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(85, 32);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.comboBoxToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(121, 32);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(458, 680);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.button1;
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
        private System.Windows.Forms.ToolStripMenuItem radioButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

