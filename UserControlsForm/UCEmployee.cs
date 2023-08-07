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
    public partial class UCEmployee : UserControl
    {
        Connection Q = new Connection();
        public UCEmployee()
        {
            InitializeComponent();
        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {
            ShowDataEmployee();
        }

        private void txtEID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEName_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo la = new CultureInfo("LO-LA");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
        }

        private void txtLName_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo la = new CultureInfo("LO-LA");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
        }

        private void txtEAddress_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo la = new CultureInfo("LO-LA");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
        }

        private void txtETel_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtEGmail_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void ShowDataEmployee()
        {
            try
            {
                string str = "Select * from tb_Employee";
                SqlCommand cmd = new SqlCommand(str, Q.Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewEm.DataSource = dt;

            }
            catch (Exception)
            {

            }
        }

        private void ClaerDataEmployee()
        {
            txtEID.Clear();
            txtEName.Clear();
            txtLName.Clear();
            txtEAddress.Clear();
            comBoxEGender.Text = String.Empty;
            txtETel.Clear();
            txtEGmail.Clear();
            txtEID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String Id, name, lastname, address, gender, dob, tel, email;
            Id = txtEID.Text.ToString();
            name = txtEName.Text.ToString();
            lastname = txtLName.Text.ToString();
            address = txtEAddress.Text.ToString();
            gender = comBoxEGender.Text.ToString();
            dob = dateTimeEm.Text;
            tel = txtETel.Text.ToString();
            email = txtEGmail.Text.ToString();
            Q.Query("insert into tb_Employee (EmID, EmName, EmLName, EmAddress, EmGender, EmDOB, EmTel, EmEmail)" +
                "values ('" + Id + "',N'" + name + "',N'" + lastname + "', N'" + address + "', N'" + gender + "', '" + dob + "', '" + tel + "', '" + email + "')");

            MessageBox.Show("ທ່ານເພີ່ມຂໍ້ມູນສຳເລັດ");
            ShowDataEmployee();
            ClaerDataEmployee();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String Id, name, lastname, address, gender, dob, tel, email;
            Id = txtEID.Text.ToString();
            name = txtEName.Text.ToString();
            lastname = txtLName.Text.ToString();
            address = txtEAddress.Text.ToString();
            gender = comBoxEGender.Text.ToString();
            dob = dateTimeEm.Text;
            tel = txtETel.Text.ToString();
            email = txtEGmail.Text.ToString();
            Q.Query("UPDATE tb_Employee SET EmName = N'" + name + "', EmLName = N'" + lastname + "', EmAddress = N'" + address + "', EmGender = N'" +
                gender + "', EmDOB = '" + dob + "', EmTel = '" + tel + "', EmEmail = '" + email + "' WHERE EmID = '" + Id + "'");
            //Q.Query("UPDATE tb_Employee SET EmLName = N'" + name+ "', EmLName = N'"+lastname+"', EmAddress = N'" + address+ "', EmGender = N'"+gender+ "', EmDOB = '"+dob+ "', EmTel = '"+tel+ "', EmEmail = '"+email+ "' WHERE EmID = '"+Id+"'");
            MessageBox.Show("ທ່ານໄດ້ແກ້ໄຂຂໍ້ມູນສຳເລັດ");
            ShowDataEmployee();
            ClaerDataEmployee();
        }

        private void dataGridViewEm_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtEID.Text = dataGridViewEm.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEName.Text = dataGridViewEm.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLName.Text = dataGridViewEm.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEAddress.Text = dataGridViewEm.Rows[e.RowIndex].Cells[3].Value.ToString();
            comBoxEGender.Text = dataGridViewEm.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimeEm.Text = dataGridViewEm.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtETel.Text = dataGridViewEm.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEGmail.Text = dataGridViewEm.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String Id;
            Id = txtEID.Text.ToString();
            Q.Query("DELETE FROM tb_Employee WHERE EmID = '" + Id + "'");

            MessageBox.Show("ທ່ານໄດ້ລຶບຂໍ້ມູນສຳເລັດ");
            ShowDataEmployee();
            ClaerDataEmployee();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                ShowDataEmployee();
            }
            else
            {
                string str = "Select * from tb_Employee WHERE EmID = '" +txtSearch.Text+ "'";
                SqlCommand cmd = new SqlCommand(str, Q.Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewEm.DataSource = dt;
            }
        }
    }
}
