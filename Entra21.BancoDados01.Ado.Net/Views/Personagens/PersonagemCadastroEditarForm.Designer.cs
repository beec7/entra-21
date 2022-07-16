namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    partial class PersonagemCadastroEditarForm
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCanselar = new System.Windows.Forms.Button();
            this.labelEditora = new System.Windows.Forms.Label();
            this.comboBoxEditora = new System.Windows.Forms.ComboBox();
            this.labelTipoPersonagem = new System.Windows.Forms.Label();
            this.comboBoxTipoPersonagem = new System.Windows.Forms.ComboBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(465, 209);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCanselar
            // 
            this.buttonCanselar.Location = new System.Drawing.Point(365, 209);
            this.buttonCanselar.Name = "buttonCanselar";
            this.buttonCanselar.Size = new System.Drawing.Size(94, 29);
            this.buttonCanselar.TabIndex = 1;
            this.buttonCanselar.Text = "Cancelar";
            this.buttonCanselar.UseVisualStyleBackColor = true;
            // 
            // labelEditora
            // 
            this.labelEditora.AutoSize = true;
            this.labelEditora.Location = new System.Drawing.Point(21, 79);
            this.labelEditora.Name = "labelEditora";
            this.labelEditora.Size = new System.Drawing.Size(57, 20);
            this.labelEditora.TabIndex = 2;
            this.labelEditora.Text = "Editora";
            // 
            // comboBoxEditora
            // 
            this.comboBoxEditora.FormattingEnabled = true;
            this.comboBoxEditora.Location = new System.Drawing.Point(21, 102);
            this.comboBoxEditora.Name = "comboBoxEditora";
            this.comboBoxEditora.Size = new System.Drawing.Size(538, 28);
            this.comboBoxEditora.TabIndex = 3;
            // 
            // labelTipoPersonagem
            // 
            this.labelTipoPersonagem.AutoSize = true;
            this.labelTipoPersonagem.Location = new System.Drawing.Point(21, 143);
            this.labelTipoPersonagem.Name = "labelTipoPersonagem";
            this.labelTipoPersonagem.Size = new System.Drawing.Size(124, 20);
            this.labelTipoPersonagem.TabIndex = 4;
            this.labelTipoPersonagem.Text = "Tipo Personagem";
            // 
            // comboBoxTipoPersonagem
            // 
            this.comboBoxTipoPersonagem.DisplayMember = "Tipo";
            this.comboBoxTipoPersonagem.FormattingEnabled = true;
            this.comboBoxTipoPersonagem.Location = new System.Drawing.Point(21, 166);
            this.comboBoxTipoPersonagem.Name = "comboBoxTipoPersonagem";
            this.comboBoxTipoPersonagem.Size = new System.Drawing.Size(538, 28);
            this.comboBoxTipoPersonagem.TabIndex = 5;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(21, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 20);
            this.labelNome.TabIndex = 6;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(21, 33);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(538, 27);
            this.textBoxNome.TabIndex = 7;
            // 
            // PersonagemCadastroEditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 253);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.comboBoxTipoPersonagem);
            this.Controls.Add(this.labelTipoPersonagem);
            this.Controls.Add(this.comboBoxEditora);
            this.Controls.Add(this.labelEditora);
            this.Controls.Add(this.buttonCanselar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "PersonagemCadastroEditarForm";
            this.Text = "PersonagemCadastroEditarForm";
            this.Load += new System.EventHandler(this.PersonagemCadastroEditarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonCanselar;
        private Label labelEditora;
        private ComboBox comboBoxEditora;
        private Label labelTipoPersonagem;
        private ComboBox comboBoxTipoPersonagem;
        private Label labelNome;
        private TextBox textBoxNome;
    }
}