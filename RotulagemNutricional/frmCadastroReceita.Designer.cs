namespace View
{
   partial class frmCadastroReceita
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         this.panel3 = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.pnlReceita = new System.Windows.Forms.Panel();
         this.tabControlReceita = new System.Windows.Forms.TabControl();
         this.tbpReceita = new System.Windows.Forms.TabPage();
         this.btnExcluirAlimento = new System.Windows.Forms.PictureBox();
         this.btnNovoAlimento = new System.Windows.Forms.PictureBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.dgvAlimento = new System.Windows.Forms.DataGridView();
         this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.alimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.cbxUnidadeMedida = new System.Windows.Forms.ComboBox();
         this.txtPesoLiquido = new System.Windows.Forms.TextBox();
         this.txtPesoBruto = new System.Windows.Forms.TextBox();
         this.txtFatorCorrecao = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.tbpPreparo = new System.Windows.Forms.TabPage();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.tbpAlergenicos = new System.Windows.Forms.TabPage();
         this.label10 = new System.Windows.Forms.Label();
         this.btnSalvar = new System.Windows.Forms.Button();
         this.btnCancelar = new System.Windows.Forms.Button();
         this.panel2 = new System.Windows.Forms.Panel();
         this.label6 = new System.Windows.Forms.Label();
         this.txtNomeReceita = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.lblAtualizacao = new System.Windows.Forms.Label();
         this.pnlReceita.SuspendLayout();
         this.tabControlReceita.SuspendLayout();
         this.tbpReceita.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnExcluirAlimento)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnNovoAlimento)).BeginInit();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).BeginInit();
         this.tbpPreparo.SuspendLayout();
         this.tbpAlergenicos.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel3
         // 
         this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel3.BackColor = System.Drawing.Color.Gray;
         this.panel3.Location = new System.Drawing.Point(-2, 543);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(887, 18);
         this.panel3.TabIndex = 11;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(12, 8);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(130, 22);
         this.label2.TabIndex = 8;
         this.label2.Text = "CADASTRAR";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(8, 30);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(180, 44);
         this.label1.TabIndex = 9;
         this.label1.Text = "RECEITA";
         // 
         // pnlReceita
         // 
         this.pnlReceita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pnlReceita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pnlReceita.Controls.Add(this.tabControlReceita);
         this.pnlReceita.Location = new System.Drawing.Point(12, 149);
         this.pnlReceita.Name = "pnlReceita";
         this.pnlReceita.Size = new System.Drawing.Size(860, 388);
         this.pnlReceita.TabIndex = 7;
         // 
         // tabControlReceita
         // 
         this.tabControlReceita.Controls.Add(this.tbpReceita);
         this.tabControlReceita.Controls.Add(this.tbpPreparo);
         this.tabControlReceita.Controls.Add(this.tbpAlergenicos);
         this.tabControlReceita.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControlReceita.Font = new System.Drawing.Font("Arial", 12F);
         this.tabControlReceita.Location = new System.Drawing.Point(0, 0);
         this.tabControlReceita.Name = "tabControlReceita";
         this.tabControlReceita.SelectedIndex = 0;
         this.tabControlReceita.ShowToolTips = true;
         this.tabControlReceita.Size = new System.Drawing.Size(858, 386);
         this.tabControlReceita.TabIndex = 0;
         // 
         // tbpReceita
         // 
         this.tbpReceita.Controls.Add(this.btnExcluirAlimento);
         this.tbpReceita.Controls.Add(this.btnNovoAlimento);
         this.tbpReceita.Controls.Add(this.groupBox1);
         this.tbpReceita.Controls.Add(this.cbxUnidadeMedida);
         this.tbpReceita.Controls.Add(this.txtPesoLiquido);
         this.tbpReceita.Controls.Add(this.txtPesoBruto);
         this.tbpReceita.Controls.Add(this.txtFatorCorrecao);
         this.tbpReceita.Controls.Add(this.label3);
         this.tbpReceita.Controls.Add(this.label7);
         this.tbpReceita.Controls.Add(this.label5);
         this.tbpReceita.Controls.Add(this.label4);
         this.tbpReceita.ForeColor = System.Drawing.Color.Black;
         this.tbpReceita.Location = new System.Drawing.Point(4, 27);
         this.tbpReceita.Name = "tbpReceita";
         this.tbpReceita.Padding = new System.Windows.Forms.Padding(3);
         this.tbpReceita.Size = new System.Drawing.Size(850, 355);
         this.tbpReceita.TabIndex = 0;
         this.tbpReceita.Text = "Receita";
         this.tbpReceita.UseVisualStyleBackColor = true;
         // 
         // btnExcluirAlimento
         // 
         this.btnExcluirAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnExcluirAlimento.Image = global::View.Properties.Resources.quit;
         this.btnExcluirAlimento.Location = new System.Drawing.Point(777, 61);
         this.btnExcluirAlimento.Name = "btnExcluirAlimento";
         this.btnExcluirAlimento.Size = new System.Drawing.Size(32, 32);
         this.btnExcluirAlimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.btnExcluirAlimento.TabIndex = 35;
         this.btnExcluirAlimento.TabStop = false;
         // 
         // btnNovoAlimento
         // 
         this.btnNovoAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnNovoAlimento.Image = global::View.Properties.Resources.add;
         this.btnNovoAlimento.Location = new System.Drawing.Point(739, 61);
         this.btnNovoAlimento.Name = "btnNovoAlimento";
         this.btnNovoAlimento.Size = new System.Drawing.Size(32, 32);
         this.btnNovoAlimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.btnNovoAlimento.TabIndex = 34;
         this.btnNovoAlimento.TabStop = false;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.dgvAlimento);
         this.groupBox1.Location = new System.Drawing.Point(3, 86);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(841, 266);
         this.groupBox1.TabIndex = 33;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "INGREDIENTES DA RECEITA";
         // 
         // dgvAlimento
         // 
         this.dgvAlimento.AllowUserToAddRows = false;
         this.dgvAlimento.AllowUserToDeleteRows = false;
         this.dgvAlimento.AllowUserToResizeRows = false;
         this.dgvAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvAlimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dgvAlimento.ColumnHeadersHeight = 40;
         this.dgvAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dgvAlimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantidade,
            this.alimento});
         this.dgvAlimento.Location = new System.Drawing.Point(15, 26);
         this.dgvAlimento.Name = "dgvAlimento";
         this.dgvAlimento.ReadOnly = true;
         this.dgvAlimento.RowHeadersVisible = false;
         this.dgvAlimento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
         this.dgvAlimento.RowsDefaultCellStyle = dataGridViewCellStyle4;
         this.dgvAlimento.RowTemplate.ReadOnly = true;
         this.dgvAlimento.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvAlimento.Size = new System.Drawing.Size(808, 225);
         this.dgvAlimento.TabIndex = 33;
         // 
         // quantidade
         // 
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle2.Format = "N2";
         dataGridViewCellStyle2.NullValue = "0";
         this.quantidade.DefaultCellStyle = dataGridViewCellStyle2;
         this.quantidade.HeaderText = "QTD (g/ml)";
         this.quantidade.Name = "quantidade";
         this.quantidade.ReadOnly = true;
         this.quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.quantidade.ToolTipText = "Informe a Quantidade em gramas ou mililitros";
         // 
         // alimento
         // 
         this.alimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
         this.alimento.DefaultCellStyle = dataGridViewCellStyle3;
         this.alimento.HeaderText = "ALIMENTO";
         this.alimento.Name = "alimento";
         this.alimento.ReadOnly = true;
         this.alimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         // 
         // cbxUnidadeMedida
         // 
         this.cbxUnidadeMedida.DisplayMember = "Grama";
         this.cbxUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxUnidadeMedida.FormattingEnabled = true;
         this.cbxUnidadeMedida.Items.AddRange(new object[] {
            "Grama",
            "Mililitros"});
         this.cbxUnidadeMedida.Location = new System.Drawing.Point(28, 33);
         this.cbxUnidadeMedida.Name = "cbxUnidadeMedida";
         this.cbxUnidadeMedida.Size = new System.Drawing.Size(141, 26);
         this.cbxUnidadeMedida.TabIndex = 16;
         // 
         // txtPesoLiquido
         // 
         this.txtPesoLiquido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPesoLiquido.Location = new System.Drawing.Point(532, 33);
         this.txtPesoLiquido.Name = "txtPesoLiquido";
         this.txtPesoLiquido.ReadOnly = true;
         this.txtPesoLiquido.Size = new System.Drawing.Size(141, 26);
         this.txtPesoLiquido.TabIndex = 14;
         // 
         // txtPesoBruto
         // 
         this.txtPesoBruto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPesoBruto.Location = new System.Drawing.Point(196, 33);
         this.txtPesoBruto.Name = "txtPesoBruto";
         this.txtPesoBruto.ReadOnly = true;
         this.txtPesoBruto.Size = new System.Drawing.Size(141, 26);
         this.txtPesoBruto.TabIndex = 14;
         // 
         // txtFatorCorrecao
         // 
         this.txtFatorCorrecao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtFatorCorrecao.Location = new System.Drawing.Point(364, 33);
         this.txtFatorCorrecao.Name = "txtFatorCorrecao";
         this.txtFatorCorrecao.Size = new System.Drawing.Size(141, 26);
         this.txtFatorCorrecao.TabIndex = 14;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(28, 12);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(129, 18);
         this.label3.TabIndex = 15;
         this.label3.Text = "Unid de Medida*:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(532, 12);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(127, 18);
         this.label7.TabIndex = 15;
         this.label7.Text = "Peso Líquido (g):";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(364, 12);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(141, 18);
         this.label5.TabIndex = 15;
         this.label5.Text = "Fator de Correção:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(196, 12);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(113, 18);
         this.label4.TabIndex = 15;
         this.label4.Text = "Peso Bruto (g):";
         // 
         // tbpPreparo
         // 
         this.tbpPreparo.Controls.Add(this.richTextBox1);
         this.tbpPreparo.Location = new System.Drawing.Point(4, 27);
         this.tbpPreparo.Name = "tbpPreparo";
         this.tbpPreparo.Padding = new System.Windows.Forms.Padding(3);
         this.tbpPreparo.Size = new System.Drawing.Size(850, 342);
         this.tbpPreparo.TabIndex = 1;
         this.tbpPreparo.Text = "Modo de Preparo";
         this.tbpPreparo.UseVisualStyleBackColor = true;
         // 
         // richTextBox1
         // 
         this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.richTextBox1.Location = new System.Drawing.Point(18, 12);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.Size = new System.Drawing.Size(813, 306);
         this.richTextBox1.TabIndex = 0;
         this.richTextBox1.Text = "";
         // 
         // tbpAlergenicos
         // 
         this.tbpAlergenicos.Controls.Add(this.label10);
         this.tbpAlergenicos.Location = new System.Drawing.Point(4, 27);
         this.tbpAlergenicos.Name = "tbpAlergenicos";
         this.tbpAlergenicos.Size = new System.Drawing.Size(850, 342);
         this.tbpAlergenicos.TabIndex = 2;
         this.tbpAlergenicos.Text = "Alergênicos";
         this.tbpAlergenicos.UseVisualStyleBackColor = true;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label10.Location = new System.Drawing.Point(13, 10);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(12, 18);
         this.label10.TabIndex = 15;
         this.label10.Text = ".";
         // 
         // btnSalvar
         // 
         this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSalvar.Location = new System.Drawing.Point(656, 101);
         this.btnSalvar.Name = "btnSalvar";
         this.btnSalvar.Size = new System.Drawing.Size(95, 37);
         this.btnSalvar.TabIndex = 35;
         this.btnSalvar.Text = "Salvar";
         this.btnSalvar.UseVisualStyleBackColor = true;
         // 
         // btnCancelar
         // 
         this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnCancelar.Location = new System.Drawing.Point(776, 101);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(95, 37);
         this.btnCancelar.TabIndex = 34;
         this.btnCancelar.Text = "Voltar";
         this.btnCancelar.UseVisualStyleBackColor = true;
         // 
         // panel2
         // 
         this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel2.BackColor = System.Drawing.Color.Gray;
         this.panel2.Location = new System.Drawing.Point(194, 51);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(691, 15);
         this.panel2.TabIndex = 10;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(59, 91);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(140, 18);
         this.label6.TabIndex = 15;
         this.label6.Text = "Nome da Receita*:";
         // 
         // txtNomeReceita
         // 
         this.txtNomeReceita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtNomeReceita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtNomeReceita.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNomeReceita.Location = new System.Drawing.Point(62, 112);
         this.txtNomeReceita.Name = "txtNomeReceita";
         this.txtNomeReceita.Size = new System.Drawing.Size(336, 26);
         this.txtNomeReceita.TabIndex = 14;
         // 
         // label8
         // 
         this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(433, 87);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(140, 18);
         this.label8.TabIndex = 36;
         this.label8.Text = "Ultima Atualização:";
         // 
         // lblAtualizacao
         // 
         this.lblAtualizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.lblAtualizacao.AutoSize = true;
         this.lblAtualizacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblAtualizacao.Location = new System.Drawing.Point(437, 120);
         this.lblAtualizacao.Name = "lblAtualizacao";
         this.lblAtualizacao.Size = new System.Drawing.Size(132, 18);
         this.lblAtualizacao.TabIndex = 36;
         this.lblAtualizacao.Text = "12/02/2020 17:03";
         // 
         // frmCadastroReceita
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(884, 561);
         this.Controls.Add(this.lblAtualizacao);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.btnSalvar);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtNomeReceita);
         this.Controls.Add(this.pnlReceita);
         this.Controls.Add(this.label6);
         this.ForeColor = System.Drawing.SystemColors.ControlText;
         this.MinimumSize = new System.Drawing.Size(900, 600);
         this.Name = "frmCadastroReceita";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Minhas Receitas";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.pnlReceita.ResumeLayout(false);
         this.tabControlReceita.ResumeLayout(false);
         this.tbpReceita.ResumeLayout(false);
         this.tbpReceita.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnExcluirAlimento)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnNovoAlimento)).EndInit();
         this.groupBox1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).EndInit();
         this.tbpPreparo.ResumeLayout(false);
         this.tbpAlergenicos.ResumeLayout(false);
         this.tbpAlergenicos.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel pnlReceita;
      private System.Windows.Forms.TabControl tabControlReceita;
      private System.Windows.Forms.TabPage tbpReceita;
      private System.Windows.Forms.TabPage tbpPreparo;
      private System.Windows.Forms.TabPage tbpAlergenicos;
      private System.Windows.Forms.ComboBox cbxUnidadeMedida;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtPesoBruto;
      private System.Windows.Forms.TextBox txtFatorCorrecao;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtPesoLiquido;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.PictureBox btnExcluirAlimento;
      private System.Windows.Forms.PictureBox btnNovoAlimento;
      private System.Windows.Forms.DataGridView dgvAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimento;
      private System.Windows.Forms.Button btnSalvar;
      private System.Windows.Forms.Button btnCancelar;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox txtNomeReceita;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label lblAtualizacao;
      private System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.Label label10;
   }
}