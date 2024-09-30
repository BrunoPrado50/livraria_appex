namespace livraria_appex
{
    partial class employeeControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_emplyee_control = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_nome_employe = new System.Windows.Forms.Label();
            this.lbl_login_employe = new System.Windows.Forms.Label();
            this.lbl_senha_employe = new System.Windows.Forms.Label();
            this.tbx_nome_employe = new System.Windows.Forms.TextBox();
            this.tbx_login_employe = new System.Windows.Forms.TextBox();
            this.tbx_senha_employe = new System.Windows.Forms.TextBox();
            this.dgv_tabela = new System.Windows.Forms.DataGridView();
            this.gbx_pesquisa = new System.Windows.Forms.GroupBox();
            this.lbl_pesquisaF = new System.Windows.Forms.Label();
            this.tbx_pesquisaF = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_cod_zu = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_status_employee = new System.Windows.Forms.Label();
            this.rbtn_ativo_employe = new System.Windows.Forms.RadioButton();
            this.rbtn_inativo_employe = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabela)).BeginInit();
            this.gbx_pesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_emplyee_control
            // 
            this.lbl_emplyee_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emplyee_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(110)))), ((int)(((byte)(68)))));
            this.lbl_emplyee_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emplyee_control.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.lbl_emplyee_control.Location = new System.Drawing.Point(257, 15);
            this.lbl_emplyee_control.Name = "lbl_emplyee_control";
            this.lbl_emplyee_control.Size = new System.Drawing.Size(169, 41);
            this.lbl_emplyee_control.TabIndex = 0;
            this.lbl_emplyee_control.Text = "funcionario";
            this.lbl_emplyee_control.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_emplyee_control.Click += new System.EventHandler(this.lbl_emplyee_control_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(110)))), ((int)(((byte)(68)))));
            this.lbl_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.lbl_codigo.Location = new System.Drawing.Point(28, 15);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(154, 32);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "Código: ";
            this.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nome_employe
            // 
            this.lbl_nome_employe.AutoSize = true;
            this.lbl_nome_employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(110)))), ((int)(((byte)(68)))));
            this.lbl_nome_employe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.lbl_nome_employe.Location = new System.Drawing.Point(43, 66);
            this.lbl_nome_employe.Name = "lbl_nome_employe";
            this.lbl_nome_employe.Size = new System.Drawing.Size(41, 13);
            this.lbl_nome_employe.TabIndex = 2;
            this.lbl_nome_employe.Text = "Nome :";
            // 
            // lbl_login_employe
            // 
            this.lbl_login_employe.AutoSize = true;
            this.lbl_login_employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(110)))), ((int)(((byte)(68)))));
            this.lbl_login_employe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.lbl_login_employe.Location = new System.Drawing.Point(43, 99);
            this.lbl_login_employe.Name = "lbl_login_employe";
            this.lbl_login_employe.Size = new System.Drawing.Size(39, 13);
            this.lbl_login_employe.TabIndex = 3;
            this.lbl_login_employe.Text = "Login :";
            // 
            // lbl_senha_employe
            // 
            this.lbl_senha_employe.AutoSize = true;
            this.lbl_senha_employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(110)))), ((int)(((byte)(68)))));
            this.lbl_senha_employe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.lbl_senha_employe.Location = new System.Drawing.Point(43, 133);
            this.lbl_senha_employe.Name = "lbl_senha_employe";
            this.lbl_senha_employe.Size = new System.Drawing.Size(44, 13);
            this.lbl_senha_employe.TabIndex = 4;
            this.lbl_senha_employe.Text = "Senha :";
            // 
            // tbx_nome_employe
            // 
            this.tbx_nome_employe.Location = new System.Drawing.Point(109, 63);
            this.tbx_nome_employe.Name = "tbx_nome_employe";
            this.tbx_nome_employe.Size = new System.Drawing.Size(100, 20);
            this.tbx_nome_employe.TabIndex = 5;
            this.tbx_nome_employe.TextChanged += new System.EventHandler(this.tbx_nome_employe_TextChanged);
            // 
            // tbx_login_employe
            // 
            this.tbx_login_employe.Location = new System.Drawing.Point(109, 96);
            this.tbx_login_employe.Name = "tbx_login_employe";
            this.tbx_login_employe.Size = new System.Drawing.Size(100, 20);
            this.tbx_login_employe.TabIndex = 6;
            // 
            // tbx_senha_employe
            // 
            this.tbx_senha_employe.Location = new System.Drawing.Point(109, 130);
            this.tbx_senha_employe.Name = "tbx_senha_employe";
            this.tbx_senha_employe.Size = new System.Drawing.Size(100, 20);
            this.tbx_senha_employe.TabIndex = 7;
            this.tbx_senha_employe.UseSystemPasswordChar = true;
            this.tbx_senha_employe.TextChanged += new System.EventHandler(this.tbx_senha_employe_TextChanged);
            // 
            // dgv_tabela
            // 
            this.dgv_tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabela.Location = new System.Drawing.Point(21, 325);
            this.dgv_tabela.Name = "dgv_tabela";
            this.dgv_tabela.Size = new System.Drawing.Size(330, 94);
            this.dgv_tabela.TabIndex = 8;
            this.dgv_tabela.DoubleClick += new System.EventHandler(this.dgv_tabela_DoubleClick);
            // 
            // gbx_pesquisa
            // 
            this.gbx_pesquisa.Controls.Add(this.lbl_pesquisaF);
            this.gbx_pesquisa.Controls.Add(this.tbx_pesquisaF);
            this.gbx_pesquisa.Location = new System.Drawing.Point(21, 252);
            this.gbx_pesquisa.Name = "gbx_pesquisa";
            this.gbx_pesquisa.Size = new System.Drawing.Size(330, 67);
            this.gbx_pesquisa.TabIndex = 9;
            this.gbx_pesquisa.TabStop = false;
            // 
            // lbl_pesquisaF
            // 
            this.lbl_pesquisaF.AutoSize = true;
            this.lbl_pesquisaF.Location = new System.Drawing.Point(7, 16);
            this.lbl_pesquisaF.Name = "lbl_pesquisaF";
            this.lbl_pesquisaF.Size = new System.Drawing.Size(126, 13);
            this.lbl_pesquisaF.TabIndex = 1;
            this.lbl_pesquisaF.Text = "Pesquisa por Funcionario";
            // 
            // tbx_pesquisaF
            // 
            this.tbx_pesquisaF.Location = new System.Drawing.Point(7, 35);
            this.tbx_pesquisaF.Name = "tbx_pesquisaF";
            this.tbx_pesquisaF.Size = new System.Drawing.Size(263, 20);
            this.tbx_pesquisaF.TabIndex = 0;
            this.tbx_pesquisaF.TextChanged += new System.EventHandler(this.tbx_pesquisaF_TextChanged);
            // 
            // btn_novo
            // 
            this.btn_novo.Image = global::livraria_appex.Properties.Resources._new;
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(436, 15);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(125, 76);
            this.btn_novo.TabIndex = 14;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Image = global::livraria_appex.Properties.Resources.save1;
            this.btn_gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gravar.Location = new System.Drawing.Point(436, 97);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(125, 76);
            this.btn_gravar.TabIndex = 13;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = global::livraria_appex.Properties.Resources.edit;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(436, 179);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(125, 76);
            this.btn_alterar.TabIndex = 12;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Image = global::livraria_appex.Properties.Resources.delete;
            this.btn_remover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remover.Location = new System.Drawing.Point(436, 261);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(125, 76);
            this.btn_remover.TabIndex = 11;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::livraria_appex.Properties.Resources.cancel;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(436, 343);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(125, 76);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_cod_zu
            // 
            this.lbl_cod_zu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(110)))), ((int)(((byte)(68)))));
            this.lbl_cod_zu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.lbl_cod_zu.Location = new System.Drawing.Point(124, 15);
            this.lbl_cod_zu.Name = "lbl_cod_zu";
            this.lbl_cod_zu.Size = new System.Drawing.Size(58, 32);
            this.lbl_cod_zu.TabIndex = 15;
            this.lbl_cod_zu.Text = "01";
            this.lbl_cod_zu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_status_employee
            // 
            this.lbl_status_employee.AutoSize = true;
            this.lbl_status_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(110)))), ((int)(((byte)(68)))));
            this.lbl_status_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.lbl_status_employee.Location = new System.Drawing.Point(43, 160);
            this.lbl_status_employee.Name = "lbl_status_employee";
            this.lbl_status_employee.Size = new System.Drawing.Size(35, 13);
            this.lbl_status_employee.TabIndex = 16;
            this.lbl_status_employee.Text = "status";
            // 
            // rbtn_ativo_employe
            // 
            this.rbtn_ativo_employe.AutoSize = true;
            this.rbtn_ativo_employe.Checked = true;
            this.rbtn_ativo_employe.Location = new System.Drawing.Point(109, 160);
            this.rbtn_ativo_employe.Name = "rbtn_ativo_employe";
            this.rbtn_ativo_employe.Size = new System.Drawing.Size(49, 17);
            this.rbtn_ativo_employe.TabIndex = 17;
            this.rbtn_ativo_employe.TabStop = true;
            this.rbtn_ativo_employe.Text = "Ativo";
            this.rbtn_ativo_employe.UseVisualStyleBackColor = true;
            // 
            // rbtn_inativo_employe
            // 
            this.rbtn_inativo_employe.AutoSize = true;
            this.rbtn_inativo_employe.Location = new System.Drawing.Point(181, 160);
            this.rbtn_inativo_employe.Name = "rbtn_inativo_employe";
            this.rbtn_inativo_employe.Size = new System.Drawing.Size(57, 17);
            this.rbtn_inativo_employe.TabIndex = 18;
            this.rbtn_inativo_employe.Text = "Inativo";
            this.rbtn_inativo_employe.UseVisualStyleBackColor = true;
            // 
            // employeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.rbtn_inativo_employe);
            this.Controls.Add(this.rbtn_ativo_employe);
            this.Controls.Add(this.lbl_status_employee);
            this.Controls.Add(this.lbl_cod_zu);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gbx_pesquisa);
            this.Controls.Add(this.dgv_tabela);
            this.Controls.Add(this.tbx_senha_employe);
            this.Controls.Add(this.tbx_login_employe);
            this.Controls.Add(this.tbx_nome_employe);
            this.Controls.Add(this.lbl_senha_employe);
            this.Controls.Add(this.lbl_login_employe);
            this.Controls.Add(this.lbl_nome_employe);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_emplyee_control);
            this.Name = "employeeControl";
            this.Size = new System.Drawing.Size(563, 447);
            this.Load += new System.EventHandler(this.employeeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabela)).EndInit();
            this.gbx_pesquisa.ResumeLayout(false);
            this.gbx_pesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_emplyee_control;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_nome_employe;
        private System.Windows.Forms.Label lbl_login_employe;
        private System.Windows.Forms.Label lbl_senha_employe;
        private System.Windows.Forms.TextBox tbx_nome_employe;
        private System.Windows.Forms.TextBox tbx_login_employe;
        private System.Windows.Forms.TextBox tbx_senha_employe;
        private System.Windows.Forms.DataGridView dgv_tabela;
        private System.Windows.Forms.GroupBox gbx_pesquisa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label lbl_cod_zu;
        private System.Windows.Forms.Label lbl_pesquisaF;
        private System.Windows.Forms.TextBox tbx_pesquisaF;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_status_employee;
        private System.Windows.Forms.RadioButton rbtn_ativo_employe;
        private System.Windows.Forms.RadioButton rbtn_inativo_employe;
    }
}
