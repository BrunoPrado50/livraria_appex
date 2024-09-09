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
            this.lbl_emplyee_control = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_emplyee_control
            // 
            this.lbl_emplyee_control.AutoSize = true;
            this.lbl_emplyee_control.Location = new System.Drawing.Point(4, 4);
            this.lbl_emplyee_control.Name = "lbl_emplyee_control";
            this.lbl_emplyee_control.Size = new System.Drawing.Size(59, 13);
            this.lbl_emplyee_control.TabIndex = 0;
            this.lbl_emplyee_control.Text = "funcionario";
            // 
            // employeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.lbl_emplyee_control);
            this.Name = "employeeControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_emplyee_control;
    }
}
