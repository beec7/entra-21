namespace Entra21.BancoDados01.Ado.Net.Views
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
            this.buttonTipoPersonagem = new System.Windows.Forms.Button();
            this.buttonPersonagem = new System.Windows.Forms.Button();
            this.buttonEditora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTipoPersonagem
            // 
            this.buttonTipoPersonagem.Location = new System.Drawing.Point(12, 12);
            this.buttonTipoPersonagem.Name = "buttonTipoPersonagem";
            this.buttonTipoPersonagem.Size = new System.Drawing.Size(168, 217);
            this.buttonTipoPersonagem.TabIndex = 0;
            this.buttonTipoPersonagem.Text = "Tipo Personagem";
            this.buttonTipoPersonagem.UseVisualStyleBackColor = true;
            this.buttonTipoPersonagem.Click += new System.EventHandler(this.buttonTipoPersonagem_Click);
            // 
            // buttonPersonagem
            // 
            this.buttonPersonagem.Location = new System.Drawing.Point(186, 12);
            this.buttonPersonagem.Name = "buttonPersonagem";
            this.buttonPersonagem.Size = new System.Drawing.Size(168, 217);
            this.buttonPersonagem.TabIndex = 1;
            this.buttonPersonagem.Text = "Personagem";
            this.buttonPersonagem.UseVisualStyleBackColor = true;
            this.buttonPersonagem.Click += new System.EventHandler(this.buttonPersonagem_Click);
            // 
            // buttonEditora
            // 
            this.buttonEditora.Location = new System.Drawing.Point(360, 12);
            this.buttonEditora.Name = "buttonEditora";
            this.buttonEditora.Size = new System.Drawing.Size(168, 217);
            this.buttonEditora.TabIndex = 2;
            this.buttonEditora.Text = "Editora";
            this.buttonEditora.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 247);
            this.Controls.Add(this.buttonEditora);
            this.Controls.Add(this.buttonPersonagem);
            this.Controls.Add(this.buttonTipoPersonagem);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.Load += new System.EventHandler(this.MenuPrincipalForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonTipoPersonagem;
        private Button buttonPersonagem;
        private Button buttonEditora;
    }
}