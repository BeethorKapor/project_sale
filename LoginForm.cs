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
    public partial class LoginForm : Form
    {
        Connection Q = new Connection();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtUsername_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string str = "Select * from tb_Admin Where UserName = '" + txtUsername.Text.ToString() + "' and Password = '" + txtPassword.Text.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(str, Q.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MainForm formH = new MainForm();
                this.Hide();
                formH.Show();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ");
            }
            else
            {
                MessageBox.Show("ຊື່ຜູ້ໃຊ້ ຫຼື ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
