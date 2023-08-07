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

namespace projectsales.UserControlsForm
{
    public partial class UCProduct : UserControl
    {
        Connection Q = new Connection();
        public UCProduct()
        {
            InitializeComponent();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ShowDataProducts()
        {
            try
            {
                string str = "Select * from tb_Products";
                SqlCommand cmd = new SqlCommand(str, Q.Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewProduct.DataSource = dt;

            }
            catch (Exception)
            {

            }
        }

        private void ClearDataProduct()
        {
            txtBarcode.Clear();
            txtProname.Clear();
            txtPrice.Clear();
            txtAmount.Clear();
            txtUnit.Clear();
            txtType.Clear();
            txtBarcode.Focus();
        }

        private void UCProduct_Load(object sender, EventArgs e)
        {
            ShowDataProducts();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtProname_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtUnit_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtType_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtBarcode_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtProname_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo la = new CultureInfo("LO-LA");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
        }

        private void txtPrice_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtAmount_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtUnit_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo la = new CultureInfo("LO-LA");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
        }

        private void txtType_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo la = new CultureInfo("LO-LA");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String Id, name, price, amount, type, unit;
            Id = txtBarcode.Text.ToString();
            name = txtProname.Text.ToString();
            price = txtPrice.Text.ToString();
            amount = txtAmount.Text.ToString();
            type = txtType.Text.ToString();
            unit = txtUnit.Text.ToString();
            Q.Query("insert into tb_Products(ProBarcode, ProName, ProPrice, ProAmount, ProUnit, ProType) " +
                "values ('" + Id + "',N'" + name + "', '" + price + "', '" + amount + "', N'" + unit + "', N'" + type + "')");

            MessageBox.Show("ທ່ານເພີ່ມຂໍ້ມູນສຳເລັດ");
            ShowDataProducts();
            ClearDataProduct();
        }

        private void dataGridViewProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtBarcode.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProname.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAmount.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtUnit.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtType.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String Id, name, price, amount, type, unit;
            Id = txtBarcode.Text.ToString();
            name = txtProname.Text.ToString();
            price = txtPrice.Text.ToString();
            amount = txtAmount.Text.ToString();
            type = txtType.Text.ToString();
            unit = txtUnit.Text.ToString();
            Q.Query("UPDATE tb_Products SET ProName = N'" + name + "', ProPrice = '" + price + "', ProAmount = '" +
                amount + "', ProUnit = N'" + unit + "', ProType = N'" + type + "' WHERE ProBarcode = '" + Id + "'");
            MessageBox.Show("ທ່ານໄດ້ແກ້ໄຂຂໍ້ມູນສຳເລັດແລ້ວ");
            ShowDataProducts();
            ClearDataProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Id;
            Id = txtBarcode.Text.ToString();
            Q.Query("DELETE FROM tb_Products WHERE ProBarcode = '" + Id + "'");
            MessageBox.Show("ທ່ານລຶບຂໍມູນສິນຄ້າສຳເລັດແລ້ວ");
            ShowDataProducts();
            ClearDataProduct();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                ShowDataProducts();
            }
            else
            {
                string str = "Select * from tb_Products where ProBarcode = '" +txtSearch.Text+ "' ";
                SqlCommand cmd = new SqlCommand(str, Q.Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewProduct.DataSource = dt;
            }
        }
    }
}
