namespace ProjetoHC
{
    partial class UsuarioComtrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tableTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelID = new System.Windows.Forms.Panel();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSenha = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelConfirmar = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.panelGravar = new System.Windows.Forms.Panel();
            this.panelCancel = new System.Windows.Forms.Panel();
            this.panelExcluir = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.tableTop.SuspendLayout();
            this.panelID.SuspendLayout();
            this.panelSenha.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelConfirmar.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tableButton.SuspendLayout();
            this.panelGravar.SuspendLayout();
            this.panelCancel.SuspendLayout();
            this.panelExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.tableButton);
            this.panelContainer.Controls.Add(this.panelBottom);
            this.panelContainer.Controls.Add(this.tableTop);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(523, 416);
            this.panelContainer.TabIndex = 0;
            // 
            // tableTop
            // 
            this.tableTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.tableTop.ColumnCount = 2;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTop.Controls.Add(this.panelID, 0, 0);
            this.tableTop.Controls.Add(this.panelSenha, 0, 1);
            this.tableTop.Controls.Add(this.panelUser, 1, 0);
            this.tableTop.Controls.Add(this.panelConfirmar, 1, 1);
            this.tableTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableTop.Location = new System.Drawing.Point(0, 0);
            this.tableTop.Name = "tableTop";
            this.tableTop.RowCount = 2;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTop.Size = new System.Drawing.Size(523, 118);
            this.tableTop.TabIndex = 0;
            // 
            // panelID
            // 
            this.panelID.Controls.Add(this.txtIdUsuario);
            this.panelID.Controls.Add(this.label1);
            this.panelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelID.Location = new System.Drawing.Point(3, 3);
            this.panelID.Name = "panelID";
            this.panelID.Size = new System.Drawing.Size(255, 53);
            this.panelID.TabIndex = 0;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(6, 20);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIdUsuario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id do Usuário";
            // 
            // panelSenha
            // 
            this.panelSenha.Controls.Add(this.txtPassword);
            this.panelSenha.Controls.Add(this.label2);
            this.panelSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSenha.Location = new System.Drawing.Point(3, 62);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(255, 53);
            this.panelSenha.TabIndex = 1;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.txtUser);
            this.panelUser.Controls.Add(this.label3);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUser.Location = new System.Drawing.Point(264, 3);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(256, 53);
            this.panelUser.TabIndex = 2;
            // 
            // panelConfirmar
            // 
            this.panelConfirmar.Controls.Add(this.txtConfirm);
            this.panelConfirmar.Controls.Add(this.label4);
            this.panelConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfirmar.Location = new System.Drawing.Point(264, 62);
            this.panelConfirmar.Name = "panelConfirmar";
            this.panelConfirmar.Size = new System.Drawing.Size(256, 53);
            this.panelConfirmar.TabIndex = 3;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.dgvUser);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 285);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(523, 131);
            this.panelBottom.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(6, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(217, 20);
            this.txtUser.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuário";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 26);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(187, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(6, 26);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(217, 20);
            this.txtConfirm.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Confirmar Senha";
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(523, 131);
            this.dgvUser.TabIndex = 13;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // tableButton
            // 
            this.tableButton.ColumnCount = 3;
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableButton.Controls.Add(this.panelGravar, 0, 0);
            this.tableButton.Controls.Add(this.panelCancel, 1, 0);
            this.tableButton.Controls.Add(this.panelExcluir, 2, 0);
            this.tableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButton.Location = new System.Drawing.Point(0, 118);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButton.Size = new System.Drawing.Size(523, 167);
            this.tableButton.TabIndex = 2;
            // 
            // panelGravar
            // 
            this.panelGravar.Controls.Add(this.btnCadastrar);
            this.panelGravar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGravar.Location = new System.Drawing.Point(3, 3);
            this.panelGravar.Name = "panelGravar";
            this.panelGravar.Size = new System.Drawing.Size(162, 161);
            this.panelGravar.TabIndex = 0;
            // 
            // panelCancel
            // 
            this.panelCancel.Controls.Add(this.btnExcluir);
            this.panelCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCancel.Location = new System.Drawing.Point(171, 3);
            this.panelCancel.Name = "panelCancel";
            this.panelCancel.Size = new System.Drawing.Size(162, 161);
            this.panelCancel.TabIndex = 1;
            // 
            // panelExcluir
            // 
            this.panelExcluir.Controls.Add(this.btnCancel);
            this.panelExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExcluir.Location = new System.Drawing.Point(339, 3);
            this.panelExcluir.Name = "panelExcluir";
            this.panelExcluir.Size = new System.Drawing.Size(181, 161);
            this.panelExcluir.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCadastrar.Image = global::ProjetoHC.GlobalImages.button_gravar;
            this.btnCadastrar.Location = new System.Drawing.Point(27, 62);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 37);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCancel.Image = global::ProjetoHC.GlobalImages.button_cancelar;
            this.btnCancel.Location = new System.Drawing.Point(34, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnExcluir.Image = global::ProjetoHC.GlobalImages.button_excluir2;
            this.btnExcluir.Location = new System.Drawing.Point(25, 62);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 37);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // UsuarioComtrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Name = "UsuarioComtrol";
            this.Size = new System.Drawing.Size(523, 416);
            this.panelContainer.ResumeLayout(false);
            this.tableTop.ResumeLayout(false);
            this.panelID.ResumeLayout(false);
            this.panelID.PerformLayout();
            this.panelSenha.ResumeLayout(false);
            this.panelSenha.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelConfirmar.ResumeLayout(false);
            this.panelConfirmar.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tableButton.ResumeLayout(false);
            this.panelGravar.ResumeLayout(false);
            this.panelCancel.ResumeLayout(false);
            this.panelExcluir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TableLayoutPanel tableTop;
        private System.Windows.Forms.Panel panelID;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSenha;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelConfirmar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.Panel panelGravar;
        private System.Windows.Forms.Panel panelCancel;
        private System.Windows.Forms.Panel panelExcluir;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExcluir;
    }
}
