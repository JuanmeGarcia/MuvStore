namespace MuvStore
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            this.panelLoading = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLoading2 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.PBStart = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.panelLoading.Controls.Add(this.lblLoading2);
            this.panelLoading.Controls.Add(this.lblLoading);
            this.panelLoading.Controls.Add(this.PBStart);
            this.panelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoading.Location = new System.Drawing.Point(0, 0);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(455, 296);
            this.panelLoading.TabIndex = 0;
            this.panelLoading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLoading_MouseDown);
            // 
            // lblLoading2
            // 
            this.lblLoading2.AutoSize = true;
            this.lblLoading2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLoading2.Location = new System.Drawing.Point(183, 71);
            this.lblLoading2.Name = "lblLoading2";
            this.lblLoading2.Size = new System.Drawing.Size(99, 21);
            this.lblLoading2.TabIndex = 2;
            this.lblLoading2.Text = "Please Wait";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLoading.Location = new System.Drawing.Point(158, 32);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(173, 39);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading...";
            // 
            // PBStart
            // 
            this.PBStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.PBStart.FillColor = System.Drawing.Color.Gainsboro;
            this.PBStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PBStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.PBStart.Location = new System.Drawing.Point(177, 108);
            this.PBStart.Minimum = 0;
            this.PBStart.Name = "PBStart";
            this.PBStart.ProgressColor = System.Drawing.Color.DarkBlue;
            this.PBStart.ProgressColor2 = System.Drawing.Color.DarkBlue;
            this.PBStart.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PBStart.Size = new System.Drawing.Size(131, 131);
            this.PBStart.TabIndex = 0;
            this.PBStart.Text = "guna2CircleProgressBar1";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 296);
            this.Controls.Add(this.panelLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelLoading;
        private System.Windows.Forms.Label lblLoading2;
        private System.Windows.Forms.Label lblLoading;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PBStart;
        private System.Windows.Forms.Timer timer1;
    }
}