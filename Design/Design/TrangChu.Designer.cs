namespace Design
{
    partial class TrangChu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.p_button = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bt_lichsu = new FontAwesome.Sharp.IconButton();
            this.bt_tietkiem = new FontAwesome.Sharp.IconButton();
            this.bt_chuyentien = new FontAwesome.Sharp.IconButton();
            this.bt_thongtin = new FontAwesome.Sharp.IconButton();
            this.p_icon = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Home = new FontAwesome.Sharp.IconPictureBox();
            this.p_form = new System.Windows.Forms.Panel();
            this.p_button.SuspendLayout();
            this.p_icon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // p_button
            // 
            this.p_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(76)))));
            this.p_button.Controls.Add(this.linkLabel1);
            this.p_button.Controls.Add(this.bt_lichsu);
            this.p_button.Controls.Add(this.bt_tietkiem);
            this.p_button.Controls.Add(this.bt_chuyentien);
            this.p_button.Controls.Add(this.bt_thongtin);
            this.p_button.Controls.Add(this.p_icon);
            this.p_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_button.Location = new System.Drawing.Point(10, 0);
            this.p_button.Name = "p_button";
            this.p_button.Size = new System.Drawing.Size(242, 717);
            this.p_button.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(62, 590);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 25);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng Xuất";
            // 
            // bt_lichsu
            // 
            this.bt_lichsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_lichsu.FlatAppearance.BorderSize = 0;
            this.bt_lichsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_lichsu.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_lichsu.ForeColor = System.Drawing.Color.White;
            this.bt_lichsu.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.bt_lichsu.IconColor = System.Drawing.Color.White;
            this.bt_lichsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_lichsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_lichsu.Location = new System.Drawing.Point(0, 422);
            this.bt_lichsu.Name = "bt_lichsu";
            this.bt_lichsu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bt_lichsu.Size = new System.Drawing.Size(242, 91);
            this.bt_lichsu.TabIndex = 5;
            this.bt_lichsu.Text = "Lịch Sử";
            this.bt_lichsu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_lichsu.UseVisualStyleBackColor = true;
            this.bt_lichsu.Click += new System.EventHandler(this.bt_lichsu_Click);
            // 
            // bt_tietkiem
            // 
            this.bt_tietkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_tietkiem.FlatAppearance.BorderSize = 0;
            this.bt_tietkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tietkiem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_tietkiem.ForeColor = System.Drawing.Color.White;
            this.bt_tietkiem.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            this.bt_tietkiem.IconColor = System.Drawing.Color.White;
            this.bt_tietkiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_tietkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_tietkiem.Location = new System.Drawing.Point(0, 331);
            this.bt_tietkiem.Name = "bt_tietkiem";
            this.bt_tietkiem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bt_tietkiem.Size = new System.Drawing.Size(242, 91);
            this.bt_tietkiem.TabIndex = 4;
            this.bt_tietkiem.Text = "Tiết Kiệm";
            this.bt_tietkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_tietkiem.UseVisualStyleBackColor = true;
            this.bt_tietkiem.Click += new System.EventHandler(this.bt_tietkiem_Click);
            // 
            // bt_chuyentien
            // 
            this.bt_chuyentien.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_chuyentien.FlatAppearance.BorderSize = 0;
            this.bt_chuyentien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chuyentien.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_chuyentien.ForeColor = System.Drawing.Color.White;
            this.bt_chuyentien.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.bt_chuyentien.IconColor = System.Drawing.Color.White;
            this.bt_chuyentien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_chuyentien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chuyentien.Location = new System.Drawing.Point(0, 240);
            this.bt_chuyentien.Name = "bt_chuyentien";
            this.bt_chuyentien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bt_chuyentien.Size = new System.Drawing.Size(242, 91);
            this.bt_chuyentien.TabIndex = 3;
            this.bt_chuyentien.Text = "Chuyển Tiền";
            this.bt_chuyentien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_chuyentien.UseVisualStyleBackColor = true;
            this.bt_chuyentien.Click += new System.EventHandler(this.bt_chuyentien_Click);
            // 
            // bt_thongtin
            // 
            this.bt_thongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_thongtin.FlatAppearance.BorderSize = 0;
            this.bt_thongtin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thongtin.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_thongtin.ForeColor = System.Drawing.Color.White;
            this.bt_thongtin.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.bt_thongtin.IconColor = System.Drawing.Color.White;
            this.bt_thongtin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_thongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thongtin.Location = new System.Drawing.Point(0, 149);
            this.bt_thongtin.Name = "bt_thongtin";
            this.bt_thongtin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bt_thongtin.Size = new System.Drawing.Size(242, 91);
            this.bt_thongtin.TabIndex = 2;
            this.bt_thongtin.Text = "Thông Tin";
            this.bt_thongtin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_thongtin.UseVisualStyleBackColor = true;
            this.bt_thongtin.Click += new System.EventHandler(this.bt_thongtin_Click);
            // 
            // p_icon
            // 
            this.p_icon.Controls.Add(this.label1);
            this.p_icon.Controls.Add(this.bt_Home);
            this.p_icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_icon.Location = new System.Drawing.Point(0, 0);
            this.p_icon.Name = "p_icon";
            this.p_icon.Size = new System.Drawing.Size(242, 149);
            this.p_icon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // bt_Home
            // 
            this.bt_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(76)))));
            this.bt_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.bt_Home.IconChar = FontAwesome.Sharp.IconChar.User;
            this.bt_Home.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.bt_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Home.IconSize = 54;
            this.bt_Home.Location = new System.Drawing.Point(87, 33);
            this.bt_Home.Name = "bt_Home";
            this.bt_Home.Size = new System.Drawing.Size(54, 55);
            this.bt_Home.TabIndex = 0;
            this.bt_Home.TabStop = false;
            this.bt_Home.Click += new System.EventHandler(this.icon_curform_Click);
            // 
            // p_form
            // 
            this.p_form.AutoSize = true;
            this.p_form.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.p_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_form.Location = new System.Drawing.Point(252, 0);
            this.p_form.Name = "p_form";
            this.p_form.Size = new System.Drawing.Size(879, 717);
            this.p_form.TabIndex = 3;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1151, 717);
            this.Controls.Add(this.p_form);
            this.Controls.Add(this.p_button);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "TrangChu";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.p_button.ResumeLayout(false);
            this.p_button.PerformLayout();
            this.p_icon.ResumeLayout(false);
            this.p_icon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel p_button;
        private Panel p_icon;
        private LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton bt_lichsu;
        private FontAwesome.Sharp.IconButton bt_tietkiem;
        private FontAwesome.Sharp.IconButton bt_chuyentien;
        private FontAwesome.Sharp.IconButton bt_thongtin;
        private FontAwesome.Sharp.IconPictureBox bt_Home;
        private Panel p_form;
        private Label label1;
    }
}