namespace Entra21.BancoDadoCidades.Ado.Net.Views.UnidadesFederativas
{
    partial class UnidadeFederativaCadastroEditarForm
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelNomeEstado = new System.Windows.Forms.Label();
            this.labelSigla = new System.Windows.Forms.Label();
            this.textBoxNomeEstado = new System.Windows.Forms.TextBox();
            this.maskedTextBoxSigla = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(292, 84);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(194, 83);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelNomeEstado
            // 
            this.labelNomeEstado.AutoSize = true;
            this.labelNomeEstado.Location = new System.Drawing.Point(12, 9);
            this.labelNomeEstado.Name = "labelNomeEstado";
            this.labelNomeEstado.Size = new System.Drawing.Size(78, 15);
            this.labelNomeEstado.TabIndex = 2;
            this.labelNomeEstado.Text = "Nome Estado";
            // 
            // labelSigla
            // 
            this.labelSigla.AutoSize = true;
            this.labelSigla.Location = new System.Drawing.Point(12, 66);
            this.labelSigla.Name = "labelSigla";
            this.labelSigla.Size = new System.Drawing.Size(32, 15);
            this.labelSigla.TabIndex = 3;
            this.labelSigla.Text = "Sigla";
            // 
            // textBoxNomeEstado
            // 
            this.textBoxNomeEstado.Location = new System.Drawing.Point(12, 27);
            this.textBoxNomeEstado.Name = "textBoxNomeEstado";
            this.textBoxNomeEstado.Size = new System.Drawing.Size(355, 23);
            this.textBoxNomeEstado.TabIndex = 4;
            // 
            // maskedTextBoxSigla
            // 
            this.maskedTextBoxSigla.Location = new System.Drawing.Point(12, 84);
            this.maskedTextBoxSigla.Mask = "LL";
            this.maskedTextBoxSigla.Name = "maskedTextBoxSigla";
            this.maskedTextBoxSigla.Size = new System.Drawing.Size(39, 23);
            this.maskedTextBoxSigla.TabIndex = 5;
            this.maskedTextBoxSigla.Leave += new System.EventHandler(this.maskedTextBoxSigla_Leave);
            // 
            // UnidadeFederativaCadastroEditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 121);
            this.Controls.Add(this.maskedTextBoxSigla);
            this.Controls.Add(this.textBoxNomeEstado);
            this.Controls.Add(this.labelSigla);
            this.Controls.Add(this.labelNomeEstado);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "UnidadeFederativaCadastroEditarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidade Federativa Cadastro Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonCancelar;
        private Label labelNomeEstado;
        private Label labelSigla;
        private TextBox textBoxNomeEstado;
        private MaskedTextBox maskedTextBoxSigla;
    }
}