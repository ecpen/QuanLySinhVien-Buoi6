namespace QuanLySinhVien
{
    partial class Form1
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
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            dgvSinhVien = new DataGridView();
            lblTrangThai = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLocDat = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(148, 111);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(190, 23);
            txtHoTen.TabIndex = 0;
            txtHoTen.TextChanged += this.txtHoTen_TextChanged;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(496, 108);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(169, 23);
            txtDiem.TabIndex = 1;
            txtDiem.TextChanged += this.txtDiem_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(76, 161);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += this.btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(174, 161);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += this.btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(276, 161);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += this.btnXoa_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(385, 161);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(75, 23);
            btnTaiLai.TabIndex = 5;
            btnTaiLai.Text = "Tải lại danh";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += this.btnTaiLai_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(39, 190);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.Size = new Size(726, 216);
            dgvSinhVien.TabIndex = 7;
            dgvSinhVien.CellContentClick += this.dgvSinhVien_CellContentClick;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(174, 426);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(38, 15);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "label1";
            lblTrangThai.Click += this.lblTrangThai_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 111);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 111);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 10;
            label3.Text = "Điểm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 47);
            label4.Name = "label4";
            label4.Size = new Size(171, 15);
            label4.TabIndex = 11;
            label4.Text = "QUẢN LÝ SINH VIÊN – EF CORE";
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(496, 161);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(75, 23);
            btnLocDat.TabIndex = 6;
            btnLocDat.Text = "Lọc SV";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += this.btnLocDat_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnLocDat);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTaiLai;
        private DataGridView dgvSinhVien;
        private Label lblTrangThai;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLocDat;
        
    }
}
