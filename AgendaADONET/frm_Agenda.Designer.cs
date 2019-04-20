namespace AgendaADONET
{
    partial class frm_Agenda
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgb_Agenda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgb_Agenda
            // 
            this.dgb_Agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Agenda.Location = new System.Drawing.Point(12, 12);
            this.dgb_Agenda.Name = "dgb_Agenda";
            this.dgb_Agenda.Size = new System.Drawing.Size(510, 259);
            this.dgb_Agenda.TabIndex = 0;
            // 
            // frm_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 354);
            this.Controls.Add(this.dgb_Agenda);
            this.Name = "frm_Agenda";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Agenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgb_Agenda;
    }
}

