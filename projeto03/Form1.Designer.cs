namespace projeto03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboPolos = new System.Windows.Forms.ComboBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDhabiles = new System.Windows.Forms.TextBox();
            this.tbPromedio = new System.Windows.Forms.TextBox();
            this.tbAutosuficiencia = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbReposicion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboPolos
            // 
            this.cboPolos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPolos.FormattingEnabled = true;
            this.cboPolos.Location = new System.Drawing.Point(252, 97);
            this.cboPolos.Name = "cboPolos";
            this.cboPolos.Size = new System.Drawing.Size(319, 29);
            this.cboPolos.TabIndex = 0;
            this.cboPolos.SelectedIndexChanged += new System.EventHandler(this.CboPolos_SelectedIndexChanged);
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(432, 147);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(100, 23);
            this.tbStock.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock :";
            // 
            // tbVenda
            // 
            this.tbVenda.Location = new System.Drawing.Point(432, 176);
            this.tbVenda.Name = "tbVenda";
            this.tbVenda.Size = new System.Drawing.Size(100, 23);
            this.tbVenda.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Venda :";
            // 
            // tbDhabiles
            // 
            this.tbDhabiles.Location = new System.Drawing.Point(432, 205);
            this.tbDhabiles.Name = "tbDhabiles";
            this.tbDhabiles.Size = new System.Drawing.Size(100, 23);
            this.tbDhabiles.TabIndex = 5;
            // 
            // tbPromedio
            // 
            this.tbPromedio.Location = new System.Drawing.Point(432, 234);
            this.tbPromedio.Name = "tbPromedio";
            this.tbPromedio.Size = new System.Drawing.Size(100, 23);
            this.tbPromedio.TabIndex = 6;
            // 
            // tbAutosuficiencia
            // 
            this.tbAutosuficiencia.Location = new System.Drawing.Point(432, 263);
            this.tbAutosuficiencia.Name = "tbAutosuficiencia";
            this.tbAutosuficiencia.Size = new System.Drawing.Size(100, 23);
            this.tbAutosuficiencia.TabIndex = 7;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(432, 292);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(100, 23);
            this.tbCategoria.TabIndex = 8;
            // 
            // tbReposicion
            // 
            this.tbReposicion.Location = new System.Drawing.Point(432, 321);
            this.tbReposicion.Name = "tbReposicion";
            this.tbReposicion.Size = new System.Drawing.Size(100, 23);
            this.tbReposicion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dias Habiles :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Promedio :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Autosuficiencia :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categoria :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Reposicion :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "RELACION DE POLOS ACTIVOS EN BRASIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbReposicion);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbAutosuficiencia);
            this.Controls.Add(this.tbPromedio);
            this.Controls.Add(this.tbDhabiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.cboPolos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboPolos;
        private TextBox tbStock;
        private Label label1;
        private TextBox tbVenda;
        private Label label2;
        private TextBox tbDhabiles;
        private TextBox tbPromedio;
        private TextBox tbAutosuficiencia;
        private TextBox tbCategoria;
        private TextBox tbReposicion;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}