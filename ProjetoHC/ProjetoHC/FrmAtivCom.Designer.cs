namespace ProjetoHC
{
    partial class FrmAtivCom
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
            this.cmbBoxGrupo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxModal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidAtiv = new System.Windows.Forms.TextBox();
            this.cmbBoxAluno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAtiv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAtivTempo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDocuVal = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvAtiv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtiv)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxGrupo
            // 
            this.cmbBoxGrupo.FormattingEnabled = true;
            this.cmbBoxGrupo.Location = new System.Drawing.Point(12, 75);
            this.cmbBoxGrupo.Name = "cmbBoxGrupo";
            this.cmbBoxGrupo.Size = new System.Drawing.Size(204, 21);
            this.cmbBoxGrupo.TabIndex = 0;
            this.cmbBoxGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbBoxGrupo_SelectedIndexChanged);
            this.cmbBoxGrupo.SelectedValueChanged += new System.EventHandler(this.cmbBoxGrupo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grupo";
            // 
            // cmbBoxModal
            // 
            this.cmbBoxModal.FormattingEnabled = true;
            this.cmbBoxModal.Location = new System.Drawing.Point(12, 120);
            this.cmbBoxModal.Name = "cmbBoxModal";
            this.cmbBoxModal.Size = new System.Drawing.Size(204, 21);
            this.cmbBoxModal.TabIndex = 2;
            this.cmbBoxModal.SelectedIndexChanged += new System.EventHandler(this.cmbBoxModal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modalidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resgistro da Atividade";
            // 
            // txtidAtiv
            // 
            this.txtidAtiv.Location = new System.Drawing.Point(15, 30);
            this.txtidAtiv.Name = "txtidAtiv";
            this.txtidAtiv.ReadOnly = true;
            this.txtidAtiv.Size = new System.Drawing.Size(201, 20);
            this.txtidAtiv.TabIndex = 5;
            // 
            // cmbBoxAluno
            // 
            this.cmbBoxAluno.FormattingEnabled = true;
            this.cmbBoxAluno.Location = new System.Drawing.Point(227, 28);
            this.cmbBoxAluno.Name = "cmbBoxAluno";
            this.cmbBoxAluno.Size = new System.Drawing.Size(129, 21);
            this.cmbBoxAluno.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome do Aluno";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(227, 75);
            this.txtMat.Name = "txtMat";
            this.txtMat.ReadOnly = true;
            this.txtMat.Size = new System.Drawing.Size(129, 20);
            this.txtMat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Matrícula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Atividade Realizada";
            // 
            // txtAtiv
            // 
            this.txtAtiv.Location = new System.Drawing.Point(378, 28);
            this.txtAtiv.Name = "txtAtiv";
            this.txtAtiv.Size = new System.Drawing.Size(253, 20);
            this.txtAtiv.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Local de Realização";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(378, 74);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(253, 20);
            this.txtLocal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(646, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tempo total";
            // 
            // txtAtivTempo
            // 
            this.txtAtivTempo.Location = new System.Drawing.Point(649, 73);
            this.txtAtivTempo.Name = "txtAtivTempo";
            this.txtAtivTempo.Size = new System.Drawing.Size(129, 20);
            this.txtAtivTempo.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(649, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Documento de validação";
            // 
            // txtDocuVal
            // 
            this.txtDocuVal.Location = new System.Drawing.Point(649, 29);
            this.txtDocuVal.Name = "txtDocuVal";
            this.txtDocuVal.Size = new System.Drawing.Size(129, 20);
            this.txtDocuVal.TabIndex = 17;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(15, 161);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(105, 37);
            this.btnGravar.TabIndex = 18;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(171, 161);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 37);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(469, 161);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(312, 37);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "Retornar ao menu principal";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvAtiv
            // 
            this.dgvAtiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtiv.Location = new System.Drawing.Point(15, 204);
            this.dgvAtiv.Name = "dgvAtiv";
            this.dgvAtiv.Size = new System.Drawing.Size(766, 135);
            this.dgvAtiv.TabIndex = 22;
            // 
            // FrmAtivCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.dgvAtiv);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtDocuVal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAtivTempo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAtiv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBoxAluno);
            this.Controls.Add(this.txtidAtiv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxModal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxGrupo);
            this.Name = "FrmAtivCom";
            this.Text = "Cadastro de Atividades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxModal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidAtiv;
        private System.Windows.Forms.ComboBox cmbBoxAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAtiv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAtivTempo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDocuVal;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvAtiv;
    }
}