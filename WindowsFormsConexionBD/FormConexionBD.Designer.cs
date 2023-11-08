namespace WindowsFormsConexionBD
{
    partial class FormConexionBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConexionBD));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblConectado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblCerrarConexion = new System.Windows.Forms.Label();
            this.btnInsertarJob = new System.Windows.Forms.Button();
            this.lblInsertado = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblMinSalary = new System.Windows.Forms.Label();
            this.lblMaxSalary = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.nmrMinSalary = new System.Windows.Forms.NumericUpDown();
            this.nmrMaxSalary = new System.Windows.Forms.NumericUpDown();
            this.btnInsertCustomJob = new System.Windows.Forms.Button();
            this.lblInsertedCustomJob = new System.Windows.Forms.Label();
            this.btnVerJobs = new System.Windows.Forms.Button();
            this.btnBorrarMinSalary = new System.Windows.Forms.Button();
            this.btnBorrarMaxSalary = new System.Windows.Forms.Button();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.btnInsertCustomJobLinq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMaxSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAbrir.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(264, 187);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 35);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblConectado
            // 
            this.lblConectado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConectado.AutoSize = true;
            this.lblConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectado.Location = new System.Drawing.Point(244, 243);
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(0, 25);
            this.lblConectado.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.Enabled = false;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(435, 187);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblCerrarConexion
            // 
            this.lblCerrarConexion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCerrarConexion.AutoSize = true;
            this.lblCerrarConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarConexion.Location = new System.Drawing.Point(398, 243);
            this.lblCerrarConexion.Name = "lblCerrarConexion";
            this.lblCerrarConexion.Size = new System.Drawing.Size(0, 25);
            this.lblCerrarConexion.TabIndex = 3;
            // 
            // btnInsertarJob
            // 
            this.btnInsertarJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertarJob.Enabled = false;
            this.btnInsertarJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarJob.Location = new System.Drawing.Point(179, 311);
            this.btnInsertarJob.Name = "btnInsertarJob";
            this.btnInsertarJob.Size = new System.Drawing.Size(135, 36);
            this.btnInsertarJob.TabIndex = 4;
            this.btnInsertarJob.Text = "Insertar job";
            this.btnInsertarJob.UseVisualStyleBackColor = true;
            this.btnInsertarJob.Click += new System.EventHandler(this.btnInsertarJob_Click);
            // 
            // lblInsertado
            // 
            this.lblInsertado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInsertado.AutoSize = true;
            this.lblInsertado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertado.Location = new System.Drawing.Point(162, 360);
            this.lblInsertado.Name = "lblInsertado";
            this.lblInsertado.Size = new System.Drawing.Size(0, 25);
            this.lblInsertado.TabIndex = 5;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.Location = new System.Drawing.Point(201, 429);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(85, 25);
            this.lblJobTitle.TabIndex = 6;
            this.lblJobTitle.Text = "Job title:";
            // 
            // lblMinSalary
            // 
            this.lblMinSalary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMinSalary.AutoSize = true;
            this.lblMinSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinSalary.Location = new System.Drawing.Point(201, 478);
            this.lblMinSalary.Name = "lblMinSalary";
            this.lblMinSalary.Size = new System.Drawing.Size(107, 25);
            this.lblMinSalary.TabIndex = 7;
            this.lblMinSalary.Text = "Min salary:";
            // 
            // lblMaxSalary
            // 
            this.lblMaxSalary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaxSalary.AutoSize = true;
            this.lblMaxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSalary.Location = new System.Drawing.Point(201, 523);
            this.lblMaxSalary.Name = "lblMaxSalary";
            this.lblMaxSalary.Size = new System.Drawing.Size(113, 25);
            this.lblMaxSalary.TabIndex = 8;
            this.lblMaxSalary.Text = "Max salary:";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.Location = new System.Drawing.Point(320, 429);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(260, 30);
            this.txtJobTitle.TabIndex = 9;
            // 
            // nmrMinSalary
            // 
            this.nmrMinSalary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nmrMinSalary.DecimalPlaces = 2;
            this.nmrMinSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrMinSalary.Location = new System.Drawing.Point(320, 478);
            this.nmrMinSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrMinSalary.Name = "nmrMinSalary";
            this.nmrMinSalary.Size = new System.Drawing.Size(260, 30);
            this.nmrMinSalary.TabIndex = 10;
            // 
            // nmrMaxSalary
            // 
            this.nmrMaxSalary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nmrMaxSalary.DecimalPlaces = 2;
            this.nmrMaxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrMaxSalary.Location = new System.Drawing.Point(320, 523);
            this.nmrMaxSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrMaxSalary.Name = "nmrMaxSalary";
            this.nmrMaxSalary.Size = new System.Drawing.Size(260, 30);
            this.nmrMaxSalary.TabIndex = 11;
            // 
            // btnInsertCustomJob
            // 
            this.btnInsertCustomJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertCustomJob.Enabled = false;
            this.btnInsertCustomJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCustomJob.Location = new System.Drawing.Point(302, 569);
            this.btnInsertCustomJob.Name = "btnInsertCustomJob";
            this.btnInsertCustomJob.Size = new System.Drawing.Size(135, 36);
            this.btnInsertCustomJob.TabIndex = 12;
            this.btnInsertCustomJob.Text = "Insertar job";
            this.btnInsertCustomJob.UseVisualStyleBackColor = true;
            this.btnInsertCustomJob.Click += new System.EventHandler(this.btnInsertCustomJob_Click);
            // 
            // lblInsertedCustomJob
            // 
            this.lblInsertedCustomJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInsertedCustomJob.AutoSize = true;
            this.lblInsertedCustomJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertedCustomJob.Location = new System.Drawing.Point(185, 665);
            this.lblInsertedCustomJob.Name = "lblInsertedCustomJob";
            this.lblInsertedCustomJob.Size = new System.Drawing.Size(0, 25);
            this.lblInsertedCustomJob.TabIndex = 13;
            // 
            // btnVerJobs
            // 
            this.btnVerJobs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVerJobs.Enabled = false;
            this.btnVerJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerJobs.Location = new System.Drawing.Point(320, 311);
            this.btnVerJobs.Name = "btnVerJobs";
            this.btnVerJobs.Size = new System.Drawing.Size(135, 36);
            this.btnVerJobs.TabIndex = 14;
            this.btnVerJobs.Text = "Ver jobs";
            this.btnVerJobs.UseVisualStyleBackColor = true;
            this.btnVerJobs.Click += new System.EventHandler(this.btnVerJobs_Click);
            // 
            // btnBorrarMinSalary
            // 
            this.btnBorrarMinSalary.BackColor = System.Drawing.Color.Red;
            this.btnBorrarMinSalary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBorrarMinSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarMinSalary.Location = new System.Drawing.Point(587, 478);
            this.btnBorrarMinSalary.Name = "btnBorrarMinSalary";
            this.btnBorrarMinSalary.Size = new System.Drawing.Size(84, 30);
            this.btnBorrarMinSalary.TabIndex = 15;
            this.btnBorrarMinSalary.Text = "Borrar";
            this.btnBorrarMinSalary.UseVisualStyleBackColor = false;
            this.btnBorrarMinSalary.Click += new System.EventHandler(this.btnBorrarMinSalary_Click);
            // 
            // btnBorrarMaxSalary
            // 
            this.btnBorrarMaxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarMaxSalary.Location = new System.Drawing.Point(587, 523);
            this.btnBorrarMaxSalary.Name = "btnBorrarMaxSalary";
            this.btnBorrarMaxSalary.Size = new System.Drawing.Size(84, 30);
            this.btnBorrarMaxSalary.TabIndex = 16;
            this.btnBorrarMaxSalary.Text = "Borrar";
            this.btnBorrarMaxSalary.UseVisualStyleBackColor = true;
            this.btnBorrarMaxSalary.Click += new System.EventHandler(this.btnBorrarMaxSalary_Click);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowEmployees.Enabled = false;
            this.btnShowEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEmployees.Location = new System.Drawing.Point(461, 311);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(172, 36);
            this.btnShowEmployees.TabIndex = 17;
            this.btnShowEmployees.Text = "Ver empleados";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // btnInsertCustomJobLinq
            // 
            this.btnInsertCustomJobLinq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertCustomJobLinq.Enabled = false;
            this.btnInsertCustomJobLinq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCustomJobLinq.Location = new System.Drawing.Point(445, 569);
            this.btnInsertCustomJobLinq.Name = "btnInsertCustomJobLinq";
            this.btnInsertCustomJobLinq.Size = new System.Drawing.Size(135, 64);
            this.btnInsertCustomJobLinq.TabIndex = 18;
            this.btnInsertCustomJobLinq.Text = "Insertar job con Linq";
            this.btnInsertCustomJobLinq.UseVisualStyleBackColor = true;
            this.btnInsertCustomJobLinq.Click += new System.EventHandler(this.btnInsertCustomJobLinq_Click);
            // 
            // FormConexionBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 728);
            this.Controls.Add(this.btnInsertCustomJobLinq);
            this.Controls.Add(this.btnShowEmployees);
            this.Controls.Add(this.btnBorrarMaxSalary);
            this.Controls.Add(this.btnBorrarMinSalary);
            this.Controls.Add(this.btnVerJobs);
            this.Controls.Add(this.lblInsertedCustomJob);
            this.Controls.Add(this.btnInsertCustomJob);
            this.Controls.Add(this.nmrMaxSalary);
            this.Controls.Add(this.nmrMinSalary);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.lblMaxSalary);
            this.Controls.Add(this.lblMinSalary);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.lblInsertado);
            this.Controls.Add(this.btnInsertarJob);
            this.Controls.Add(this.lblCerrarConexion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblConectado);
            this.Controls.Add(this.btnAbrir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConexionBD";
            this.Text = "Formulario Conexión BD";
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMaxSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblConectado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblCerrarConexion;
        private System.Windows.Forms.Button btnInsertarJob;
        private System.Windows.Forms.Label lblInsertado;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblMinSalary;
        private System.Windows.Forms.Label lblMaxSalary;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.NumericUpDown nmrMinSalary;
        private System.Windows.Forms.NumericUpDown nmrMaxSalary;
        private System.Windows.Forms.Button btnInsertCustomJob;
        private System.Windows.Forms.Label lblInsertedCustomJob;
        private System.Windows.Forms.Button btnVerJobs;
        private System.Windows.Forms.Button btnBorrarMinSalary;
        private System.Windows.Forms.Button btnBorrarMaxSalary;
        private System.Windows.Forms.Button btnShowEmployees;
        private System.Windows.Forms.Button btnInsertCustomJobLinq;
    }
}

