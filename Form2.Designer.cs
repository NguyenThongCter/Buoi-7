namespace WinFormsApp4
{
    partial class Form2
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
            dgvSinhVien = new DataGridView();
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            btnLocDat = new Button();
            label1 = new Label();
            label2 = new Label();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(46, 193);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(700, 205);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(121, 37);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(246, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(465, 37);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(125, 27);
            txtDiem.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(93, 117);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 40);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(225, 117);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 40);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(366, 117);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 40);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(503, 117);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(103, 40);
            btnTaiLai.TabIndex = 6;
            btnTaiLai.Text = "Tải Lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += button4_Click;
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(636, 117);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(128, 40);
            btnLocDat.TabIndex = 7;
            btnLocDat.Text = "Lọc SV đạt LINQ";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 44);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 8;
            label1.Text = "Họ Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 40);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 9;
            label2.Text = "Điểm";
            label2.Click += label2_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(46, 412);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(170, 20);
            lblTrangThai.TabIndex = 10;
            lblTrangThai.Text = "hiện thông báo kết quả: ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrangThai);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLocDat);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Controls.Add(dgvSinhVien);
            Name = "Form2";
            Text = "Quản Lý Sinh Viên";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSinhVien;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTaiLai;
        private Button btnLocDat;
        private Label label1;
        private Label label2;
        private Label lblTrangThai;
    }
}