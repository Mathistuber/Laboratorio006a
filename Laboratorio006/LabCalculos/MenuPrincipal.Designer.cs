
namespace Laboratorio006.LabCalculos
{
    partial class MenuPrincipal
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
            this.btnMaior = new System.Windows.Forms.Button();
            this.btnFrete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(156, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal de Atividades";
            // 
            // btnMaior
            // 
            this.btnMaior.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaior.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaior.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaior.Location = new System.Drawing.Point(228, 142);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(381, 106);
            this.btnMaior.TabIndex = 1;
            this.btnMaior.Text = "Maior Número de Três";
            this.btnMaior.UseVisualStyleBackColor = false;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // btnFrete
            // 
            this.btnFrete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFrete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFrete.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFrete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFrete.Location = new System.Drawing.Point(228, 268);
            this.btnFrete.Name = "btnFrete";
            this.btnFrete.Size = new System.Drawing.Size(381, 110);
            this.btnFrete.TabIndex = 2;
            this.btnFrete.Text = "Cálculo de Frete";
            this.btnFrete.UseVisualStyleBackColor = false;
            this.btnFrete.Click += new System.EventHandler(this.btnFrete_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFrete);
            this.Controls.Add(this.btnMaior);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaior;
        private System.Windows.Forms.Button btnFrete;
    }
}