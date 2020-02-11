namespace View
{
   partial class frmReceita
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnExcluirAlimento = new System.Windows.Forms.PictureBox();
         this.btnNovoAlimento = new System.Windows.Forms.PictureBox();
         this.label7 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.txtPesoFinal = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.txtPerda = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtPesoBruto = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.cbxUnidade = new System.Windows.Forms.ComboBox();
         this.txtNome = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.dgvAlimento = new System.Windows.Forms.DataGridView();
         this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.alimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.btnCancelar = new System.Windows.Forms.Button();
         this.btnSalvar = new System.Windows.Forms.Button();
         this.txtModoPreparo = new System.Windows.Forms.RichTextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnExcluirAlimento)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnNovoAlimento)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel1.Controls.Add(this.txtModoPreparo);
         this.panel1.Controls.Add(this.btnExcluirAlimento);
         this.panel1.Controls.Add(this.btnNovoAlimento);
         this.panel1.Controls.Add(this.label7);
         this.panel1.Controls.Add(this.label10);
         this.panel1.Controls.Add(this.label8);
         this.panel1.Controls.Add(this.txtPesoFinal);
         this.panel1.Controls.Add(this.label9);
         this.panel1.Controls.Add(this.txtPerda);
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.txtPesoBruto);
         this.panel1.Controls.Add(this.label4);
         this.panel1.Controls.Add(this.label6);
         this.panel1.Controls.Add(this.cbxUnidade);
         this.panel1.Controls.Add(this.txtNome);
         this.panel1.Controls.Add(this.label5);
         this.panel1.Controls.Add(this.dgvAlimento);
         this.panel1.Location = new System.Drawing.Point(12, 85);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(595, 543);
         this.panel1.TabIndex = 1;
         // 
         // btnExcluirAlimento
         // 
         this.btnExcluirAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnExcluirAlimento.Image = global::View.Properties.Resources.cross;
         this.btnExcluirAlimento.Location = new System.Drawing.Point(563, 67);
         this.btnExcluirAlimento.Name = "btnExcluirAlimento";
         this.btnExcluirAlimento.Size = new System.Drawing.Size(16, 16);
         this.btnExcluirAlimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.btnExcluirAlimento.TabIndex = 29;
         this.btnExcluirAlimento.TabStop = false;
         // 
         // btnNovoAlimento
         // 
         this.btnNovoAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnNovoAlimento.Image = global::View.Properties.Resources.add;
         this.btnNovoAlimento.Location = new System.Drawing.Point(541, 67);
         this.btnNovoAlimento.Name = "btnNovoAlimento";
         this.btnNovoAlimento.Size = new System.Drawing.Size(16, 16);
         this.btnNovoAlimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.btnNovoAlimento.TabIndex = 29;
         this.btnNovoAlimento.TabStop = false;
         // 
         // label7
         // 
         this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(487, 7);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(71, 18);
         this.label7.TabIndex = 28;
         this.label7.Text = "Unidade:";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label10.Location = new System.Drawing.Point(542, 373);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(37, 18);
         this.label10.TabIndex = 16;
         this.label10.Text = "g/ml";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(122, 373);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(37, 18);
         this.label8.TabIndex = 16;
         this.label8.Text = "g/ml";
         // 
         // txtPesoFinal
         // 
         this.txtPesoFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPesoFinal.Location = new System.Drawing.Point(433, 365);
         this.txtPesoFinal.Name = "txtPesoFinal";
         this.txtPesoFinal.ReadOnly = true;
         this.txtPesoFinal.Size = new System.Drawing.Size(103, 26);
         this.txtPesoFinal.TabIndex = 14;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.Location = new System.Drawing.Point(429, 344);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(87, 18);
         this.label9.TabIndex = 15;
         this.label9.Text = "Peso Final:";
         // 
         // txtPerda
         // 
         this.txtPerda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPerda.Location = new System.Drawing.Point(232, 365);
         this.txtPerda.Name = "txtPerda";
         this.txtPerda.Size = new System.Drawing.Size(103, 26);
         this.txtPerda.TabIndex = 14;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(228, 344);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(73, 18);
         this.label3.TabIndex = 15;
         this.label3.Text = "% Perda:";
         // 
         // txtPesoBruto
         // 
         this.txtPesoBruto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPesoBruto.Location = new System.Drawing.Point(13, 365);
         this.txtPesoBruto.Name = "txtPesoBruto";
         this.txtPesoBruto.ReadOnly = true;
         this.txtPesoBruto.Size = new System.Drawing.Size(103, 26);
         this.txtPesoBruto.TabIndex = 14;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(9, 344);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(90, 18);
         this.label6.TabIndex = 15;
         this.label6.Text = "Peso Bruto:";
         // 
         // cbxUnidade
         // 
         this.cbxUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.cbxUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxUnidade.Font = new System.Drawing.Font("Arial", 11F);
         this.cbxUnidade.FormattingEnabled = true;
         this.cbxUnidade.Location = new System.Drawing.Point(490, 29);
         this.cbxUnidade.Name = "cbxUnidade";
         this.cbxUnidade.Size = new System.Drawing.Size(89, 25);
         this.cbxUnidade.TabIndex = 11;
         // 
         // txtNome
         // 
         this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNome.Location = new System.Drawing.Point(13, 28);
         this.txtNome.Name = "txtNome";
         this.txtNome.Size = new System.Drawing.Size(455, 26);
         this.txtNome.TabIndex = 8;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(10, 7);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(54, 18);
         this.label5.TabIndex = 9;
         this.label5.Text = "Nome:";
         // 
         // dgvAlimento
         // 
         this.dgvAlimento.AllowUserToAddRows = false;
         this.dgvAlimento.AllowUserToDeleteRows = false;
         this.dgvAlimento.AllowUserToResizeRows = false;
         this.dgvAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvAlimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
         this.dgvAlimento.ColumnHeadersHeight = 40;
         this.dgvAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dgvAlimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.alimento,
            this.quantidade});
         dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 12F);
         dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvAlimento.DefaultCellStyle = dataGridViewCellStyle14;
         this.dgvAlimento.Location = new System.Drawing.Point(13, 89);
         this.dgvAlimento.Name = "dgvAlimento";
         this.dgvAlimento.ReadOnly = true;
         dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 12F);
         dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvAlimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
         this.dgvAlimento.RowHeadersVisible = false;
         this.dgvAlimento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 12F);
         this.dgvAlimento.RowsDefaultCellStyle = dataGridViewCellStyle16;
         this.dgvAlimento.RowTemplate.ReadOnly = true;
         this.dgvAlimento.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvAlimento.Size = new System.Drawing.Size(566, 239);
         this.dgvAlimento.TabIndex = 0;
         // 
         // codigo
         // 
         this.codigo.HeaderText = "codigo";
         this.codigo.Name = "codigo";
         this.codigo.ReadOnly = true;
         this.codigo.Visible = false;
         // 
         // alimento
         // 
         this.alimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.alimento.HeaderText = "ALIMENTO";
         this.alimento.Name = "alimento";
         this.alimento.ReadOnly = true;
         // 
         // quantidade
         // 
         this.quantidade.HeaderText = "QUANTIDADE";
         this.quantidade.Name = "quantidade";
         this.quantidade.ReadOnly = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(14, 38);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(180, 44);
         this.label1.TabIndex = 2;
         this.label1.Text = "RECEITA";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(18, 16);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(130, 22);
         this.label2.TabIndex = 2;
         this.label2.Text = "CADASTRAR";
         // 
         // panel2
         // 
         this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel2.BackColor = System.Drawing.Color.Gray;
         this.panel2.Location = new System.Drawing.Point(200, 59);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(421, 15);
         this.panel2.TabIndex = 3;
         // 
         // panel3
         // 
         this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel3.BackColor = System.Drawing.Color.Gray;
         this.panel3.Location = new System.Drawing.Point(-1, 634);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(620, 18);
         this.panel3.TabIndex = 4;
         // 
         // btnCancelar
         // 
         this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnCancelar.Location = new System.Drawing.Point(511, 16);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(95, 37);
         this.btnCancelar.TabIndex = 5;
         this.btnCancelar.Text = "Cancelar";
         this.btnCancelar.UseVisualStyleBackColor = true;
         // 
         // btnSalvar
         // 
         this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSalvar.Location = new System.Drawing.Point(410, 16);
         this.btnSalvar.Name = "btnSalvar";
         this.btnSalvar.Size = new System.Drawing.Size(95, 37);
         this.btnSalvar.TabIndex = 6;
         this.btnSalvar.Text = "Novo";
         this.btnSalvar.UseVisualStyleBackColor = true;
         // 
         // txtModoPreparo
         // 
         this.txtModoPreparo.Font = new System.Drawing.Font("Arial", 12F);
         this.txtModoPreparo.Location = new System.Drawing.Point(12, 437);
         this.txtModoPreparo.Name = "txtModoPreparo";
         this.txtModoPreparo.Size = new System.Drawing.Size(567, 96);
         this.txtModoPreparo.TabIndex = 30;
         this.txtModoPreparo.Text = "";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(10, 416);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(135, 18);
         this.label4.TabIndex = 15;
         this.label4.Text = "Modo de Preparo:";
         // 
         // frmReceita
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(619, 651);
         this.Controls.Add(this.btnSalvar);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.Name = "frmReceita";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Receitas";
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnExcluirAlimento)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnNovoAlimento)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesoBruto;
        private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.ComboBox cbxUnidade;
      private System.Windows.Forms.DataGridView dgvAlimento;
      private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
      private System.Windows.Forms.DataGridViewTextBoxColumn alimento;
      private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
      private System.Windows.Forms.PictureBox btnNovoAlimento;
      private System.Windows.Forms.PictureBox btnExcluirAlimento;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.TextBox txtPesoFinal;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox txtPerda;
      private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtModoPreparo;
        private System.Windows.Forms.Label label4;
    }
}