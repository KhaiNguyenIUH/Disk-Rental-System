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
        private void setComboDataSource()
        {
            cboTittle.DataSource = null;
            rent = new DiskRentalDataContext();
            cboTittle.DataSource = rent.Tittles;
            cboTittle.DisplayMember = "TittleName";
            cboTittle.ValueMember = "TittleID";
            cboTittle.Refresh();

        }

        private void movieBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void ListDisk_Load(object sender, EventArgs e)
        {
            setComboDataSource();
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
        }
    }
}
