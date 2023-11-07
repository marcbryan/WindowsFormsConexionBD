namespace WindowsFormsConexionBD
{
    partial class FormSelectEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectEmployees));
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.lbTexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEmployees
            // 
            this.lbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.HorizontalScrollbar = true;
            this.lbEmployees.ItemHeight = 25;
            this.lbEmployees.Location = new System.Drawing.Point(1, 1);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(798, 279);
            this.lbEmployees.TabIndex = 0;
            // 
            // cbFiltro
            // 
            this.cbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Ciudad"});
            this.cbFiltro.Location = new System.Drawing.Point(120, 289);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(264, 33);
            this.cbFiltro.TabIndex = 1;
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(12, 292);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(99, 25);
            this.lbFiltro.TabIndex = 2;
            this.lbFiltro.Text = "Filtrar por:";
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.Location = new System.Drawing.Point(12, 337);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(68, 25);
            this.lbTexto.TabIndex = 3;
            this.lbTexto.Text = "Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(120, 337);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(264, 30);
            this.txtTexto.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(288, 378);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 32);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormSelectEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lbTexto);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.lbEmployees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSelectEmployees";
            this.Text = "Ver empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnBuscar;
    }
}