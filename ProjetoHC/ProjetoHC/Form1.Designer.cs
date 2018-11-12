namespace ProjetoHC
{
    partial class FrmModalidade
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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtGvModalidade = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdModal = new System.Windows.Forms.TextBox();
            this.cmbBoxGrupo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxPont = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvModalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(12, 196);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(105, 37);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Gravar";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(147, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCls
            // 
            this.btnCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCls.Location = new System.Drawing.Point(287, 196);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(105, 37);
            this.btnCls.TabIndex = 3;
            this.btnCls.Text = "Cancelar";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.Lavender;
            this.btnReturnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnReturnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnReturnMenu.Location = new System.Drawing.Point(476, 196);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(312, 37);
            this.btnReturnMenu.TabIndex = 4;
            this.btnReturnMenu.Text = "Retornar ao menu principal";
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtMH
            // 
            this.txtMH.Location = new System.Drawing.Point(183, 72);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(327, 20);
            this.txtMH.TabIndex = 6;
            this.txtMH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMH_KeyPress);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(12, 115);
            this.txtDesc.MaximumSize = new System.Drawing.Size(780, 200);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(776, 75);
            this.txtDesc.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Carga Máxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Comprovantes Válidos";
            // 
            // dtGvModalidade
            // 
            this.dtGvModalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGvModalidade.Location = new System.Drawing.Point(12, 246);
            this.dtGvModalidade.Name = "dtGvModalidade";
            this.dtGvModalidade.Size = new System.Drawing.Size(776, 191);
            this.dtGvModalidade.TabIndex = 14;
            this.dtGvModalidade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGvModalidade_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Numero da Modalidade";
            // 
            // txtIdModal
            // 
            this.txtIdModal.Location = new System.Drawing.Point(18, 32);
            this.txtIdModal.Name = "txtIdModal";
            this.txtIdModal.ReadOnly = true;
            this.txtIdModal.Size = new System.Drawing.Size(156, 20);
            this.txtIdModal.TabIndex = 16;
            // 
            // cmbBoxGrupo
            // 
            this.cmbBoxGrupo.FormattingEnabled = true;
            this.cmbBoxGrupo.Location = new System.Drawing.Point(527, 71);
            this.cmbBoxGrupo.Name = "cmbBoxGrupo";
            this.cmbBoxGrupo.Size = new System.Drawing.Size(261, 21);
            this.cmbBoxGrupo.TabIndex = 17;
            this.cmbBoxGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbBoxGrupo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Grupo";
            // 
            // cmbBoxPont
            // 
            this.cmbBoxPont.FormattingEnabled = true;
            this.cmbBoxPont.Items.AddRange(new object[] {
            "CH da Discliplina",
            "CH Certificada",
            "20h por semestre",
            "20h por texto"});
            this.cmbBoxPont.Location = new System.Drawing.Point(530, 28);
            this.cmbBoxPont.Name = "cmbBoxPont";
            this.cmbBoxPont.Size = new System.Drawing.Size(258, 21);
            this.cmbBoxPont.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(527, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Pontuação Específica";
            // 
            // FrmModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBoxPont);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBoxGrupo);
            this.Controls.Add(this.txtIdModal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtGvModalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtMH);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.BtnCreate);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "FrmModalidade";
            this.Text = "Inclusão de Modalidades";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dtGvModalidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtGvModalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdModal;
        private System.Windows.Forms.ComboBox cmbBoxGrupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxPont;
        private System.Windows.Forms.Label label6;
    }
}

