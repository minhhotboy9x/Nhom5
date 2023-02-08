
namespace Nhom5.View.hokhau_nhankhau.nhankhau_function
{
    partial class DanhSachHSG
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dongBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPanel1 = new Nhom5.Utility.SPanel();
            this.searchTextBox1 = new Nhom5.Utility.WaterMarkTextBox();
            this.featureSearchBox = new System.Windows.Forms.ComboBox();
            this.namHocLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.themMinhChungBtn = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(902, 75);
            this.panelTitleBar.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(132, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(639, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Danh sách học sinh nhận thưởng học sinh giỏi";
            // 
            // dongBtn
            // 
            this.dongBtn.BackColor = System.Drawing.Color.Gray;
            this.dongBtn.FlatAppearance.BorderSize = 0;
            this.dongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dongBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dongBtn.Location = new System.Drawing.Point(542, 570);
            this.dongBtn.Name = "dongBtn";
            this.dongBtn.Size = new System.Drawing.Size(140, 55);
            this.dongBtn.TabIndex = 16;
            this.dongBtn.Text = "Đóng";
            this.dongBtn.UseVisualStyleBackColor = false;
            this.dongBtn.Click += new System.EventHandler(this.dongBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 327);
            this.dataGridView1.TabIndex = 17;
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sPanel1.Controls.Add(this.searchTextBox1);
            this.sPanel1.Controls.Add(this.featureSearchBox);
            this.sPanel1.Location = new System.Drawing.Point(253, 174);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sPanel1.Size = new System.Drawing.Size(397, 29);
            this.sPanel1.TabIndex = 18;
            // 
            // searchTextBox1
            // 
            this.searchTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTextBox1.BackColor = System.Drawing.Color.White;
            this.searchTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox1.Location = new System.Drawing.Point(10, 4);
            this.searchTextBox1.Name = "searchTextBox1";
            this.searchTextBox1.Size = new System.Drawing.Size(236, 20);
            this.searchTextBox1.TabIndex = 5;
            this.searchTextBox1.WaterMarkColor = System.Drawing.Color.DimGray;
            this.searchTextBox1.WaterMarkText = "Nhập dữ liệu tra cứu";
            // 
            // featureSearchBox
            // 
            this.featureSearchBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.featureSearchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.featureSearchBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.featureSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featureSearchBox.FormattingEnabled = true;
            this.featureSearchBox.Items.AddRange(new object[] {
            "(none)"});
            this.featureSearchBox.Location = new System.Drawing.Point(265, 0);
            this.featureSearchBox.Name = "featureSearchBox";
            this.featureSearchBox.Size = new System.Drawing.Size(130, 26);
            this.featureSearchBox.TabIndex = 6;
            // 
            // namHocLbl
            // 
            this.namHocLbl.AutoSize = true;
            this.namHocLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namHocLbl.Location = new System.Drawing.Point(175, 94);
            this.namHocLbl.Name = "namHocLbl";
            this.namHocLbl.Size = new System.Drawing.Size(45, 20);
            this.namHocLbl.TabIndex = 19;
            this.namHocLbl.Text = "2020";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Năm học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Danh sách học sinh nhận thưởng:";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Gray;
            this.searchBtn.BackgroundImage = global::Nhom5.Properties.Resources.icons8_magnifying_glass_64;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchBtn.Location = new System.Drawing.Point(656, 170);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(40, 40);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.Gray;
            this.reloadBtn.BackgroundImage = global::Nhom5.Properties.Resources.icons8_update_left_rotation_50;
            this.reloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadBtn.FlatAppearance.BorderSize = 0;
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reloadBtn.Location = new System.Drawing.Point(66, 170);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(40, 40);
            this.reloadBtn.TabIndex = 23;
            this.reloadBtn.UseVisualStyleBackColor = false;
            // 
            // themMinhChungBtn
            // 
            this.themMinhChungBtn.BackColor = System.Drawing.Color.Gray;
            this.themMinhChungBtn.FlatAppearance.BorderSize = 0;
            this.themMinhChungBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themMinhChungBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themMinhChungBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.themMinhChungBtn.Location = new System.Drawing.Point(220, 570);
            this.themMinhChungBtn.Name = "themMinhChungBtn";
            this.themMinhChungBtn.Size = new System.Drawing.Size(172, 59);
            this.themMinhChungBtn.TabIndex = 24;
            this.themMinhChungBtn.Text = "Thêm minh chứng";
            this.themMinhChungBtn.UseVisualStyleBackColor = false;
            this.themMinhChungBtn.Click += new System.EventHandler(this.themMinhChungBtn_Click);
            // 
            // DanhSachHSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(902, 673);
            this.Controls.Add(this.themMinhChungBtn);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namHocLbl);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dongBtn);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DanhSachHSG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách học sinh nhận thưởng";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button dongBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Utility.SPanel sPanel1;
        private Utility.WaterMarkTextBox searchTextBox1;
        private System.Windows.Forms.ComboBox featureSearchBox;
        private System.Windows.Forms.Label namHocLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button themMinhChungBtn;
    }
}