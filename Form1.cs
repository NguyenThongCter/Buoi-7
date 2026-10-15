using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm đọc và tự tạo dữ liệu mẫu nếu CSDL rỗng
        public async Task<List<Student>> LayDanhSachAsync()
        {
            using (var context = new AppDbContext())
            {
                // Kiểm tra nếu chưa có dữ liệu thì tự thêm 3 sinh viên mẫu
                if (!await context.Students.AnyAsync())
                {
                    context.Students.AddRange(
                        new Student { FullName = "truc", Grade = 5 },
                        new Student { FullName = "hoa", Grade = 9 },
                        new Student { FullName = "teo", Grade = 6 }
                    );
                    await context.SaveChangesAsync();
                }

                return await context.Students.ToListAsync();
            }
        }

        // Tên phương thức khớp 100% với file Designer (có từ khóa async)
        private async void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var students = await LayDanhSachAsync();
                dataGridView1.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}