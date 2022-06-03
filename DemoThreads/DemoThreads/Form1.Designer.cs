namespace DemoThreads
{
    partial class Frm_DemoThread
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pgbThreads = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(133, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pgbThreads
            // 
            this.pgbThreads.Location = new System.Drawing.Point(36, 61);
            this.pgbThreads.Name = "pgbThreads";
            this.pgbThreads.Size = new System.Drawing.Size(277, 23);
            this.pgbThreads.TabIndex = 1;
            this.pgbThreads.Click += new System.EventHandler(this.pgbThreads_Click);
            // 
            // Frm_DemoThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 118);
            this.Controls.Add(this.pgbThreads);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Frm_DemoThread";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_DemoThread_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ProgressBar pgbThreads;
    }
}

