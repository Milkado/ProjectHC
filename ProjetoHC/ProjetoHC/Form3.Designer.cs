namespace ProjetoHC
{
    partial class FrmMenu
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
            this.btnTelaModal = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnTelaGrupo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTelaModal
            // 
            this.btnTelaModal.Location = new System.Drawing.Point(12, 57);
            this.btnTelaModal.Name = "btnTelaModal";
            this.btnTelaModal.Size = new System.Drawing.Size(192, 51);
            this.btnTelaModal.TabIndex = 0;
            this.btnTelaModal.Text = "Incluir Modalidade";
            this.btnTelaModal.UseVisualStyleBackColor = true;
            this.btnTelaModal.Click += new System.EventHandler(this.btnTelaModal_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(12, 171);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(192, 51);
            this.btnAC.TabIndex = 1;
            this.btnAC.Text = "Cadastrar Atividade";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnTelaGrupo
            // 
            this.btnTelaGrupo.Location = new System.Drawing.Point(12, 114);
            this.btnTelaGrupo.Name = "btnTelaGrupo";
            this.btnTelaGrupo.Size = new System.Drawing.Size(192, 51);
            this.btnTelaGrupo.TabIndex = 3;
            this.btnTelaGrupo.Text = "Inlcuir Grupo";
            this.btnTelaGrupo.UseVisualStyleBackColor = true;
            this.btnTelaGrupo.Click += new System.EventHandler(this.btnTelaGrupo_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(596, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 228);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 51);
            this.button7.TabIndex = 6;
            this.button7.Text = "Relatórios";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cadastro de Usuário";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnTelaGrupo);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnTelaModal);
            this.Name = "FrmMenu";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTelaModal;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnTelaGrupo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}