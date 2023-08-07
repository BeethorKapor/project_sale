using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectsales
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnHome_CheckedChanged(object sender, EventArgs e)
        {
            UserControlsForm.HomeOrder c = new UserControlsForm.HomeOrder();
            AddControl(c);
            setTitle("ໜ້າຫຼັກ");
        }

        void setTitle(string title)
        {
            labelTitle.Text = "ຮ້ານຂາຍສິນຄ້າ: [" + title.ToString() + "]";
        }

        private void btnProduct_CheckedChanged(object sender, EventArgs e)
        {
            UserControlsForm.UCProduct c = new UserControlsForm.UCProduct();
            AddControl(c);
            setTitle(btnProduct.Text.ToString());
        }

        private void btnCustomer_CheckedChanged(object sender, EventArgs e)
        {
            UserControlsForm.UCCustoner c = new UserControlsForm.UCCustoner();
            AddControl(c);
            setTitle(btnCustomer.Text.ToString());
        }

        private void btnEmployee_CheckedChanged(object sender, EventArgs e)
        {
            UserControlsForm.UCEmployee c = new UserControlsForm.UCEmployee();
            AddControl(c);
            setTitle(btnEmployee.Text.ToString());
        }

        private void btnSetting_CheckedChanged(object sender, EventArgs e)
        {
            setTitle(btnSetting.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void AddControl(UserControl c)
        {
            c.Dock = DockStyle.Fill;
            panelUserContorl.Controls.Clear();
            panelUserContorl.Controls.Add(c);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserControlsForm.HomeOrder c = new UserControlsForm.HomeOrder();
            AddControl(c);
        }
    }
}
