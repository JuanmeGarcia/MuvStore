namespace MuvStore.Forms
{
    partial class Vender
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVenderLomas = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDeposito = new System.Windows.Forms.ComboBox();
            this.lstProductos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.lstProductos);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Controls.Add(this.btnVenderLomas);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbDeposito);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 355);
            this.panel1.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(637, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(51, 13);
            this.labelId.TabIndex = 22;
            this.labelId.Text = "te gusto?";
            this.labelId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(636, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducto.DefaultText = "";
            this.txtProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.Enabled = false;
            this.txtProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Location = new System.Drawing.Point(640, 47);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.PlaceholderText = "";
            this.txtProducto.SelectedText = "";
            this.txtProducto.Size = new System.Drawing.Size(179, 36);
            this.txtProducto.TabIndex = 18;
            // 
            // btnVenderLomas
            // 
            this.btnVenderLomas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVenderLomas.BorderColor = System.Drawing.Color.Bisque;
            this.btnVenderLomas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVenderLomas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVenderLomas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVenderLomas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVenderLomas.FillColor = System.Drawing.Color.MediumPurple;
            this.btnVenderLomas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenderLomas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVenderLomas.Location = new System.Drawing.Point(661, 168);
            this.btnVenderLomas.Name = "btnVenderLomas";
            this.btnVenderLomas.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnVenderLomas.Size = new System.Drawing.Size(148, 148);
            this.btnVenderLomas.TabIndex = 17;
            this.btnVenderLomas.Text = "VENDER";
            this.btnVenderLomas.Click += new System.EventHandler(this.btnVenderLomas_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.Location = new System.Drawing.Point(640, 117);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.Size = new System.Drawing.Size(179, 36);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(636, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Depósito";
            // 
            // cmbDeposito
            // 
            this.cmbDeposito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeposito.FormattingEnabled = true;
            this.cmbDeposito.Items.AddRange(new object[] {
            "Lomas de Zamora",
            "Temperley",
            "Adrogue"});
            this.cmbDeposito.Location = new System.Drawing.Point(18, 54);
            this.cmbDeposito.Name = "cmbDeposito";
            this.cmbDeposito.Size = new System.Drawing.Size(167, 29);
            this.cmbDeposito.TabIndex = 1;
            this.cmbDeposito.SelectedIndexChanged += new System.EventHandler(this.cmbDeposito_SelectedIndexChanged);
            // 
            // lstProductos
            // 
            this.lstProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader19,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstProductos.HideSelection = false;
            this.lstProductos.Location = new System.Drawing.Point(18, 103);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(586, 252);
            this.lstProductos.TabIndex = 23;
            this.lstProductos.UseCompatibleStateImageBehavior = false;
            this.lstProductos.View = System.Windows.Forms.View.Details;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Tipo de Producto";
            this.columnHeader19.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Producto";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pasillo";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estanteria";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Piso";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cantidad";
            this.columnHeader6.Width = 106;
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 355);
            this.Controls.Add(this.panel1);
            this.Name = "Vender";
            this.Text = "Vender";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDeposito;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtProducto;
        private System.Windows.Forms.Label labelId;
        private Guna.UI2.WinForms.Guna2CircleButton btnVenderLomas;
        private System.Windows.Forms.ListView lstProductos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}