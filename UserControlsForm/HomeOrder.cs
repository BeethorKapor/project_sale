using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectsales.UserControlsForm
{
    public partial class HomeOrder : UserControl
    {
        public HomeOrder()
        {
            InitializeComponent();
        }

        private void btnMCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderMCustomerForm frmM = new OrderMCustomerForm();
            frmM.Show();
        }

        private void btnGCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderGCustomerForm frmG = new OrderGCustomerForm();
            frmG.Show();
        }
    }
}
