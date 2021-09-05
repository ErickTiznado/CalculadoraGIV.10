
namespace ProyectoDeFormularioGrupo1
{
    partial class Ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaAvanzadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarUnProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ayuda de la calculadora";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(37, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(617, 201);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaAvanzadaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 38);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaAvanzadaToolStripMenuItem
            // 
            this.ayudaAvanzadaToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.ayudaAvanzadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportarUnProblemaToolStripMenuItem});
            this.ayudaAvanzadaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ayudaAvanzadaToolStripMenuItem.Name = "ayudaAvanzadaToolStripMenuItem";
            this.ayudaAvanzadaToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.ayudaAvanzadaToolStripMenuItem.Text = "Ayuda Avanzada";
            // 
            // reportarUnProblemaToolStripMenuItem
            // 
            this.reportarUnProblemaToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.reportarUnProblemaToolStripMenuItem.Name = "reportarUnProblemaToolStripMenuItem";
            this.reportarUnProblemaToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
            this.reportarUnProblemaToolStripMenuItem.Text = "Reportar un Problema";
            this.reportarUnProblemaToolStripMenuItem.Click += new System.EventHandler(this.reportarUnProblemaToolStripMenuItem_Click);
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(700, 355);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ayuda";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaAvanzadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarUnProblemaToolStripMenuItem;
    }
}