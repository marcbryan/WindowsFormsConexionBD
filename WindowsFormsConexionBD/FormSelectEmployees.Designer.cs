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
            this.lbTexto = new System.Windows.Forms.Label();
            this.txtTextoNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarConLinq = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipoNombre = new System.Windows.Forms.ComboBox();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.lblFiltroApellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoApellido = new System.Windows.Forms.ComboBox();
            this.txtTextoApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFiltroCiudad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoCiudad = new System.Windows.Forms.ComboBox();
            this.txtTextoCiudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBorrarNombre = new System.Windows.Forms.Button();
            this.btnBorrarApellido = new System.Windows.Forms.Button();
            this.btnBorrarCiudad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEmployees
            // 
            this.lbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.HorizontalScrollbar = true;
            this.lbEmployees.ItemHeight = 25;
            this.lbEmployees.Location = new System.Drawing.Point(1, 1);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(1127, 329);
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
            this.cbFiltro.Location = new System.Drawing.Point(120, 617);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(281, 33);
            this.cbFiltro.TabIndex = 1;
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.Location = new System.Drawing.Point(12, 443);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(68, 25);
            this.lbTexto.TabIndex = 3;
            this.lbTexto.Text = "Texto:";
            // 
            // txtTextoNombre
            // 
            this.txtTextoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoNombre.Location = new System.Drawing.Point(86, 443);
            this.txtTextoNombre.Name = "txtTextoNombre";
            this.txtTextoNombre.Size = new System.Drawing.Size(281, 30);
            this.txtTextoNombre.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(431, 554);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 32);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarConLinq
            // 
            this.btnBuscarConLinq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarConLinq.Location = new System.Drawing.Point(533, 554);
            this.btnBuscarConLinq.Name = "btnBuscarConLinq";
            this.btnBuscarConLinq.Size = new System.Drawing.Size(179, 32);
            this.btnBuscarConLinq.TabIndex = 6;
            this.btnBuscarConLinq.Text = "Buscar con Linq";
            this.btnBuscarConLinq.UseVisualStyleBackColor = true;
            this.btnBuscarConLinq.Click += new System.EventHandler(this.btnBuscarConLinq_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 395);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(57, 25);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbTipoNombre
            // 
            this.cbTipoNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoNombre.FormattingEnabled = true;
            this.cbTipoNombre.Items.AddRange(new object[] {
            "Igual a (=)",
            "Empieza por...",
            "Termina por..."});
            this.cbTipoNombre.Location = new System.Drawing.Point(86, 392);
            this.cbTipoNombre.Name = "cbTipoNombre";
            this.cbTipoNombre.Size = new System.Drawing.Size(281, 33);
            this.cbTipoNombre.TabIndex = 7;
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroNombre.Location = new System.Drawing.Point(12, 350);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(128, 25);
            this.lblFiltroNombre.TabIndex = 9;
            this.lblFiltroNombre.Text = "Filtro Nombre";
            // 
            // lblFiltroApellido
            // 
            this.lblFiltroApellido.AutoSize = true;
            this.lblFiltroApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroApellido.Location = new System.Drawing.Point(383, 350);
            this.lblFiltroApellido.Name = "lblFiltroApellido";
            this.lblFiltroApellido.Size = new System.Drawing.Size(129, 25);
            this.lblFiltroApellido.TabIndex = 14;
            this.lblFiltroApellido.Text = "Filtro Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo:";
            // 
            // cbTipoApellido
            // 
            this.cbTipoApellido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoApellido.FormattingEnabled = true;
            this.cbTipoApellido.Items.AddRange(new object[] {
            "Igual a (=)",
            "Empieza por...",
            "Termina por..."});
            this.cbTipoApellido.Location = new System.Drawing.Point(457, 392);
            this.cbTipoApellido.Name = "cbTipoApellido";
            this.cbTipoApellido.Size = new System.Drawing.Size(281, 33);
            this.cbTipoApellido.TabIndex = 12;
            // 
            // txtTextoApellido
            // 
            this.txtTextoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoApellido.Location = new System.Drawing.Point(457, 443);
            this.txtTextoApellido.Name = "txtTextoApellido";
            this.txtTextoApellido.Size = new System.Drawing.Size(281, 30);
            this.txtTextoApellido.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Texto:";
            // 
            // lblFiltroCiudad
            // 
            this.lblFiltroCiudad.AutoSize = true;
            this.lblFiltroCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroCiudad.Location = new System.Drawing.Point(758, 350);
            this.lblFiltroCiudad.Name = "lblFiltroCiudad";
            this.lblFiltroCiudad.Size = new System.Drawing.Size(122, 25);
            this.lblFiltroCiudad.TabIndex = 19;
            this.lblFiltroCiudad.Text = "Filtro Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(758, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo:";
            // 
            // cbTipoCiudad
            // 
            this.cbTipoCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCiudad.FormattingEnabled = true;
            this.cbTipoCiudad.Items.AddRange(new object[] {
            "Igual a (=)",
            "Empieza por...",
            "Termina por..."});
            this.cbTipoCiudad.Location = new System.Drawing.Point(832, 392);
            this.cbTipoCiudad.Name = "cbTipoCiudad";
            this.cbTipoCiudad.Size = new System.Drawing.Size(281, 33);
            this.cbTipoCiudad.TabIndex = 17;
            // 
            // txtTextoCiudad
            // 
            this.txtTextoCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoCiudad.Location = new System.Drawing.Point(832, 443);
            this.txtTextoCiudad.Name = "txtTextoCiudad";
            this.txtTextoCiudad.Size = new System.Drawing.Size(281, 30);
            this.txtTextoCiudad.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(758, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Texto:";
            // 
            // btnBorrarNombre
            // 
            this.btnBorrarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarNombre.Location = new System.Drawing.Point(271, 488);
            this.btnBorrarNombre.Name = "btnBorrarNombre";
            this.btnBorrarNombre.Size = new System.Drawing.Size(96, 32);
            this.btnBorrarNombre.TabIndex = 20;
            this.btnBorrarNombre.Text = "Borrar";
            this.btnBorrarNombre.UseVisualStyleBackColor = true;
            this.btnBorrarNombre.Click += new System.EventHandler(this.btnBorrarNombre_Click);
            // 
            // btnBorrarApellido
            // 
            this.btnBorrarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarApellido.Location = new System.Drawing.Point(642, 488);
            this.btnBorrarApellido.Name = "btnBorrarApellido";
            this.btnBorrarApellido.Size = new System.Drawing.Size(96, 32);
            this.btnBorrarApellido.TabIndex = 21;
            this.btnBorrarApellido.Text = "Borrar";
            this.btnBorrarApellido.UseVisualStyleBackColor = true;
            this.btnBorrarApellido.Click += new System.EventHandler(this.btnBorrarApellido_Click);
            // 
            // btnBorrarCiudad
            // 
            this.btnBorrarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCiudad.Location = new System.Drawing.Point(1017, 488);
            this.btnBorrarCiudad.Name = "btnBorrarCiudad";
            this.btnBorrarCiudad.Size = new System.Drawing.Size(96, 32);
            this.btnBorrarCiudad.TabIndex = 22;
            this.btnBorrarCiudad.Text = "Borrar";
            this.btnBorrarCiudad.UseVisualStyleBackColor = true;
            this.btnBorrarCiudad.Click += new System.EventHandler(this.btnBorrarCiudad_Click);
            // 
            // FormSelectEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 702);
            this.Controls.Add(this.btnBorrarCiudad);
            this.Controls.Add(this.btnBorrarApellido);
            this.Controls.Add(this.btnBorrarNombre);
            this.Controls.Add(this.lblFiltroCiudad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTipoCiudad);
            this.Controls.Add(this.txtTextoCiudad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFiltroApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoApellido);
            this.Controls.Add(this.txtTextoApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFiltroNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbTipoNombre);
            this.Controls.Add(this.btnBuscarConLinq);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTextoNombre);
            this.Controls.Add(this.lbTexto);
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
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.TextBox txtTextoNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarConLinq;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipoNombre;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.Label lblFiltroApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoApellido;
        private System.Windows.Forms.TextBox txtTextoApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFiltroCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoCiudad;
        private System.Windows.Forms.TextBox txtTextoCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBorrarNombre;
        private System.Windows.Forms.Button btnBorrarApellido;
        private System.Windows.Forms.Button btnBorrarCiudad;
    }
}