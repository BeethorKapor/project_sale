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
    public partial class OrderMCustomerForm : Form
    {
        Connection Q = new Connection();
        SqlConnection conn = new SqlConnection("Data Source=BEETHOR\\SQLEXPRESS;Initial Catalog=Sales;Integrated Security=True");
        public OrderMCustomerForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm frmH = new MainForm();
            frmH.Show();
        }

        private void OrderMCustomerForm_Load(object sender, EventArgs e)
        {
            listViewOrder.Columns.Add("ລະຫັດສິນຄ້າ", 100, HorizontalAlignment.Center);
            listViewOrder.Columns.Add("ຊື່ສິນຄ້າ", 150, HorizontalAlignment.Center);
            listViewOrder.Columns.Add("ລາຄາ", 80, HorizontalAlignment.Center);
            listViewOrder.Columns.Add("ຈຳນວນ", 70, HorizontalAlignment.Center);
            listViewOrder.Columns.Add("ລາຄາທັງໜົດ", 100, HorizontalAlignment.Center);
            listViewOrder.View = View.Details;
            listViewOrder.GridLines = true;
            listViewOrder.FullRowSelect = true;
            txtProPrice.Text = "0";
            txtProAmount.Text = "0";
            txtTotalPrice.Text = "0";
        }

        private void txtCusID_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtCusID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEID_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtEID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProID_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtProID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCusID_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            if (txtCusID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select CusName from tb_Customer where CusID = @CusID", conn);
                cmd.Parameters.AddWithValue("@CusID", int.Parse(txtCusID.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtCusName.Text = da.GetValue(0).ToString();
                }

            }
            conn.Close();
        }

        private void txtEID_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            if (txtEID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select EmName, EmLName from tb_Employee where EmID = @EmID", conn);
                cmd.Parameters.AddWithValue("@EmID", int.Parse(txtEID.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtEmName.Text = da.GetValue(0).ToString();
                    txtEmLName.Text = da.GetValue(1).ToString();
                }

            }
            conn.Close();
        }

        private void txtProID_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            if (txtProID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select ProName, ProPrice from tb_Products where ProBarcode = @ProBarcode", conn);
                cmd.Parameters.AddWithValue("@ProBarcode", int.Parse(txtProID.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtProName.Text = da.GetValue(0).ToString();
                    txtProPrice.Text = da.GetValue(1).ToString();
                }
            }
            conn.Close();
        }

        private void txtProAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ClauteTotal()
        {
            double Total;
            Total = (double.Parse(txtProPrice.Text)) * int.Parse(txtProAmount.Text);
            txtTotalPrice.Text = Total.ToString("#,##0.00");
        }

        private void txtProAmount_TextChanged(object sender, EventArgs e)
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
            if ((txtProID.Text.Trim() == "") || (txtProPrice.Text.Trim() == ""))
            {
                txtProID.Focus();
                return;
            }
            if (int.Parse(txtProAmount.Text) == 0)
            {
                txtProAmount.Focus();
                return;
            }
            int i = 0;
            ListViewItem lvi;
            int tmpProductID = 0;
            for (i = 0; i < listViewOrder.Items.Count - 1; i++)
            {
                tmpProductID = int.Parse(listViewOrder.Items[i].SubItems[0].Text);
                if (int.Parse(txtProID.Text.Trim()) == tmpProductID)
                {
                    MessageBox.Show("ຂໍ້ມູນລາຍການສິນຄ້າຊໍ່າກັນ");
                    txtProID.Focus();
                    //txtProID.SelectAll();
                    txtProID.Clear();
                    txtProName.Clear();
                    txtProPrice.Text = "0";
                    txtProAmount.Text = "1";
                    txtTotalPrice.Text = "0";
                    return;

                }
            }

            string[] anydata;
            anydata = new string[]
            {
                txtProID.Text,
                txtProName.Text,
                txtProPrice.Text,
                txtProAmount.Text,
                txtTotalPrice.Text
            };
            lvi = new ListViewItem(anydata);
            listViewOrder.Items.Add(lvi);
            CalculateNet();
            btnSaveOrder.Enabled = true;
            txtProID.Focus();
            txtProID.SelectAll();
        }

        private void CalculateNet()
        {
            int i = 0;
            double tmpnetTotal = 0;
            for (i = 0; i <= listViewOrder.Items.Count - 1; i++)
            {
                tmpnetTotal += double.Parse(listViewOrder.Items[i].SubItems[4].Text);
            }
            txtTotalpayment.Text = tmpnetTotal.ToString("#,##0.00");
        }


        private void ChangeMoney()
        {
            double total;
            total = (int.Parse(txtApayment.Text)) - double.Parse(txtTotalpayment.Text);
            txtchang.Text = total.ToString("#,##0.00");
        }

        private void txtApayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ChangeMoney();
            }
            catch (Exception)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewOrder.SelectedItems)
            {
                listViewOrder.Items.Remove(item);
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i <= listViewOrder.Items.Count - 1; i++)
            {
                string eID, cID, pID, pName, pPrice, pAmount, ptotal, date;
                eID = txtEID.Text.ToString();
                cID = txtCusID.Text.ToString();
                pID = listViewOrder.Items[i].SubItems[0].Text;
                pName = listViewOrder.Items[i].SubItems[1].Text;
                pPrice = listViewOrder.Items[i].SubItems[2].Text;
                pAmount = listViewOrder.Items[i].SubItems[3].Text;
                ptotal = listViewOrder.Items[i].SubItems[4].Text;
                date = dateTimeOrder.Text;
                Q.Query("INSERT INTO tb_OrderMenber(EmID, CusID, ProBarcode, ProName, ProPrice, ProAmount, ProTotal, Date)" + "VALUES('" + eID + "', '" +
                    cID + "', '" + pID + "', N'" + pName + "', '" + pPrice + "', '" + pAmount + "', '" + ptotal + "', '" + date + "')");
                MessageBox.Show("ທ່ານໄດ້ບັນທຶກຂໍ້ມູນການຂາຍສິນຄ້າສຳເລັດແລ້ວ");
            }
        }
    }
}
