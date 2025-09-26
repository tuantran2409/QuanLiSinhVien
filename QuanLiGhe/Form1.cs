using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiGhe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grbBtnSeat_Enter(object sender, EventArgs e)
        {

        }

        private void btnChooseASeat(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Green;
            }
            else if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.White;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateTemporaryTotal();
        }
        private int GetSeatPrice(int seatNumber)
        {
            if (seatNumber >= 1 && seatNumber <= 5)
            {
                return 30000;
            }
            if (seatNumber >= 6 && seatNumber <= 10)
            {
                return 40000;
            }
            if (seatNumber >= 11 && seatNumber <= 15)
            {
                return 50000;
            }
            return 80000;
        }
        public void UpdateTemporaryTotal()
        {
            int total = 0;
            foreach (Control c in grbBtnSeat.Controls)
            {
                if (c is Button && c.Name.StartsWith("btn"))
                {
                    Button seat = (Button)c;
                    if (seat.BackColor == Color.Green)
                    {
                        int seatNumber = int.Parse(seat.Text);
                        total += GetSeatPrice(seatNumber);
                    }
                }
            }
            txtTotal.Text = $"{total:N0}₫";
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int total = 0;
            string selectedSeats = "";

            foreach (Control c in grbBtnSeat.Controls)
            {
                if (c is Button && c.Name.StartsWith("btn"))
                {
                    Button seat = (Button)c;
                    if (seat.BackColor == Color.Green)
                    {
                        int seatNumber = int.Parse(seat.Text);
                        total += GetSeatPrice(seatNumber);
                        selectedSeats += seatNumber + " ";
                        seat.BackColor = Color.Yellow; 
                    }
                }
            }

            if (total > 0)
            {
                MessageBox.Show(
                    $"Bạn đã đặt các ghế: {selectedSeats}\nTổng tiền: {total:N0}₫",
                    "Xác nhận mua vé",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!", "Thông báo");
            }

            UpdateTemporaryTotal();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach(Control c in grbBtnSeat.Controls)
            {
                if (c is Button && c.Name.StartsWith("btn"))
                {
                    Button seat = (Button)c;
                    if (seat.BackColor == Color.Green)
                    {
                        seat.BackColor = Color.White; // hủy chọn
                    }
                }
            }
            UpdateTemporaryTotal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) 
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
