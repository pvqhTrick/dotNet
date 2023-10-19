using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Model;

namespace WindowsFormsApp
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
            LoadData();
        }
      

        private void picHinhDaiDien_Click(object sender, EventArgs e)
        {
            var openFileDialog =new OpenFileDialog
            {
                Title = "Chọn ảnh địa diện",
            };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                picHinhDaiDien.ImageLocation = fileName;
            }
        }

        void LoadData()
        {
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                var sinhvien = SinhVien.FromJson(json);
                if(sinhvien != null)
                {
                    txtMsv.Text = sinhvien.MaSinhVien;
                    txtHo.Text = sinhvien.Ho;
                    txtTen.Text = sinhvien.Ten;
                    txtNoiSinh.Text = sinhvien.NoiSinh;
                    dateNgaySinh.Value = sinhvien.NgaySinh;
                    cbbGioiTinh.SelectedIndex = (int)sinhvien.GioiTinh;
                    picHinhDaiDien.ImageLocation = sinhvien.HinhDaiDien;
                }
            }
        }

        string fileName = "sinhvien.json";
        private void btnDongY_Click(object sender, EventArgs e)
        {
            var sinhvien = new SinhVien
            {
                MaSinhVien = txtMsv.Text,
                Ho = txtHo.Text,
                Ten = txtTen.Text,
                NgaySinh = dateNgaySinh.Value,
                NoiSinh = txtNoiSinh.Text,
                GioiTinh = (GIOITINH) cbbGioiTinh.SelectedIndex,
                HinhDaiDien = picHinhDaiDien.ImageLocation
            };
            File.WriteAllText(fileName, sinhvien.ToString());
            MessageBox.Show("Đã lưu lữ liệu thành công","Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnBoQua_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }

