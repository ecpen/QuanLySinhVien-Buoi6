
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // TextBox h? tên
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
        }

        // TextBox ?i?m
        private void txtDiem_TextChanged(object sender, EventArgs e)
        {
        }

        // READ - T?i danh sách sinh viên
        private async Task TaiDanhSach()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var ds = await db.Students
                        .AsNoTracking()
                        .ToListAsync();

                    dgvSinhVien.DataSource = null;
                    dgvSinhVien.DataSource = ds;

                    lblTrangThai.Text =
                        $"?ã t?i {ds.Count} sinh viên";

                    lblTrangThai.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        // CREATE - Thêm sinh viên
        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap(out double diem))
                return;

            try
            {
                using (var db = new AppDbContext())
                {
                    Student sv = new Student
                    {
                        FullName = txtHoTen.Text.Trim(),
                        Grade = diem
                    };

                    db.Students.Add(sv);
                    await db.SaveChangesAsync();
                }

                txtHoTen.Clear();
                txtDiem.Clear();

                await TaiDanhSach();
                lblTrangThai.Text = "?ã thêm sinh viên!";
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        // UPDATE - S?a sinh viên
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem
                is not Student svChon)
            {
                MessageBox.Show("Vui lòng ch?n sinh viên c?n s?a!");
                return;
            }

            if (!KiemTraNhap(out double diem))
                return;

            try
            {
                using (var db = new AppDbContext())
                {
                    var sv = await db.Students
                        .FindAsync(svChon.Id);

                    if (sv == null)
                    {
                        MessageBox.Show("Không tìm th?y sinh viên!");
                        return;
                    }

                    sv.FullName = txtHoTen.Text.Trim();
                    sv.Grade = diem;

                    await db.SaveChangesAsync();
                }

                await TaiDanhSach();
                lblTrangThai.Text = "?ã s?a sinh viên!";
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        // DELETE - Xóa sinh viên
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem
                is not Student svChon)
            {
                MessageBox.Show("Vui lòng ch?n sinh viên c?n xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                $"B?n có mu?n xóa sinh viên {svChon.FullName}?",
                "Xác nh?n xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                using (var db = new AppDbContext())
                {
                    var sv = await db.Students
                        .FindAsync(svChon.Id);

                    if (sv == null)
                    {
                        MessageBox.Show("Không tìm th?y sinh viên!");
                        return;
                    }

                    db.Students.Remove(sv);
                    await db.SaveChangesAsync();
                }

                txtHoTen.Clear();
                txtDiem.Clear();

                await TaiDanhSach();
                lblTrangThai.Text = "?ã xóa sinh viên!";
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        // T?i l?i danh sách
        private async void btnTaiLai_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        // Ch?n sinh viên trên DataGridView
        private void dgvSinhVien_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSinhVien.Rows[e.RowIndex].DataBoundItem
                is Student sv)
            {
                txtHoTen.Text = sv.FullName;
                txtDiem.Text = sv.Grade.ToString();
            }
        }

        // Label tr?ng thái
        private void lblTrangThai_Click(object sender, EventArgs e)
        {
        }

        // LINQ - L?c sinh viên ??t
        private async void btnLocDat_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var ds = await db.Students
                        .AsNoTracking()
                        .Where(sv => sv.Grade >= 5)
                        .OrderByDescending(sv => sv.Grade)
                        .ToListAsync();

                    dgvSinhVien.DataSource = null;
                    dgvSinhVien.DataSource = ds;

                    lblTrangThai.Text =
                        $"Tìm th?y {ds.Count} sinh viên ??t (>= 5)";

                    lblTrangThai.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                BaoLoi(ex);
            }
        }

        // Ki?m tra d? li?u nh?p
        private bool KiemTraNhap(out double diem)
        {
            diem = 0;

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nh?p h? tên!");
                return false;
            }

            if (!double.TryParse(txtDiem.Text, out diem)
                || diem < 0 || diem > 10)
            {
                MessageBox.Show("?i?m ph?i t? 0 ??n 10!");
                return false;
            }

            return true;
        }

        // Hi?n th? thông báo l?i
        private void BaoLoi(Exception ex)
        {
            lblTrangThai.Text = "L?i: " + ex.Message;
            lblTrangThai.ForeColor = Color.Red;

            MessageBox.Show(ex.Message, "L?i");
        }

        // T? ??ng t?i sinh viên khi m? Form
        private async void Form1_Load(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }
    }
}
