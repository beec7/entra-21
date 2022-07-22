namespace Entra21.BancoDadoCidades.Ado.Net.Views.Cidades
{
    partial class CidadeCadastroEditarForm
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
            this.comboBoxUnidadeFederativa = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataFundacao = new System.Windows.Forms.DateTimePicker();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantidadeHabitante = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxHoraFundacao = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPib = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelUnidadeFederativa = new System.Windows.Forms.Label();
            this.labelDataFundacao = new System.Windows.Forms.Label();
            this.labelHoraFundacao = new System.Windows.Forms.Label();
            this.labelQuantidadeHabitante = new System.Windows.Forms.Label();
            this.labelPib = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidadeHabitante)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(331, 252);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(88, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(237, 252);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(88, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxUnidadeFederativa
            // 
            this.comboBoxUnidadeFederativa.DisplayMember = "Nome";
            this.comboBoxUnidadeFederativa.FormattingEnabled = true;
            this.comboBoxUnidadeFederativa.Location = new System.Drawing.Point(12, 71);
            this.comboBoxUnidadeFederativa.Name = "comboBoxUnidadeFederativa";
            this.comboBoxUnidadeFederativa.Size = new System.Drawing.Size(302, 23);
            this.comboBoxUnidadeFederativa.TabIndex = 2;
            // 
            // dateTimePickerDataFundacao
            // 
            this.dateTimePickerDataFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataFundacao.Location = new System.Drawing.Point(12, 119);
            this.dateTimePickerDataFundacao.Name = "dateTimePickerDataFundacao";
            this.dateTimePickerDataFundacao.Size = new System.Drawing.Size(155, 23);
            this.dateTimePickerDataFundacao.TabIndex = 3;
            this.dateTimePickerDataFundacao.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(12, 27);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(407, 23);
            this.textBoxCidade.TabIndex = 4;
            // 
            // numericUpDownQuantidadeHabitante
            // 
            this.numericUpDownQuantidadeHabitante.Location = new System.Drawing.Point(12, 171);
            this.numericUpDownQuantidadeHabitante.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.numericUpDownQuantidadeHabitante.Name = "numericUpDownQuantidadeHabitante";
            this.numericUpDownQuantidadeHabitante.Size = new System.Drawing.Size(155, 23);
            this.numericUpDownQuantidadeHabitante.TabIndex = 5;
            // 
            // maskedTextBoxHoraFundacao
            // 
            this.maskedTextBoxHoraFundacao.Location = new System.Drawing.Point(210, 119);
            this.maskedTextBoxHoraFundacao.Mask = "00:00";
            this.maskedTextBoxHoraFundacao.Name = "maskedTextBoxHoraFundacao";
            this.maskedTextBoxHoraFundacao.Size = new System.Drawing.Size(104, 23);
            this.maskedTextBoxHoraFundacao.TabIndex = 6;
            this.maskedTextBoxHoraFundacao.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxPib
            // 
            this.textBoxPib.Location = new System.Drawing.Point(12, 221);
            this.textBoxPib.Name = "textBoxPib";
            this.textBoxPib.Size = new System.Drawing.Size(302, 23);
            this.textBoxPib.TabIndex = 7;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(12, 9);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(96, 15);
            this.labelCidade.TabIndex = 8;
            this.labelCidade.Text = "Nome da Cidade";
            // 
            // labelUnidadeFederativa
            // 
            this.labelUnidadeFederativa.AutoSize = true;
            this.labelUnidadeFederativa.Location = new System.Drawing.Point(12, 53);
            this.labelUnidadeFederativa.Name = "labelUnidadeFederativa";
            this.labelUnidadeFederativa.Size = new System.Drawing.Size(108, 15);
            this.labelUnidadeFederativa.TabIndex = 9;
            this.labelUnidadeFederativa.Text = "Unidade Federativa";
            // 
            // labelDataFundacao
            // 
            this.labelDataFundacao.AutoSize = true;
            this.labelDataFundacao.Location = new System.Drawing.Point(12, 101);
            this.labelDataFundacao.Name = "labelDataFundacao";
            this.labelDataFundacao.Size = new System.Drawing.Size(102, 15);
            this.labelDataFundacao.TabIndex = 10;
            this.labelDataFundacao.Text = "Data da Fundação";
            // 
            // labelHoraFundacao
            // 
            this.labelHoraFundacao.AutoSize = true;
            this.labelHoraFundacao.Location = new System.Drawing.Point(210, 101);
            this.labelHoraFundacao.Name = "labelHoraFundacao";
            this.labelHoraFundacao.Size = new System.Drawing.Size(104, 15);
            this.labelHoraFundacao.TabIndex = 11;
            this.labelHoraFundacao.Text = "Hora da Fundação";
            // 
            // labelQuantidadeHabitante
            // 
            this.labelQuantidadeHabitante.AutoSize = true;
            this.labelQuantidadeHabitante.Location = new System.Drawing.Point(12, 153);
            this.labelQuantidadeHabitante.Name = "labelQuantidadeHabitante";
            this.labelQuantidadeHabitante.Size = new System.Drawing.Size(124, 15);
            this.labelQuantidadeHabitante.TabIndex = 12;
            this.labelQuantidadeHabitante.Text = "Quantidade Habitante";
            // 
            // labelPib
            // 
            this.labelPib.AutoSize = true;
            this.labelPib.Location = new System.Drawing.Point(12, 203);
            this.labelPib.Name = "labelPib";
            this.labelPib.Size = new System.Drawing.Size(24, 15);
            this.labelPib.TabIndex = 13;
            this.labelPib.Text = "PIB";
            // 
            // CidadeCadastroEditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 285);
            this.Controls.Add(this.labelPib);
            this.Controls.Add(this.labelQuantidadeHabitante);
            this.Controls.Add(this.labelHoraFundacao);
            this.Controls.Add(this.labelDataFundacao);
            this.Controls.Add(this.labelUnidadeFederativa);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxPib);
            this.Controls.Add(this.maskedTextBoxHoraFundacao);
            this.Controls.Add(this.numericUpDownQuantidadeHabitante);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.dateTimePickerDataFundacao);
            this.Controls.Add(this.comboBoxUnidadeFederativa);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "CidadeCadastroEditarForm";
            this.Text = "CidadeCadastroEditarForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidadeHabitante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonCancelar;
        private ComboBox comboBoxUnidadeFederativa;
        private DateTimePicker dateTimePickerDataFundacao;
        private TextBox textBoxCidade;
        private NumericUpDown numericUpDownQuantidadeHabitante;
        private MaskedTextBox maskedTextBoxHoraFundacao;
        private TextBox textBoxPib;
        private Label labelCidade;
        private Label labelUnidadeFederativa;
        private Label labelDataFundacao;
        private Label labelHoraFundacao;
        private Label labelQuantidadeHabitante;
        private Label labelPib;
    }
}