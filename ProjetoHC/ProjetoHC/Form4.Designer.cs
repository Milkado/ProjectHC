namespace ProjetoHC
{
    partial class FrmGrupo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número do Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(469, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carga Máxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(163, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Grupo";
            // 
            // btn_gravar
            // 
            this.btn_gravar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_gravar.FlatAppearance.BorderSize = 0;
            this.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Image = global::ProjetoHC.GlobalImages.button_gravar;
            this.btn_gravar.Location = new System.Drawing.Point(7, 87);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(105, 37);
            this.btn_gravar.TabIndex = 3;
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancel.FlatAppearance.BorderSize = 2;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_cancel.Image = global::ProjetoHC.GlobalImages.button_cancelar;
            this.btn_cancel.Location = new System.Drawing.Point(301, 87);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 37);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_excluir.FlatAppearance.BorderSize = 2;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_excluir.Image = global::ProjetoHC.GlobalImages.button_excluir2;
            this.btn_excluir.Location = new System.Drawing.Point(140, 86);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(105, 37);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button4.Location = new System.Drawing.Point(424, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(312, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Retornar ao Menu Principal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(12, 25);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.ReadOnly = true;
            this.txtIdGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtIdGrupo.TabIndex = 7;
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(472, 25);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(100, 20);
            this.txtCarga.TabIndex = 8;
            this.txtCarga.TextChanged += new System.EventHandler(this.txtCarga_TextChanged);
            this.txtCarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarga_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(166, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 9;
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(7, 130);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(729, 144);
            this.dgvGrupos.TabIndex = 10;
            this.dgvGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellClick);
            // 
            // FrmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 281);
            this.Controls.Add(this.dgvGrupos);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.txtIdGrupo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGrupo";
            this.Text = "Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvGrupos;
    }
}