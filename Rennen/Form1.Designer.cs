namespace Rennen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEinsteigen = new System.Windows.Forms.Button();
            this.btnAussteigen = new System.Windows.Forms.Button();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.chBox1 = new System.Windows.Forms.CheckBox();
            this.chBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnEinsteigen
            // 
            this.btnEinsteigen.Location = new System.Drawing.Point(55, 18);
            this.btnEinsteigen.Margin = new System.Windows.Forms.Padding(4);
            this.btnEinsteigen.Name = "btnEinsteigen";
            this.btnEinsteigen.Size = new System.Drawing.Size(286, 201);
            this.btnEinsteigen.TabIndex = 0;
            this.btnEinsteigen.Text = "Einsteigen";
            this.btnEinsteigen.UseVisualStyleBackColor = true;
            this.btnEinsteigen.Click += new System.EventHandler(this.btnEinsteigen_Click);
            // 
            // btnAussteigen
            // 
            this.btnAussteigen.Location = new System.Drawing.Point(55, 322);
            this.btnAussteigen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAussteigen.Name = "btnAussteigen";
            this.btnAussteigen.Size = new System.Drawing.Size(286, 201);
            this.btnAussteigen.TabIndex = 1;
            this.btnAussteigen.Text = "Aussteigen";
            this.btnAussteigen.UseVisualStyleBackColor = true;
            this.btnAussteigen.Click += new System.EventHandler(this.btnAussteigen_Click);
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(395, 18);
            this.txtAusgabe.Margin = new System.Windows.Forms.Padding(4);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.Size = new System.Drawing.Size(547, 504);
            this.txtAusgabe.TabIndex = 2;
            // 
            // chBox1
            // 
            this.chBox1.AutoSize = true;
            this.chBox1.Location = new System.Drawing.Point(55, 227);
            this.chBox1.Name = "chBox1";
            this.chBox1.Size = new System.Drawing.Size(85, 29);
            this.chBox1.TabIndex = 3;
            this.chBox1.Text = "Anne";
            this.chBox1.UseVisualStyleBackColor = true;
            // 
            // chBox2
            // 
            this.chBox2.AutoSize = true;
            this.chBox2.Location = new System.Drawing.Point(55, 263);
            this.chBox2.Name = "chBox2";
            this.chBox2.Size = new System.Drawing.Size(84, 29);
            this.chBox2.TabIndex = 4;
            this.chBox2.Text = "Peter";
            this.chBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.chBox2);
            this.Controls.Add(this.chBox1);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.btnAussteigen);
            this.Controls.Add(this.btnEinsteigen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEinsteigen;
        private System.Windows.Forms.Button btnAussteigen;
        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.CheckBox chBox1;
        private System.Windows.Forms.CheckBox chBox2;
    }
}

