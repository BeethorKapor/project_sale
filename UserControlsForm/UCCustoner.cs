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
    public partial class UCCustoner : UserControl
    {
        Connection Q = new Connection();
        public UCCustoner()
        {
            InitializeComponent();
        }

        private void UCCustoner_Load(object sender, EventArgs e)
        {
            ShowDataCustomer();
        }

        private void txtCID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCName_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo la = new CultureInfo("LO-LA");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
        }

        private void txtCAddress_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo la = new CultureInfo("LO-LA");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
        }

        private void txtCTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCTel_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtCID_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }


        private void ShowDataCustomer()
        {
            try
            {
                string str = "Select * from tb_Customer";
                SqlCommand cmd = new SqlCommand(str, Q.Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewCus.DataSource = dt;

            }
            catch (Exception)
            {

            }
        }

        private void ClearDataCustomer()
        {
            txtCID.Clear();
            txtCName.Clear();
            txtCAddress.Clear();
            comBoxCGender.Text = String.Empty;
            //dateTimeDOB.Clear();
            txtCTel.Clear();
            txtCID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String Id, name, address, gender, dob, tel;
            Id = txtCID.Text.ToString();
            name = txtCName.Text.ToString();
            address = txtCAddress.Text.ToString();
            gender = comBoxCGender.Text.ToString();
            dob = dateTimeDOB.Text;
            tel = txtCTel.Text.ToString();
            Q.Query("insert into tb_Customer (CusID, CusName, CusAddress, CusGender, CusDOB, CusTel)" +
                "values ('" + Id + "',N'" + name + "', N'" + address + "', N'" + gender + "', '" + dob + "', '" + tel + "')");

            MessageBox.Show("ທ່ານເພີ່ມຂໍ້ມູນສຳເລັດ");
            ShowDataCustomer();
            ClearDataCustomer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String Id, name, address, gender, dob, tel;
            Id = txtCID.Text.ToString();
            name = txtCName.Text.ToString();
            address = txtCAddress.Text.ToString();
            gender = comBoxCGender.Text.ToString();
            dob = dateTimeDOB.Text;
            tel = txtCTel.Text.ToString();
            Q.Query("UPDATE tb_Customer SET CusName = N'" + name + "', CusAddress = N'" + address + "', CusGender = N'" + gender + "', CusDOB ='" + dob + "', CusTel = '" + tel + "' WHERE CusID = '" + Id + "'");

            MessageBox.Show("ທ່ານໄດ້ແກ້ໄຂຂໍ້ມູນສຳເລັດ");
            ShowDataCustomer();
            ClearDataCustomer();
        }

        private void dataGridViewCus_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtCID.Text = dataGridViewCus.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCName.Text = dataGridViewCus.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCAddress.Text = dataGridViewCus.Rows[e.RowIndex].Cells[2].Value.ToString();
            comBoxCGender.Text = dataGridViewCus.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimeDOB.Text = dataGridViewCus.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCTel.Text = dataGridViewCus.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String Id;
            Id = txtCID.Text.ToString();
            Q.Query("DELETE FROM tb_Customer WHERE CusID = '" + Id + "'");

            MessageBox.Show("ທ່ານໄດ້ລຶບຂໍ້ມູນສຳເລັດ");
            ShowDataCustomer();
            ClearDataCustomer();
        }

        private void btnCSearch_Click(object sender, EventArgs e)
        {
            if (txtCSearch.Text == "")
            {
                ShowDataCustomer();
            }
            else
            {
                string str = "Select * from tb_Customer WHERE CusID = '" +txtCSearch.Text+ "'";
                SqlCommand cmd = new SqlCommand(str, Q.Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewCus.DataSource = dt;
            }
        }
    }
}
