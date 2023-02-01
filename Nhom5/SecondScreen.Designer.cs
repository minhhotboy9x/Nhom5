namespace Nhom5
{
    partial class SecondScreen
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.thongKeBtn = new System.Windows.Forms.Button();
            this.hoKhauBtn = new System.Windows.Forms.Button();
            this.nhanKhauBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.homeUC1 = new Nhom5.View.hokhau_nhankhau.HomeUC();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.thongKeBtn);
            this.panelMenu.Controls.Add(this.hoKhauBtn);
            this.panelMenu.Controls.Add(this.nhanKhauBtn);
            this.panelMenu.Controls.Add(this.homeBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 673);
            this.panelMenu.TabIndex = 0;
            // 
            // thongKeBtn
            // 
            this.thongKeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.thongKeBtn.FlatAppearance.BorderSize = 0;
            this.thongKeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thongKeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongKeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.thongKeBtn.Image = global::Nhom5.Properties.Resources.icons8_analytics_601;
            this.thongKeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thongKeBtn.Location = new System.Drawing.Point(0, 255);
            this.thongKeBtn.Name = "thongKeBtn";
            this.thongKeBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.thongKeBtn.Size = new System.Drawing.Size(214, 60);
            this.thongKeBtn.TabIndex = 4;
            this.thongKeBtn.Text = " Thống kê";
            this.thongKeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thongKeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.thongKeBtn.UseVisualStyleBackColor = true;
            this.thongKeBtn.Click += new System.EventHandler(this.thongKeBtn_Click);
            // 
            // hoKhauBtn
            // 
            this.hoKhauBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.hoKhauBtn.FlatAppearance.BorderSize = 0;
            this.hoKhauBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoKhauBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoKhauBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.hoKhauBtn.Image = global::Nhom5.Properties.Resources.icons8_exterior_96;
            this.hoKhauBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hoKhauBtn.Location = new System.Drawing.Point(0, 195);
            this.hoKhauBtn.Name = "hoKhauBtn";
            this.hoKhauBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.hoKhauBtn.Size = new System.Drawing.Size(214, 60);
            this.hoKhauBtn.TabIndex = 3;
            this.hoKhauBtn.Text = " Hộ khẩu";
            this.hoKhauBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hoKhauBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hoKhauBtn.UseVisualStyleBackColor = true;
            this.hoKhauBtn.Click += new System.EventHandler(this.hoKhauBtn_Click);
            // 
            // nhanKhauBtn
            // 
            this.nhanKhauBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanKhauBtn.FlatAppearance.BorderSize = 0;
            this.nhanKhauBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nhanKhauBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhanKhauBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.nhanKhauBtn.Image = global::Nhom5.Properties.Resources.icons8_man_100;
            this.nhanKhauBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nhanKhauBtn.Location = new System.Drawing.Point(0, 135);
            this.nhanKhauBtn.Name = "nhanKhauBtn";
            this.nhanKhauBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.nhanKhauBtn.Size = new System.Drawing.Size(214, 60);
            this.nhanKhauBtn.TabIndex = 2;
            this.nhanKhauBtn.Text = " Nhân khẩu";
            this.nhanKhauBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nhanKhauBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nhanKhauBtn.UseVisualStyleBackColor = true;
            this.nhanKhauBtn.Click += new System.EventHandler(this.nhanKhauBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.Image = global::Nhom5.Properties.Resources.icons8_adventures_96;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 75);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(214, 60);
            this.homeBtn.TabIndex = 5;
            this.homeBtn.Text = " Trang chủ";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(214, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(214, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1048, 75);
            this.panelTitleBar.TabIndex = 1;
            // 
            // homeUC1
            // 
            this.homeUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.homeUC1.Location = new System.Drawing.Point(214, 75);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(1048, 598);
            this.homeUC1.TabIndex = 2;
            // 
            // SecondScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.homeUC1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.Name = "SecondScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân khẩu";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button nhanKhauBtn;
        private System.Windows.Forms.Button thongKeBtn;
        private System.Windows.Forms.Button hoKhauBtn;
        private System.Windows.Forms.Button homeBtn;
        private View.hokhau_nhankhau.HomeUC homeUC1;
    }
}