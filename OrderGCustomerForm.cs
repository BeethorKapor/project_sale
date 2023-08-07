using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace projectsales
{
    public partial class OrderGCustomerForm : Form
    {
        Connection Q = new Connection();
        SqlConnection conn = new SqlConnection("Data Source=BEETHOR\\SQLEXPRESS;Initial Catalog=Sales;Integrated Security=True");
        public OrderGCustomerForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm frmH = new MainForm();
            frmH.Show();
        }

        private void OrderGCustomerForm_Load(object sender, EventArgs e)
        {
            listViewOrG.Columns.Add("ລະຫັດສິນຄ້າ", 100, HorizontalAlignment.Center);
            listViewOrG.Columns.Add("ຊື່ສິນຄ້າ", 150, HorizontalAlignment.Center);
            listViewOrG.Columns.Add("ລາຄາ", 80, HorizontalAlignment.Center);
            listViewOrG.Columns.Add("ຈຳນວນ", 70, HorizontalAlignment.Center);
            listViewOrG.Columns.Add("ລາຄາທັງໜົດ", 100, HorizontalAlignment.Center);
            listViewOrG.View = View.Details;
            listViewOrG.GridLines = true;
            listViewOrG.FullRowSelect = true;
            txtPPrice.Text = "0";
            txtAmount.Text = "0";
            txtTotal.Text = "0";
        }

        private void txtEid_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtEid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPID_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtAmount_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        

        private void txtEid_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            if (txtEid.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select EmName, EmLName from tb_Employee where EmID = @EmID", conn);
                cmd.Parameters.AddWithValue("@EmID", int.Parse(txtEid.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtEName.Text = da.GetValue(0).ToString();
                    txtLastName.Text = da.GetValue(1).ToString();
                }

            }
            conn.Close();
        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            if (txtPID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select ProName, ProPrice from tb_Products where ProBarcode = @ProBarcode", conn);
                cmd.Parameters.AddWithValue("@ProBarcode", int.Parse(txtPID.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtPName.Text = da.GetValue(0).ToString();
                    txtPPrice.Text = da.GetValue(1).ToString();
                }
                //conn.Close();
            }
            conn.Close();
        }

        private void ClauteTotal()
        {
            double Total;
            Total = (double.Parse(txtPPrice.Text)) * int.Parse(txtAmount.Text);
            txtTotal.Text = Total.ToString("#,##0.00");
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClauteTotal();
            }
            catch (Exception)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtPID.Text.Trim() == "") || (txtPPrice.Text.Trim() == ""))
            {
                txtPID.Focus();
                return;
            }
            if (int.Parse(txtAmount.Text) == 0)
            {
                txtAmount.Focus();
                return;
            }
            int i = 0;
            ListViewItem lvi;
            int tmpProductID = 0;
            for (i = 0; i < listViewOrG.Items.Count - 1; i++)
            {
                tmpProductID = int.Parse(listViewOrG.Items[i].SubItems[0].Text);
                if (int.Parse(txtPID.Text.Trim()) == tmpProductID)
                {
                    MessageBox.Show("ຂໍ້ມູນລາຍການສິນຄ້າຊໍ່າກັນ");
                    txtPID.Focus();
                    //txtProID.SelectAll();
                    txtPID.Clear();
                    txtPName.Clear();
                    txtPPrice.Text = "0";
                    txtAmount.Text = "1";
                    txtTotal.Text = "0";
                    return;

                }
            }

            string[] anydata;
            anydata = new string[]
            {
                txtPID.Text,
                txtPName.Text,
                txtPPrice.Text,
                txtAmount.Text,
                txtTotal.Text
            };
            lvi = new ListViewItem(anydata);
            listViewOrG.Items.Add(lvi);
            CalculateNet();
            btnSave.Enabled = true;
            txtPID.Focus();
            txtPID.SelectAll();
        }

        private void CalculateNet()
        {
            int i = 0;
            double tmpnetTotal = 0;
            for (i = 0; i <= listViewOrG.Items.Count - 1; i++)
            {
                tmpnetTotal += double.Parse(listViewOrG.Items[i].SubItems[4].Text);
            }
            txtTotalPayment.Text = tmpnetTotal.ToString("#,##0.00");
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewOrG.SelectedItems)
            {
                listViewOrG.Items.Remove(item);
            }
        }

        private void ChangeMoney()
        {
            double total;
            total = (int.Parse(txtAMoney.Text)) - double.Parse(txtTotalPayment.Text);
            txtChange.Text = total.ToString("#,##0.00");
        }

        private void txtAMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ChangeMoney();
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i <= listViewOrG.Items.Count - 1; i++)
            {
                string eID, pID, pName, pPrice, pAmount, ptotal, date;
                eID = txtEid.Text.ToString();
                //cID = txtCusID.Text.ToString();
                pID = listViewOrG.Items[i].SubItems[0].Text;
                pName = listViewOrG.Items[i].SubItems[1].Text;
                pPrice = listViewOrG.Items[i].SubItems[2].Text;
                pAmount = listViewOrG.Items[i].SubItems[3].Text;
                ptotal = listViewOrG.Items[i].SubItems[4].Text;
                date = dateTimeG.Text;
                Q.Query("INSERT INTO tb_OrderGeneral(EmID, ProBarcode, ProName, ProPrice, ProAmount, ProTotal, Date)" + "VALUES('" + eID + "', '" +
                    pID + "', N'" + pName + "', '" + pPrice + "', '" + pAmount + "', '" + ptotal + "', '" + date + "')");
                MessageBox.Show("ທ່ານໄດ້ບັນທຶກຂໍ້ມູນການຂາຍສິນຄ້າສຳເລັດແລ້ວ");
            }
        }
    }
}
