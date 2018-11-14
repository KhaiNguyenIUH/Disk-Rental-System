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
    public partial class ListDisk : Form
    {
        DiskRentalDataContext rent;
        public ListDisk()
        {
            InitializeComponent();          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            this.panel1.Controls.Clear();
            frmRent dk = new frmRent();
            dk.TopLevel = false;
            this.panel1.Controls.Add(dk);
            dk.Show();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            frmReturn dk = new frmReturn();
            dk.TopLevel = false;
            this.panel1.Controls.Add(dk);
            dk.Show();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

    }
}
