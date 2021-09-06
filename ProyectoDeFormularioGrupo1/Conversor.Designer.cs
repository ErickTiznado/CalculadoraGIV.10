
namespace ProyectoDeFormularioGrupo1
{
    partial class Conversor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.cbxentrada = new System.Windows.Forms.ComboBox();
            this.cbxsalida = new System.Windows.Forms.ComboBox();
            this.cmdconvertir = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblum = new System.Windows.Forms.Label();
            this.lblr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese valor:";
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtvalor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtvalor.Location = new System.Drawing.Point(154, 53);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(5);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(177, 33);
            this.txtvalor.TabIndex = 3;
            this.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxentrada
            // 
            this.cbxentrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxentrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxentrada.FormattingEnabled = true;
            this.cbxentrada.Items.AddRange(new object[] {
            "Milimetros",
            "Centimetros",
            "Metros",
            "Kilometros"});
            this.cbxentrada.Location = new System.Drawing.Point(154, 112);
            this.cbxentrada.Name = "cbxentrada";
            this.cbxentrada.Size = new System.Drawing.Size(177, 33);
            this.cbxentrada.TabIndex = 4;
            // 
            // cbxsalida
            // 
            this.cbxsalida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxsalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsalida.FormattingEnabled = true;
            this.cbxsalida.Items.AddRange(new object[] {
            "Milimetros",
            "Centimetros",
            "Metros",
            "Kilometros"});
            this.cbxsalida.Location = new System.Drawing.Point(155, 180);
            this.cbxsalida.Name = "cbxsalida";
            this.cbxsalida.Size = new System.Drawing.Size(176, 33);
            this.cbxsalida.TabIndex = 5;
            // 
            // cmdconvertir
            // 
            this.cmdconvertir.BackColor = System.Drawing.SystemColors.Control;
            this.cmdconvertir.Location = new System.Drawing.Point(377, 56);
            this.cmdconvertir.Name = "cmdconvertir";
            this.cmdconvertir.Size = new System.Drawing.Size(148, 40);
            this.cmdconvertir.TabIndex = 6;
            this.cmdconvertir.Text = "Convertir";
            this.cmdconvertir.UseVisualStyleBackColor = false;
            this.cmdconvertir.Click += new System.EventHandler(this.cmdconvertir_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.Location = new System.Drawing.Point(377, 168);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(148, 40);
            this.cmdnuevo.TabIndex = 7;
            this.cmdnuevo.Text = "Nuevo";
            this.cmdnuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.lblum);
            this.groupBox1.Controls.Add(this.lblr);
            this.groupBox1.Location = new System.Drawing.Point(154, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 101);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // lblum
            // 
            this.lblum.Location = new System.Drawing.Point(191, 41);
            this.lblum.Name = "lblum";
            this.lblum.Size = new System.Drawing.Size(63, 28);
            this.lblum.TabIndex = 8;
            // 
            // lblr
            // 
            this.lblr.Location = new System.Drawing.Point(6, 41);
            this.lblr.Name = "lblr";
            this.lblr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblr.Size = new System.Drawing.Size(189, 25);
            this.lblr.TabIndex = 5;
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1257, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdnuevo);
            this.Controls.Add(this.cmdconvertir);
            this.Controls.Add(this.cbxsalida);
            this.Controls.Add(this.cbxentrada);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Conversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertidor";
            this.Load += new System.EventHandler(this.Conversor_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ComboBox cbxentrada;
        private System.Windows.Forms.ComboBox cbxsalida;
        private System.Windows.Forms.Button cmdconvertir;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.Label lblum;
    }
}