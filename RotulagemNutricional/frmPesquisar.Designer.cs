namespace View
{
    partial class frmPesquisar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         this.dgvResultado = new System.Windows.Forms.DataGridView();
         this.txtFiltro = new System.Windows.Forms.TextBox();
         this.cbxTipoFiltro = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnPesquisar = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.proteina = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.lipidio = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.carboidrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.fibra = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.sodio = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.gordura = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvResultado
         // 
         this.dgvResultado.AllowUserToAddRows = false;
         this.dgvResultado.AllowUserToDeleteRows = false;
         this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.grupo,
            this.descricao,
            this.proteina,
            this.lipidio,
            this.carboidrato,
            this.fibra,
            this.sodio,
            this.gordura});
         this.dgvResultado.Location = new System.Drawing.Point(27, 149);
         this.dgvResultado.Name = "dgvResultado";
         this.dgvResultado.ReadOnly = true;
         this.dgvResultado.RowHeadersVisible = false;
         this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvResultado.Size = new System.Drawing.Size(569, 274);
         this.dgvResultado.TabIndex = 0;
         // 
         // txtFiltro
         // 
         this.txtFiltro.Location = new System.Drawing.Point(177, 90);
         this.txtFiltro.Name = "txtFiltro";
         this.txtFiltro.Size = new System.Drawing.Size(320, 20);
         this.txtFiltro.TabIndex = 1;
         // 
         // cbxTipoFiltro
         // 
         this.cbxTipoFiltro.FormattingEnabled = true;
         this.cbxTipoFiltro.Location = new System.Drawing.Point(108, 35);
         this.cbxTipoFiltro.Name = "cbxTipoFiltro";
         this.cbxTipoFiltro.Size = new System.Drawing.Size(121, 21);
         this.cbxTipoFiltro.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(24, 38);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(78, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Onde procurar:";
         // 
         // btnPesquisar
         // 
         this.btnPesquisar.Location = new System.Drawing.Point(521, 88);
         this.btnPesquisar.Name = "btnPesquisar";
         this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
         this.btnPesquisar.TabIndex = 4;
         this.btnPesquisar.Text = "Pesquisar";
         this.btnPesquisar.UseVisualStyleBackColor = true;
         this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(24, 93);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(147, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Digite o que está procurando:";
         // 
         // codigo
         // 
         this.codigo.DataPropertyName = "codigo";
         this.codigo.HeaderText = "codigo";
         this.codigo.Name = "codigo";
         this.codigo.ReadOnly = true;
         this.codigo.Visible = false;
         // 
         // grupo
         // 
         this.grupo.DataPropertyName = "grupo";
         this.grupo.HeaderText = "grupo";
         this.grupo.Name = "grupo";
         this.grupo.ReadOnly = true;
         // 
         // descricao
         // 
         this.descricao.DataPropertyName = "descricao";
         this.descricao.HeaderText = "descricao";
         this.descricao.Name = "descricao";
         this.descricao.ReadOnly = true;
         // 
         // proteina
         // 
         this.proteina.DataPropertyName = "proteina";
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.Format = "N2";
         dataGridViewCellStyle1.NullValue = "0";
         this.proteina.DefaultCellStyle = dataGridViewCellStyle1;
         this.proteina.HeaderText = "proteina";
         this.proteina.Name = "proteina";
         this.proteina.ReadOnly = true;
         // 
         // lipidio
         // 
         this.lipidio.DataPropertyName = "lipidio";
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.Format = "N2";
         dataGridViewCellStyle2.NullValue = "0";
         this.lipidio.DefaultCellStyle = dataGridViewCellStyle2;
         this.lipidio.HeaderText = "lipidio";
         this.lipidio.Name = "lipidio";
         this.lipidio.ReadOnly = true;
         // 
         // carboidrato
         // 
         this.carboidrato.DataPropertyName = "carboidrato";
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle3.Format = "N2";
         dataGridViewCellStyle3.NullValue = "0";
         this.carboidrato.DefaultCellStyle = dataGridViewCellStyle3;
         this.carboidrato.HeaderText = "carboidrato";
         this.carboidrato.Name = "carboidrato";
         this.carboidrato.ReadOnly = true;
         // 
         // fibra
         // 
         this.fibra.DataPropertyName = "fibra";
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle4.Format = "N2";
         dataGridViewCellStyle4.NullValue = "0";
         this.fibra.DefaultCellStyle = dataGridViewCellStyle4;
         this.fibra.HeaderText = "fibra";
         this.fibra.Name = "fibra";
         this.fibra.ReadOnly = true;
         // 
         // sodio
         // 
         this.sodio.DataPropertyName = "sodio";
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle5.Format = "N2";
         dataGridViewCellStyle5.NullValue = "0";
         this.sodio.DefaultCellStyle = dataGridViewCellStyle5;
         this.sodio.HeaderText = "sodio";
         this.sodio.Name = "sodio";
         this.sodio.ReadOnly = true;
         // 
         // gordura
         // 
         this.gordura.DataPropertyName = "gordura";
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle6.Format = "N2";
         dataGridViewCellStyle6.NullValue = "0";
         this.gordura.DefaultCellStyle = dataGridViewCellStyle6;
         this.gordura.HeaderText = "gordura";
         this.gordura.Name = "gordura";
         this.gordura.ReadOnly = true;
         // 
         // frmPesquisar
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(621, 450);
         this.Controls.Add(this.btnPesquisar);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cbxTipoFiltro);
         this.Controls.Add(this.txtFiltro);
         this.Controls.Add(this.dgvResultado);
         this.Name = "frmPesquisar";
         this.Text = "Pesquisar";
         ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cbxTipoFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteina;
        private System.Windows.Forms.DataGridViewTextBoxColumn lipidio;
        private System.Windows.Forms.DataGridViewTextBoxColumn carboidrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn fibra;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodio;
        private System.Windows.Forms.DataGridViewTextBoxColumn gordura;
    }
}

