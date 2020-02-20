namespace FORCADEL
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuTop = new System.Windows.Forms.Panel();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.pictureBox2);
            this.MenuTop.Controls.Add(this.pictureBoxCerrar);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1400, 80);
            this.MenuTop.TabIndex = 0;
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 80);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 820);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.SystemColors.Control;
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1400, 820);
            this.Wrapper.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1258, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(1322, 18);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(45, 44);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCerrar.TabIndex = 8;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
    }
}