using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThongTinTaiKhoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int GetSelectedRow(String id)
        {
            for (int i = 0; i < lvInfos.Items.Count; i++)
            {
                if(lvInfos.Items[i].SubItems[1].Text == id)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int rowIndex)
        {
            lvInfos.Items[rowIndex].SubItems[1].Text = txtID.Text;
            lvInfos.Items[rowIndex].SubItems[2].Text = txtName.Text;
            lvInfos.Items[rowIndex].SubItems[3].Text = txtAddress.Text;
            lvInfos.Items[rowIndex].SubItems[4].Text = txtMoneyAmount.Text;
                        

            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtMoneyAmount.Text = "";
        }
        private void TotalMoneyCount()
        {
            long total = 0;
            for (int i = 0; i < lvInfos.Items.Count; i++)
            {
                total += long.Parse(lvInfos.Items[i].SubItems[4].Text);
            }
            txtTotalMoneyAmount.Text = total.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtMoneyAmount.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin tài khoản!");
                }
                if (long.Parse(txtMoneyAmount.Text) < 0)
                {
                    throw new Exception("Số tiền phải là số nguyên dương!");
                }
                int rowIndex = GetSelectedRow(txtID.Text);
                if (rowIndex == -1)
                {
                    ListViewItem item = new ListViewItem((lvInfos.Items.Count + 1).ToString());
                    item.SubItems.Add(txtID.Text);
                    item.SubItems.Add(txtName.Text);
                    item.SubItems.Add(txtAddress.Text);
                    item.SubItems.Add(txtMoneyAmount.Text);
                    lvInfos.Items.Add(item);
                    txtID.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtMoneyAmount.Text = "";
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    InsertUpdate(rowIndex);
                }
                TotalMoneyCount();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho Số tiền!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = GetSelectedRow(txtID.Text);
                {
                    if (rowIndex == -1)
                    {
                        throw new Exception("Không tìm thấy tài khoản với ID đã nhập!");
                    }
                    else
                    {
                        DialogResult rs = MessageBox.Show("Xác nhận xóa dữ liệu? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            lvInfos.Items.RemoveAt(rowIndex);
                            for (int i = 0; i < lvInfos.Items.Count; i++)
                            {
                                lvInfos.Items[i].SubItems[0].Text = (i + 1).ToString();
                            }
                            txtID.Text = "";
                            txtName.Text = "";
                            txtAddress.Text = "";
                            txtMoneyAmount.Text = "";
                            MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    TotalMoneyCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvInfos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvInfos.SelectedItems.Count > 0)
            {
                ListViewItem item = lvInfos.SelectedItems[0];
                txtID.Text = item.SubItems[1].Text;
                txtName.Text = item.SubItems[2].Text;
                txtAddress.Text = item.SubItems[3].Text;
                txtMoneyAmount.Text = item.SubItems[4].Text;
            }
        }
    }   
}
