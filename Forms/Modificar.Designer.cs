namespace MuvStore.Forms
{
    partial class Modificar
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
            this.label4 = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstanteriaMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDeposito = new System.Windows.Forms.ComboBox();
            this.txtPasilloMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPisoMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductoMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnModificarLomas = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lstProductos);
            this.panel1.Controls.Add(this.btnModificarLomas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtEstanteriaMod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbDeposito);
            this.panel1.Controls.Add(this.txtPasilloMod);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPisoMod);
            this.panel1.Controls.Add(this.txtProductoMod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCantidadMod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 450);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(836, 41);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(92, 13);
            this.labelId.TabIndex = 38;
            this.labelId.Text = "Buen dia Jorge :D";
            this.labelId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1178, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 37;
            this.label4.Visible = false;
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
            this.lstProductos.Location = new System.Drawing.Point(12, 211);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(550, 249);
            this.lstProductos.TabIndex = 36;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MuvStore.Properties.Resources.MuvStore_Logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(948, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Estanteria";
            // 
            // txtEstanteriaMod
            // 
            this.txtEstanteriaMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstanteriaMod.DefaultText = "";
            this.txtEstanteriaMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstanteriaMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstanteriaMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstanteriaMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstanteriaMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstanteriaMod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEstanteriaMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstanteriaMod.Location = new System.Drawing.Point(952, 362);
            this.txtEstanteriaMod.Name = "txtEstanteriaMod";
            this.txtEstanteriaMod.PasswordChar = '\0';
            this.txtEstanteriaMod.PlaceholderText = "";
            this.txtEstanteriaMod.SelectedText = "";
            this.txtEstanteriaMod.Size = new System.Drawing.Size(179, 36);
            this.txtEstanteriaMod.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(7, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Depósito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(948, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Pasillo";
            // 
            // cmbDeposito
            // 
            this.cmbDeposito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeposito.FormattingEnabled = true;
            this.cmbDeposito.Items.AddRange(new object[] {
            "Lomas de Zamora",
            "Temperley",
            "Adrogue"});
            this.cmbDeposito.Location = new System.Drawing.Point(13, 164);
            this.cmbDeposito.Name = "cmbDeposito";
            this.cmbDeposito.Size = new System.Drawing.Size(167, 29);
            this.cmbDeposito.TabIndex = 1;
            this.cmbDeposito.SelectedIndexChanged += new System.EventHandler(this.cmbDeposito_SelectedIndexChanged_1);
            // 
            // txtPasilloMod
            // 
            this.txtPasilloMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasilloMod.DefaultText = "";
            this.txtPasilloMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasilloMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasilloMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasilloMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasilloMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasilloMod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasilloMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasilloMod.Location = new System.Drawing.Point(952, 256);
            this.txtPasilloMod.Name = "txtPasilloMod";
            this.txtPasilloMod.PasswordChar = '\0';
            this.txtPasilloMod.PlaceholderText = "";
            this.txtPasilloMod.SelectedText = "";
            this.txtPasilloMod.Size = new System.Drawing.Size(179, 36);
            this.txtPasilloMod.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(948, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Piso";
            // 
            // txtPisoMod
            // 
            this.txtPisoMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPisoMod.DefaultText = "";
            this.txtPisoMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPisoMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPisoMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPisoMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPisoMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPisoMod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPisoMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPisoMod.Location = new System.Drawing.Point(952, 147);
            this.txtPisoMod.Name = "txtPisoMod";
            this.txtPisoMod.PasswordChar = '\0';
            this.txtPisoMod.PlaceholderText = "";
            this.txtPisoMod.SelectedText = "";
            this.txtPisoMod.Size = new System.Drawing.Size(179, 36);
            this.txtPisoMod.TabIndex = 26;
            // 
            // txtProductoMod
            // 
            this.txtProductoMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductoMod.DefaultText = "";
            this.txtProductoMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductoMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductoMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductoMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductoMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductoMod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductoMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductoMod.Location = new System.Drawing.Point(705, 147);
            this.txtProductoMod.Name = "txtProductoMod";
            this.txtProductoMod.PasswordChar = '\0';
            this.txtProductoMod.PlaceholderText = "";
            this.txtProductoMod.SelectedText = "";
            this.txtProductoMod.Size = new System.Drawing.Size(179, 36);
            this.txtProductoMod.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(701, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(701, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cantidad ";
            // 
            // txtCantidadMod
            // 
            this.txtCantidadMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidadMod.DefaultText = "";
            this.txtCantidadMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidadMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidadMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidadMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidadMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidadMod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidadMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidadMod.Location = new System.Drawing.Point(705, 256);
            this.txtCantidadMod.Name = "txtCantidadMod";
            this.txtCantidadMod.PasswordChar = '\0';
            this.txtCantidadMod.PlaceholderText = "";
            this.txtCantidadMod.SelectedText = "";
            this.txtCantidadMod.Size = new System.Drawing.Size(179, 36);
            this.txtCantidadMod.TabIndex = 23;
            // 
            // btnModificarLomas
            // 
            this.btnModificarLomas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarLomas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarLomas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarLomas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarLomas.FillColor = System.Drawing.Color.MediumPurple;
            this.btnModificarLomas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLomas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModificarLomas.Location = new System.Drawing.Point(704, 335);
            this.btnModificarLomas.Name = "btnModificarLomas";
            this.btnModificarLomas.Size = new System.Drawing.Size(180, 63);
            this.btnModificarLomas.TabIndex = 33;
            this.btnModificarLomas.Text = "MODIFICAR";
            this.btnModificarLomas.Click += new System.EventHandler(this.btnModificarLomas_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDeposito;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtEstanteriaMod;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPasilloMod;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPisoMod;
        private Guna.UI2.WinForms.Guna2TextBox txtProductoMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidadMod;
        private System.Windows.Forms.ListView lstProductos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelId;
        private Guna.UI2.WinForms.Guna2Button btnModificarLomas;
    }
}