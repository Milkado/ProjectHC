namespace ProjetoHC
{
    partial class GrupoControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelGravar = new System.Windows.Forms.Panel();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.panelExcluir = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.panelCancel = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.tableTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelNumero = new System.Windows.Forms.Panel();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNome = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panelCarga = new System.Windows.Forms.Panel();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelGravar.SuspendLayout();
            this.panelExcluir.SuspendLayout();
            this.panelCancel.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.tableTop.SuspendLayout();
            this.panelNumero.SuspendLayout();
            this.panelNome.SuspendLayout();
            this.panelCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panelBottom);
            this.panel1.Controls.Add(this.tableTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 388);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelCentral);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(463, 70);
            this.panel6.TabIndex = 3;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.tableLayoutPanel1);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(463, 70);
            this.panelCentral.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.50498F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.49502F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.Controls.Add(this.panelGravar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelExcluir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.51381F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelGravar
            // 
            this.panelGravar.Controls.Add(this.btn_gravar);
            this.panelGravar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGravar.Location = new System.Drawing.Point(3, 3);
            this.panelGravar.Name = "panelGravar";
            this.panelGravar.Size = new System.Drawing.Size(139, 64);
            this.panelGravar.TabIndex = 0;
            // 
            // btn_gravar
            // 
            this.btn_gravar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_gravar.FlatAppearance.BorderSize = 0;
            this.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Image = global::ProjetoHC.GlobalImages.button_gravar;
            this.btn_gravar.Location = new System.Drawing.Point(6, 12);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(105, 37);
            this.btn_gravar.TabIndex = 4;
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // panelExcluir
            // 
            this.panelExcluir.Controls.Add(this.btn_excluir);
            this.panelExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExcluir.Location = new System.Drawing.Point(148, 3);
            this.panelExcluir.Name = "panelExcluir";
            this.panelExcluir.Size = new System.Drawing.Size(149, 64);
            this.panelExcluir.TabIndex = 1;
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_excluir.Image = global::ProjetoHC.GlobalImages.button_excluir2;
            this.btn_excluir.Location = new System.Drawing.Point(19, 12);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(105, 37);
            this.btn_excluir.TabIndex = 6;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // panelCancel
            // 
            this.panelCancel.Controls.Add(this.btn_cancel);
            this.panelCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCancel.Location = new System.Drawing.Point(303, 3);
            this.panelCancel.Name = "panelCancel";
            this.panelCancel.Size = new System.Drawing.Size(157, 64);
            this.panelCancel.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_cancel.Image = global::ProjetoHC.GlobalImages.button_cancelar;
            this.btn_cancel.Location = new System.Drawing.Point(20, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 37);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.dgvGrupos);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 220);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(463, 168);
            this.panelBottom.TabIndex = 2;
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(0, 0);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(463, 168);
            this.dgvGrupos.TabIndex = 11;
            this.dgvGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellClick);
            // 
            // tableTop
            // 
            this.tableTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.tableTop.ColumnCount = 2;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.15767F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.84233F));
            this.tableTop.Controls.Add(this.panelNumero, 0, 0);
            this.tableTop.Controls.Add(this.panelNome, 1, 0);
            this.tableTop.Controls.Add(this.panelCarga, 0, 1);
            this.tableTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableTop.Location = new System.Drawing.Point(0, 0);
            this.tableTop.Name = "tableTop";
            this.tableTop.RowCount = 2;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.76033F));
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.23967F));
            this.tableTop.Size = new System.Drawing.Size(463, 150);
            this.tableTop.TabIndex = 1;
            // 
            // panelNumero
            // 
            this.panelNumero.Controls.Add(this.txtIdGrupo);
            this.panelNumero.Controls.Add(this.label1);
            this.panelNumero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNumero.Location = new System.Drawing.Point(3, 3);
            this.panelNumero.Name = "panelNumero";
            this.panelNumero.Size = new System.Drawing.Size(129, 67);
            this.panelNumero.TabIndex = 0;
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(3, 16);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.ReadOnly = true;
            this.txtIdGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtIdGrupo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número do Grupo";
            // 
            // panelNome
            // 
            this.panelNome.Controls.Add(this.label3);
            this.panelNome.Controls.Add(this.txtNome);
            this.panelNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNome.Location = new System.Drawing.Point(138, 3);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(322, 67);
            this.panelNome.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome do Grupo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(3, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 11;
            // 
            // panelCarga
            // 
            this.panelCarga.Controls.Add(this.txtCarga);
            this.panelCarga.Controls.Add(this.label2);
            this.panelCarga.Location = new System.Drawing.Point(3, 76);
            this.panelCarga.Name = "panelCarga";
            this.panelCarga.Size = new System.Drawing.Size(128, 71);
            this.panelCarga.TabIndex = 13;
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(3, 19);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(100, 20);
            this.txtCarga.TabIndex = 10;
            this.txtCarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarga_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Carga Máxima";
            // 
            // GrupoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "GrupoControl";
            this.Size = new System.Drawing.Size(463, 388);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelGravar.ResumeLayout(false);
            this.panelExcluir.ResumeLayout(false);
            this.panelCancel.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.tableTop.ResumeLayout(false);
            this.panelNumero.ResumeLayout(false);
            this.panelNumero.PerformLayout();
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.panelCarga.ResumeLayout(false);
            this.panelCarga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableTop;
        private System.Windows.Forms.Panel panelNumero;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Panel panelCarga;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelGravar;
        private System.Windows.Forms.Panel panelExcluir;
        private System.Windows.Forms.Panel panelCancel;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancel;
    }
}
