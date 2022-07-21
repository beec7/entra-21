namespace Entra21.BancoDadoCidades.Ado.Net.Views
{
    partial class MenuPrincipalForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUnidadeFederativa = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonUnidadeFederativa
            // 
            this.buttonUnidadeFederativa.Location = new System.Drawing.Point(12, 12);
            this.buttonUnidadeFederativa.Name = "buttonUnidadeFederativa";
            this.buttonUnidadeFederativa.Size = new System.Drawing.Size(124, 104);
            this.buttonUnidadeFederativa.TabIndex = 1;
            this.buttonUnidadeFederativa.Text = "Unidade Federativa";
            this.buttonUnidadeFederativa.UseVisualStyleBackColor = true;
            this.buttonUnidadeFederativa.Click += new System.EventHandler(this.buttonUnidadeFederativa_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(12, 151);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(308, 23);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 186);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonUnidadeFederativa);
            this.Controls.Add(this.button1);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button buttonUnidadeFederativa;
        private Button buttonSair;
    }
}