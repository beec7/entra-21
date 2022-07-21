namespace Entra21.BancoDadoCidades.Ado.Net.Views.Cidades
{
    partial class CidadeListagemForm
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.dataGridViewCidades = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeHabitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataHoraFundacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdUnidadeFederativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeUnidadeFederativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(646, 6);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(565, 6);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(484, 6);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // dataGridViewCidades
            // 
            this.dataGridViewCidades.AllowUserToAddRows = false;
            this.dataGridViewCidades.AllowUserToDeleteRows = false;
            this.dataGridViewCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnQuantidadeHabitante,
            this.ColumnDataHoraFundacao,
            this.ColumnPib,
            this.ColumnIdUnidadeFederativa,
            this.ColumnNomeUnidadeFederativa,
            this.ColumnSigla,
            this.Column1});
            this.dataGridViewCidades.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewCidades.Name = "dataGridViewCidades";
            this.dataGridViewCidades.ReadOnly = true;
            this.dataGridViewCidades.RowTemplate.Height = 25;
            this.dataGridViewCidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCidades.Size = new System.Drawing.Size(709, 327);
            this.dataGridViewCidades.TabIndex = 3;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Cidade";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnQuantidadeHabitante
            // 
            this.ColumnQuantidadeHabitante.HeaderText = "Quantidade de Habitante";
            this.ColumnQuantidadeHabitante.Name = "ColumnQuantidadeHabitante";
            this.ColumnQuantidadeHabitante.ReadOnly = true;
            // 
            // ColumnDataHoraFundacao
            // 
            this.ColumnDataHoraFundacao.HeaderText = "Data e Hora da Fundação";
            this.ColumnDataHoraFundacao.Name = "ColumnDataHoraFundacao";
            this.ColumnDataHoraFundacao.ReadOnly = true;
            // 
            // ColumnPib
            // 
            this.ColumnPib.HeaderText = "Pib";
            this.ColumnPib.Name = "ColumnPib";
            this.ColumnPib.ReadOnly = true;
            // 
            // ColumnIdUnidadeFederativa
            // 
            this.ColumnIdUnidadeFederativa.HeaderText = "IdUnidadeFederativa";
            this.ColumnIdUnidadeFederativa.Name = "ColumnIdUnidadeFederativa";
            this.ColumnIdUnidadeFederativa.ReadOnly = true;
            this.ColumnIdUnidadeFederativa.Visible = false;
            // 
            // ColumnNomeUnidadeFederativa
            // 
            this.ColumnNomeUnidadeFederativa.HeaderText = "Nome da unidade federativa";
            this.ColumnNomeUnidadeFederativa.Name = "ColumnNomeUnidadeFederativa";
            this.ColumnNomeUnidadeFederativa.ReadOnly = true;
            // 
            // ColumnSigla
            // 
            this.ColumnSigla.HeaderText = "Sigla";
            this.ColumnSigla.Name = "ColumnSigla";
            this.ColumnSigla.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // CidadeListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 374);
            this.Controls.Add(this.dataGridViewCidades);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "CidadeListagemForm";
            this.Text = "CidadeListagemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastrar;
        private Button buttonEditar;
        private Button buttonApagar;
        private DataGridView dataGridViewCidades;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnQuantidadeHabitante;
        private DataGridViewTextBoxColumn ColumnDataHoraFundacao;
        private DataGridViewTextBoxColumn ColumnPib;
        private DataGridViewTextBoxColumn ColumnIdUnidadeFederativa;
        private DataGridViewTextBoxColumn ColumnNomeUnidadeFederativa;
        private DataGridViewTextBoxColumn ColumnSigla;
        private DataGridViewTextBoxColumn Column1;
    }
}