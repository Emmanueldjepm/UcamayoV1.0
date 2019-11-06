namespace Ucamayo_V._01
{
    partial class Clientes
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre});
            this.DataGridView1.Location = new System.Drawing.Point(46, 25);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(226, 216);
            this.DataGridView1.TabIndex = 12;
            // 
            // Clave
            // 
            this.Clave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Clave.FillWeight = 80F;
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(219, 316);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(34, 23);
            this.Button5.TabIndex = 11;
            this.Button5.Text = "Button5";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(139, 316);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(34, 23);
            this.Button4.TabIndex = 10;
            this.Button4.Text = "Button4";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(179, 317);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(34, 23);
            this.Button3.TabIndex = 9;
            this.Button3.Text = "Button3";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(99, 317);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(34, 23);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "Button2";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(59, 317);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(34, 23);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 365);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
    }
}