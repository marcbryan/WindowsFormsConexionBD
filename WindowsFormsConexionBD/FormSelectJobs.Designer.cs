namespace WindowsFormsJobs
{
    partial class FormSelectJobs
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectJobs));
            this.lbJobs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbJobs
            // 
            this.lbJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobs.FormattingEnabled = true;
            this.lbJobs.ItemHeight = 25;
            this.lbJobs.Location = new System.Drawing.Point(13, 13);
            this.lbJobs.Name = "lbJobs";
            this.lbJobs.Size = new System.Drawing.Size(911, 429);
            this.lbJobs.TabIndex = 0;
            // 
            // FormSelectJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.lbJobs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSelectJobs";
            this.Text = "Lista de jobs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbJobs;
    }
}

