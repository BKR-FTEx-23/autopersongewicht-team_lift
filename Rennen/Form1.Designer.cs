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
            this.SuspendLayout();
            // 
            // btnEinsteigen
            // 
            this.btnEinsteigen.Location = new System.Drawing.Point(40, 12);
            this.btnEinsteigen.Name = "btnEinsteigen";
            this.btnEinsteigen.Size = new System.Drawing.Size(208, 134);
            this.btnEinsteigen.TabIndex = 0;
            this.btnEinsteigen.Text = "Einsteigen";
            this.btnEinsteigen.UseVisualStyleBackColor = true;
            this.btnEinsteigen.Click += new System.EventHandler(this.btnEinsteigen_Click);
            // 
            // btnAussteigen
            // 
            this.btnAussteigen.Location = new System.Drawing.Point(40, 215);
            this.btnAussteigen.Name = "btnAussteigen";
            this.btnAussteigen.Size = new System.Drawing.Size(208, 134);
            this.btnAussteigen.TabIndex = 1;
            this.btnAussteigen.Text = "Aussteigen";
            this.btnAussteigen.UseVisualStyleBackColor = true;
            this.btnAussteigen.Click += new System.EventHandler(this.btnAussteigen_Click);
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(287, 12);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.Size = new System.Drawing.Size(399, 337);
            this.txtAusgabe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.btnAussteigen);
            this.Controls.Add(this.btnEinsteigen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEinsteigen;
        private System.Windows.Forms.Button btnAussteigen;
        private System.Windows.Forms.TextBox txtAusgabe;
    }
}

