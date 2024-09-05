
namespace YumYum_Fun
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.general_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.minimize_box = new Guna.UI2.WinForms.Guna2ControlBox();
            this.close_box = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.general_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // general_Panel
            // 
            this.general_Panel.Controls.Add(this.guna2GradientPanel1);
            this.general_Panel.Controls.Add(this.minimize_box);
            this.general_Panel.Controls.Add(this.close_box);
            this.general_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.general_Panel.Location = new System.Drawing.Point(0, 0);
            this.general_Panel.Name = "general_Panel";
            this.general_Panel.Size = new System.Drawing.Size(1600, 860);
            this.general_Panel.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(13, 22);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(120, 120);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // minimize_box
            // 
            this.minimize_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_box.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimize_box.FillColor = System.Drawing.Color.Coral;
            this.minimize_box.IconColor = System.Drawing.Color.White;
            this.minimize_box.Location = new System.Drawing.Point(54, 3);
            this.minimize_box.Name = "minimize_box";
            this.minimize_box.Size = new System.Drawing.Size(45, 29);
            this.minimize_box.TabIndex = 1;
            // 
            // close_box
            // 
            this.close_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_box.FillColor = System.Drawing.Color.Coral;
            this.close_box.IconColor = System.Drawing.Color.White;
            this.close_box.Location = new System.Drawing.Point(3, 3);
            this.close_box.Name = "close_box";
            this.close_box.Size = new System.Drawing.Size(45, 29);
            this.close_box.TabIndex = 0;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 40;
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(1443, 12);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(145, 836);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 860);
            this.Controls.Add(this.general_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.general_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel general_Panel;
        private Guna.UI2.WinForms.Guna2ControlBox minimize_box;
        private Guna.UI2.WinForms.Guna2ControlBox close_box;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}

