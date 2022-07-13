namespace MuvStore.Forms
{
    partial class Comprar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnComprar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstanteria = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasillo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPiso = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbDeposito = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbTP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.messageBoxGuna = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnComprar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtEstanteria);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPasillo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPiso);
            this.panel1.Controls.Add(this.cmbDeposito);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.cmbTP);
            this.panel1.Controls.Add(this.lblTipoProducto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::MuvStore.Properties.Resources.MuvStore_Logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(31, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComprar.BorderColor = System.Drawing.Color.Bisque;
            this.btnComprar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComprar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComprar.FillColor = System.Drawing.Color.MediumPurple;
            this.btnComprar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnComprar.Location = new System.Drawing.Point(711, 127);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnComprar.Size = new System.Drawing.Size(148, 148);
            this.btnComprar.TabIndex = 16;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(387, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estanteria";
            // 
            // txtEstanteria
            // 
            this.txtEstanteria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstanteria.DefaultText = "";
            this.txtEstanteria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstanteria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstanteria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstanteria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstanteria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstanteria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEstanteria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstanteria.Location = new System.Drawing.Point(391, 369);
            this.txtEstanteria.MaxLength = 4;
            this.txtEstanteria.Name = "txtEstanteria";
            this.txtEstanteria.PasswordChar = '\0';
            this.txtEstanteria.PlaceholderText = "";
            this.txtEstanteria.SelectedText = "";
            this.txtEstanteria.Size = new System.Drawing.Size(200, 36);
            this.txtEstanteria.TabIndex = 14;
            this.txtEstanteria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(387, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pasillo";
            // 
            // txtPasillo
            // 
            this.txtPasillo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasillo.DefaultText = "";
            this.txtPasillo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasillo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasillo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasillo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasillo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasillo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasillo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasillo.Location = new System.Drawing.Point(391, 263);
            this.txtPasillo.MaxLength = 4;
            this.txtPasillo.Name = "txtPasillo";
            this.txtPasillo.PasswordChar = '\0';
            this.txtPasillo.PlaceholderText = "";
            this.txtPasillo.SelectedText = "";
            this.txtPasillo.Size = new System.Drawing.Size(200, 36);
            this.txtPasillo.TabIndex = 12;
            this.txtPasillo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(387, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Piso";
            // 
            // txtPiso
            // 
            this.txtPiso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPiso.DefaultText = "";
            this.txtPiso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPiso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPiso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPiso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPiso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPiso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPiso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPiso.Location = new System.Drawing.Point(391, 154);
            this.txtPiso.MaxLength = 4;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.PasswordChar = '\0';
            this.txtPiso.PlaceholderText = "";
            this.txtPiso.SelectedText = "";
            this.txtPiso.Size = new System.Drawing.Size(200, 36);
            this.txtPiso.TabIndex = 10;
            this.txtPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cmbDeposito
            // 
            this.cmbDeposito.BackColor = System.Drawing.Color.Transparent;
            this.cmbDeposito.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeposito.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDeposito.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDeposito.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDeposito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDeposito.ItemHeight = 30;
            this.cmbDeposito.Items.AddRange(new object[] {
            "Lomas de Zamora",
            "Temperley",
            "Adrogue"});
            this.cmbDeposito.Location = new System.Drawing.Point(391, 54);
            this.cmbDeposito.Name = "cmbDeposito";
            this.cmbDeposito.Size = new System.Drawing.Size(200, 36);
            this.cmbDeposito.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(387, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Deposito";
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
            this.txtCantidad.Location = new System.Drawing.Point(31, 263);
            this.txtCantidad.MaxLength = 9;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.Size = new System.Drawing.Size(200, 36);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cmbTP
            // 
            this.cmbTP.BackColor = System.Drawing.Color.Transparent;
            this.cmbTP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTP.ItemHeight = 30;
            this.cmbTP.Items.AddRange(new object[] {
            "Suministro",
            "Material",
            "Producto"});
            this.cmbTP.Location = new System.Drawing.Point(31, 54);
            this.cmbTP.Name = "cmbTP";
            this.cmbTP.Size = new System.Drawing.Size(200, 36);
            this.cmbTP.TabIndex = 6;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTipoProducto.Location = new System.Drawing.Point(27, 27);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(183, 24);
            this.lblTipoProducto.TabIndex = 5;
            this.lblTipoProducto.Text = "Tipo de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(27, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(27, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducto.DefaultText = "";
            this.txtProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Location = new System.Drawing.Point(31, 154);
            this.txtProducto.MaxLength = 40;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.PlaceholderText = "";
            this.txtProducto.SelectedText = "";
            this.txtProducto.Size = new System.Drawing.Size(200, 36);
            this.txtProducto.TabIndex = 0;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // messageBoxGuna
            // 
            this.messageBoxGuna.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageBoxGuna.Caption = null;
            this.messageBoxGuna.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.messageBoxGuna.Parent = null;
            this.messageBoxGuna.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.messageBoxGuna.Text = "El elemento fue creado satisfactoriamente";
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Comprar";
            this.Text = "Comprar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnComprar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Guna.UI2.WinForms.Guna2TextBox txtProducto;
        public Guna.UI2.WinForms.Guna2TextBox txtEstanteria;
        public Guna.UI2.WinForms.Guna2TextBox txtPasillo;
        public Guna.UI2.WinForms.Guna2TextBox txtPiso;
        public Guna.UI2.WinForms.Guna2ComboBox cmbDeposito;
        public Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        public Guna.UI2.WinForms.Guna2ComboBox cmbTP;
        private Guna.UI2.WinForms.Guna2MessageDialog messageBoxGuna;
    }
}