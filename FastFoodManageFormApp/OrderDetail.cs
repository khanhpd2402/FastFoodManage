using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodFormApp
{
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            InitializeComponent();
        }

        private void LogoPb_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            this.Hide();
            homeFrm.Show();
        }

        private void BackListLb_Click(object sender, EventArgs e)
        {
            ListOrdersFrm listOrdersFrm = new ListOrdersFrm();
            this.Hide();
            listOrdersFrm.Show();
        }

        private void BackListPb_Click(object sender, EventArgs e)
        {
            ListOrdersFrm listOrdersFrm = new ListOrdersFrm();
            this.Hide();
            listOrdersFrm.Show();
        }
    }
}
