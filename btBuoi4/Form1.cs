using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btBuoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFaculty.SelectedIndex = 0;
            optFemale.Checked = true;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.AllowUserToAddRows = false;
            UpdateGenderCount();
        }

        private int GetSelectedRow(String studentID)
        {
            for(int i=0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int rowIndex)
        {
            dgvStudent.Rows[rowIndex].Cells[0].Value = txtStudentID.Text;
            dgvStudent.Rows[rowIndex].Cells[1].Value = txtFullName.Text;
            dgvStudent.Rows[rowIndex].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[rowIndex].Cells[3].Value = double.Parse(txtAverageScore.Text);
            dgvStudent.Rows[rowIndex].Cells[4].Value = cmbFaculty.SelectedItem.ToString();
            txtFullName.Text = "";
            txtAverageScore.Text = "";
            txtStudentID.Text = "";
            cmbFaculty.SelectedIndex = 0;
            optFemale.Checked = true;
        }
        private void UpdateGenderCount()
        {
            int maleCount = 0;
            int femaleCount = 0;
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    maleCount++;
                }
                else
                {
                    femaleCount++;
                }
            }
            txtFemaleCount.Text = femaleCount.ToString();
            txtMaleCount.Text = maleCount.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtStudentID.Text == "" || txtFullName.Text == "" || txtAverageScore.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                    return;
                }
                if(double.Parse(txtAverageScore.Text) < 0 || double.Parse(txtAverageScore.Text) > 10)
                {
                    throw new Exception("Điểm trung bình phải từ 0 đến 10!");
                    return;
                }
                
                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if(selectedRow == -1)
                {
                    dgvStudent.Rows.Add
                        (
                            txtStudentID.Text,
                            txtFullName.Text,
                            optFemale.Checked ? "Nữ" : "Nam",
                            double.Parse(txtAverageScore.Text),
                            cmbFaculty.SelectedItem.ToString()                           
                        );
                    txtFullName.Text = "";
                    txtAverageScore.Text = "";
                    txtStudentID.Text = "";
                    cmbFaculty.SelectedIndex = 0;
                    optFemale.Checked = true;
                    MessageBox.Show("Thêm mới dữ liệu thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                UpdateGenderCount();
            }
            catch (FormatException)
            {
                MessageBox.Show("Điểm trung bình phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Mã sinh viên không tồn tại!");
                    return;
                }
                DialogResult rs = MessageBox.Show("Xác nhận xóa dữ liệu? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    dgvStudent.Rows.RemoveAt(selectedRow);
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGenderCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtFullName.Text = row.Cells[1].Value.ToString();
                if(row.Cells[2].Value.ToString() == "Nữ")
                {
                    optFemale.Checked = true;
                }
                else
                {
                    optMale.Checked = true;
                }
                txtAverageScore.Text = row.Cells[3].Value.ToString();
                cmbFaculty.SelectedItem = row.Cells[4].Value.ToString();
            }
        }
    }
}
