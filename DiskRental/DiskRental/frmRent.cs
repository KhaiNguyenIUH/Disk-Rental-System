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
        private void setComboDataSource()
        {
            rent = new DiskRentalDataContext();
            customer_ComboBox.DataSource = null;
            customer_ComboBox.DataSource = rent.Customers;
            customer_ComboBox.DisplayMember = "CustomerID";
            customer_ComboBox.ValueMember = "CustomerID";
            customer_ComboBox.Refresh();
            cboTittle.DataSource = null;
            cboTittle.DataSource = rent.Tittles;
            cboTittle.DisplayMember = "TittleName";
            cboTittle.ValueMember = "TittleID";
            cboTittle.Refresh();

        }

        private void frmRent_Load(object sender, EventArgs e)
        {
            setComboDataSource();   
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void customer_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customer_ComboBox.SelectedItem != null)
            {
                Customer pb = (Customer)customer_ComboBox.SelectedItem;
                loadCustoTextview(pb);
            }
        }
        private void loadCustoTextview(Customer pb)
        {
            var nvCol = rent.Customers.Where(nv => nv.CustomerID == pb.CustomerID).FirstOrDefault();
            txtName.Text = nvCol.CustomerName; 
        }

        private void cboTittle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTittle.SelectedItem != null)
            {
                Tittle pb = (Tittle)cboTittle.SelectedItem;
                loadNStoGridView(pb);
            }
        }
        private void loadNStoGridView(Tittle pb)
        {
            var nvCol = rent.Disks.Where(nv => nv.TittleID == pb.TittleID);
            movieDataGridView.DataSource = nvCol;
            var nvCol2 = rent.Tittles.Where(nv => nv.TittleID == pb.TittleID).FirstOrDefault();
            txtCost.Text = nvCol2.Cost.ToString();
        }
        private void loaddistoGridView(int pb)
        {
            var nvCol3 = rent.RentDetails.Where(nv => nv.RentID == pb);
            dataGridView1.DataSource = nvCol3;           
        }
        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            if (invoiceNoTextBox.Text != "" )
            {
                try
                {
                    rent = new DiskRentalDataContext();
                    RentInfo r = new RentInfo();
                    r.RentID = Int32.Parse(invoiceNoTextBox.Text);
                    r.RentDate = DateTime.Now;
                    r.ReturnDate = dateTimePicker1.Value;
                    r.CustomerID = Int32.Parse(customer_ComboBox.SelectedValue.ToString());                   
                    rent.RentInfos.InsertOnSubmit(r);
                    rent.SubmitChanges();
                    MessageBox.Show("Success!");
                    movieDataGridView.Enabled = true;
                    movieDataGridView.Visible = true;
                    dataGridView1.Enabled = true;
                    dataGridView1.Visible = true;
                    btnChon.Visible = true;
                    btnNewInvoice.Enabled = false;
                }
                catch(Exception ee)
                {
                    MessageBox.Show("Duplicate ID or wrong formatting");
                    invoiceNoTextBox.Clear();
                    invoiceNoTextBox.Focus();
                }
            }
                 
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                rent = new DiskRentalDataContext();
                RentDetail r = new RentDetail();
                r.RentID = Int32.Parse(invoiceNoTextBox.Text);
                r.DiskID = Int32.Parse(textBox1.Text);
                var dis= rent.Disks.Where(nv => nv.DiskID == Int32.Parse(textBox1.Text)).FirstOrDefault();
                dis.DiskStatus = "Not Available";
                rent.RentDetails.InsertOnSubmit(r);
                rent.SubmitChanges();
                loaddistoGridView(Int32.Parse(invoiceNoTextBox.Text));     
                rse += Decimal.Parse(txtCost.Text);
                cashTextBox.Text = rse.ToString();
            }
            catch
            {
                MessageBox.Show("Đĩa trùng");
            }
        }
        private void GetDiskID(DataGridViewRow dtr)
        {
            textBox1.Text = dtr.Cells[0].Value.ToString();        
        }

        private void movieDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dtr = movieDataGridView.CurrentRow;
            if (dtr != null && !dtr.IsNewRow)
            {
                GetDiskID(dtr);             
            }
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
            btnNewInvoice.Enabled = true;
            movieDataGridView.Enabled = false;
            movieDataGridView.Visible = false;
            dataGridView1.Enabled = false;
            dataGridView1.Visible = false;
            btnChon.Visible = false;
            dataGridView1.DataSource = null;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            rent = new DiskRentalDataContext();
            try
            {
                var u = rent.RentInfos.Where(b => b.CustomerID == Int32.Parse(customer_ComboBox.SelectedValue.ToString()) && b.LateFee != null).FirstOrDefault();
                DialogResult dialogResult = MessageBox.Show("Fee: " + u.LateFee.ToString(), "Thanh Toán phí trễ hạn", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    rent = new DiskRentalDataContext();
                    var y = rent.RentInfos.Where(b => b.CustomerID == Int32.Parse(customer_ComboBox.SelectedValue.ToString()) && b.LateFee != null).FirstOrDefault();
                    y.LateFee = null;
                    rent.SubmitChanges();
                    MessageBox.Show("Thanh toán thành công");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Phải thanh toán để tiếp tục");
                }
            }
            catch
            {
                MessageBox.Show("Thanh toán đầy đủ");
            }
        }
    }
}
