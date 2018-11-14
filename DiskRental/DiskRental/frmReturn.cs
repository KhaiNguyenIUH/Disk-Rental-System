using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskRental
{
    public partial class frmReturn : Form
    {
        DiskRentalDataContext rent;
        public frmReturn()
        {
            InitializeComponent();
        }      
        /*
         * Tìm kiếm thông tin của disk trong 2 bảng Info và Detail
         */
        private void SearchDisk(int id)
        {
            rent = new DiskRentalDataContext();
            var v = (from r in rent.RentDetails
                     join a in rent.RentInfos on r.RentID equals a.RentID
                     where r.DiskID == id
                     select new
                     {
                         a.RentDate,
                         r.ReturnDate
                     });
            foreach (var x in v)
            {
                if (x.RentDate!=null)
                {
                    txtTime.Text = x.RentDate.ToString();
                }
                else
                    txtTime.Text = "Không tìm thấy thông tin";
            }
        }
        /*
         * Tìm disk có cùng RentID
         */
         private void SearchSameDisk(int id)
        {
            rent = new DiskRentalDataContext();
            var g = rent.RentDetails.Where(b => b.RentID == id);
            dataGridView1.DataSource = g;
        }
        /*
         * Tìm thông tin Disk khi nhập id vào textbox
         */
        private void txtDiskID_TextChanged(object sender, EventArgs e)
        {
            txtTime.Text = "";
            try
            {
                SearchDisk(Int32.Parse(txtDiskID.Text));
                //searchcus();
            }
            catch
            {
                
            }            
        }
        private void CheckStatusDisk(int id)
        {
            rent = new DiskRentalDataContext();
            try
            {
                var tra = rent.RentDetails.Where(b => b.DiskID == id && b.ReturnDate == null).FirstOrDefault();
                tra.ReturnDate = dateTimePicker1.Value;
                var dis = rent.Disks.Where(nv => nv.DiskID == id).FirstOrDefault();
                dis.DiskStatus = "Available";
                rent.SubmitChanges();
                CalDays(Int32.Parse(txtDiskID.Text));
                CalLateFee();                
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Đĩa đã được trả");
            }
        }
        public void CalDays(int ma)
        {
            rent = new DiskRentalDataContext();
            var v = (from r in rent.RentDetails
                     join a in rent.RentInfos on r.RentID equals a.RentID
                     where r.DiskID == ma
                     select new
                     {
                         a.RentID,
                         r.DiskID,
                         a.RentDate,
                         r.ReturnDate
                     });
            foreach (var x in v)
            {
                if (x.RentDate != null)
                {
                    txtTime.Text = x.RentDate.ToString();
                    textBox2.Text = x.RentID.ToString();
                }
            }
            DateTime futurDate = DateTime.Parse(txtTime.Text);
            DateTime TodayDate = dateTimePicker1.Value;
            var numberOfDays = (TodayDate - futurDate).Days;
            textBox3.Text = numberOfDays.ToString();
        }
        public void CalLateFee()
        {
            if (Int32.Parse(textBox3.Text) > 7)
            {
                rent = new DiskRentalDataContext();
                var u = rent.RentInfos.Where(b => b.RentID == Int32.Parse(textBox2.Text)).FirstOrDefault();
                u.LateFee = Decimal.Parse("10000");
                DialogResult dialogResult = MessageBox.Show("Fee: " + u.LateFee.ToString(), "Thanh Toán phí trễ hạn", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Thanh toán thành công");
                }
                else if (dialogResult == DialogResult.No)
                {
                    rent = new DiskRentalDataContext();
                    var y = rent.RentInfos.Where(b => b.RentID == Int32.Parse(textBox2.Text)).FirstOrDefault();
                    y.LateFee = Decimal.Parse(u.LateFee.ToString());
                    rent.SubmitChanges();
                }
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CheckStatusDisk(Int32.Parse(txtDiskID.Text));
            txtDiskID.Clear();
            txtTime.Text = "";
        }
        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            if (txtTime.Text != "")               
                btnConfirm.Enabled = true;
            else
                btnConfirm.Enabled = false;
        }
        private void txtRentID_TextChanged(object sender, EventArgs e)
        {
            lblTime.Text = "";
            try
            {
                SearchRentInfo(Int32.Parse(txtRentID.Text));
            }
            catch
            {

            }
        }
        private void SearchRentInfo(int id)
        {
            rent = new DiskRentalDataContext();
            var v = (from r in rent.RentDetails
                     join a in rent.RentInfos on r.RentID equals a.RentID
                     where r.RentID == id
                     select new
                     {
                         a.RentDate
                     });
            foreach (var x in v)
            {
                if (x.RentDate != null)
                {
                    lblTime.Text = x.RentDate.ToString();
                }
                else
                    txtTime.Text = "Không tìm thấy thông tin";
            }
        }

        private void lblTime_TextChanged(object sender, EventArgs e)
        {
            if (lblTime.Text != "")
                btnCheck.Enabled = true;
            else
                btnCheck.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SearchSameDisk(Int32.Parse(txtRentID.Text));
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dtr = dataGridView1.CurrentRow;
            if (dtr != null && !dtr.IsNewRow)
            {
                GetDiskID(dtr);
            }
        }
        private void GetDiskID(DataGridViewRow dtr)
        {
            textBox1.Text = dtr.Cells[1].Value.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CheckStatusDisk2(int id)
        {
            rent = new DiskRentalDataContext();
            try
            {
                var tra = rent.RentDetails.Where(b => b.DiskID == id && b.ReturnDate == null).FirstOrDefault();
                tra.ReturnDate = dateTimePicker2.Value;
                var dis = rent.Disks.Where(nv => nv.DiskID == id).FirstOrDefault();
                dis.DiskStatus = "Available";
                rent.SubmitChanges();
                CalDays(Int32.Parse(textBox1.Text));
                CalLateFee();
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Đĩa đã được trả");
            }
        }
        public void CalDays2(int ma)
        {
            rent = new DiskRentalDataContext();
            var v = (from r in rent.RentDetails
                     join a in rent.RentInfos on r.RentID equals a.RentID
                     where r.DiskID == ma
                     select new
                     {
                         r.DiskID,
                         a.RentDate,
                         r.ReturnDate
                     });
            foreach (var x in v)
            {
                if (x.RentDate != null)
                {
                    lblTime.Text = x.RentDate.ToString();
                }
            }
            DateTime futurDate = DateTime.Parse(txtTime.Text);
            DateTime TodayDate = dateTimePicker1.Value;
            var numberOfDays = (TodayDate - futurDate).Days;
            textBox4.Text = numberOfDays.ToString();
        }
        public void CalLateFee2(int id)
        {
            if (Int32.Parse(textBox3.Text) > 7)
            {
                rent = new DiskRentalDataContext();
                var u = rent.RentInfos.Where(b => b.RentID == id).FirstOrDefault();
                u.LateFee = Decimal.Parse("10000");
                DialogResult dialogResult = MessageBox.Show("Fee: " + u.LateFee.ToString(), "Thanh Toán phí trễ hạn", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Thanh toán thành công");
                }
                else if (dialogResult == DialogResult.No)
                {
                    rent = new DiskRentalDataContext();
                    var y = rent.RentInfos.Where(b => b.RentID == Int32.Parse(textBox2.Text)).FirstOrDefault();
                    y.LateFee = Decimal.Parse(u.LateFee.ToString());
                    rent.SubmitChanges();
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            CheckStatusDisk2(Int32.Parse(textBox1.Text));
            SearchSameDisk(Int32.Parse(txtRentID.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
