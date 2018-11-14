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
    public partial class frmRent : Form
    {
        DiskRentalDataContext rent;
        decimal rse = 0;
        public frmRent()
        {
            InitializeComponent();
        }
        private void frmRent_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void txtCusID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rent = new DiskRentalDataContext();
                var nvCol = rent.Customers.Where(nv => nv.CustomerID == Int32.Parse(txtCusID.Text)).FirstOrDefault();
                txtName.Text = nvCol.CustomerName;
            }
            catch
            {
                txtName.Clear();
            }
        }

        private void loaddistoGridView(int pb)
        {
            var nvCol3 = rent.RentDetails.Where(nv => nv.RentID == pb);
            dataGridView1.DataSource = nvCol3;           
        }
        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            if (invoiceNoTextBox.Text != "" && txtName.Text !="")
            {
                try
                {
                    rent = new DiskRentalDataContext();
                    RentInfo r = new RentInfo();
                    r.RentID = Int32.Parse(invoiceNoTextBox.Text);
                    r.RentDate = DateTime.Now;
                    r.ReturnDate = dateTimePicker1.Value;
                    r.CustomerID = Int32.Parse(txtCusID.Text);                   
                    rent.RentInfos.InsertOnSubmit(r);
                    rent.SubmitChanges();
                    MessageBox.Show("Success!");
                    dataGridView1.Enabled = true;
                    dataGridView1.Visible = true;
                    btnChon.Visible = true;
                    btnNewInvoice.Enabled = false;
                    btnNewInvoice.Enabled = false;
                }
                catch(Exception )
                {
                    MessageBox.Show("Trùng mã hoặc sai kiểu dữ liệu");
                    invoiceNoTextBox.Clear();
                    invoiceNoTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy CusID");
                txtCusID.Clear();
                txtCusID.Focus();
            }
            
                 
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                rent = new DiskRentalDataContext();
                RentDetail r = new RentDetail();
                r.RentID = Int32.Parse(invoiceNoTextBox.Text);
                r.DiskID = Int32.Parse(txtDiskID.Text);
                var dis= rent.Disks.Where(nv => nv.DiskID == Int32.Parse(txtDiskID.Text)).FirstOrDefault();
                dis.DiskStatus = "Not Available";
                rent.RentDetails.InsertOnSubmit(r);
                rent.SubmitChanges();
                loaddistoGridView(Int32.Parse(invoiceNoTextBox.Text));     
                rse += Decimal.Parse(txtCost.Text);
                cashTextBox.Text = rse.ToString();
                btnChon.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Đĩa trùng");
            }
        }
        private void GetDiskID(DataGridViewRow dtr)
        {
            txtDiskID.Text = dtr.Cells[0].Value.ToString();        
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            rent = new DiskRentalDataContext();
            var dis = rent.RentInfos.Where(nv => nv.RentID == Int32.Parse(invoiceNoTextBox.Text)).FirstOrDefault();
            dis.RentCost = Decimal.Parse(cashTextBox.Text);
            rent.SubmitChanges();
            invoiceNoTextBox.Focus();
            btnChon.Enabled = true;
            invoiceNoTextBox.Clear();
            cashTextBox.Clear();
            btnNewInvoice.Enabled = false;
            txtTitle.Clear();
            txtCost.Clear();
            txtDes.Clear();
            txtCusID.Clear();
            txtDiskID.Clear();
            btnChon.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridView1.Visible = false;
            dataGridView1.DataSource = null;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            rent = new DiskRentalDataContext();
            if(txtCusID.Text!="")
            {
                try
                {
                    var u = rent.RentInfos.Where(b => b.CustomerID == Int32.Parse(txtCusID.Text) && b.LateFee != null).FirstOrDefault();
                    DialogResult dialogResult = MessageBox.Show("Phí: " + u.LateFee.ToString(), "Thanh Toán phí trễ hạn", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        rent = new DiskRentalDataContext();
                        var y = rent.RentInfos.Where(b => b.CustomerID == Int32.Parse(txtCusID.Text) && b.LateFee != null).FirstOrDefault();
                        y.LateFee = null;
                        rent.SubmitChanges();
                        MessageBox.Show("Thanh toán thành công");
                        btnNewInvoice.Enabled = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Phải thanh toán để tiếp tục");
                        btnNewInvoice.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy thông tin phí trễ");
                    btnNewInvoice.Enabled = true;
                }
            }

        }

        private void txtDiskID_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void btnCheckDisk_Click(object sender, EventArgs e)
        {
            try
            {
                rent = new DiskRentalDataContext();
                var v = (from r in rent.Disks
                         join a in rent.Tittles on r.TittleID equals a.TittleID
                         where r.DiskID == Int32.Parse(txtDiskID.Text)
                         select new
                         {
                             r.DiskID,
                             a.TittleName,
                             a.Cost,
                             a.TittleDescription
                         }).FirstOrDefault();
                txtTitle.Text = v.TittleName.ToString();
                txtCost.Text = v.Cost.ToString();
                txtDes.Text = v.TittleDescription.ToString();
                btnChon.Enabled = true;
            }
            catch
            {
                txtTitle.Clear();
                txtCost.Clear();
                txtDes.Clear();
                btnChon.Enabled = false;
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
