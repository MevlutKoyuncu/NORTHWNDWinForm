using NORTHWNDWinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORTHWNDWinForm
{
    public partial class LoginForm : Form
    {
        bool islogin = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //using otomatik olarak try-finally komutları üretir.
            using (SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True"))
            {
                if(!string.IsNullOrEmpty(tb_username.Text) && !string.IsNullOrEmpty(tb_password.Text))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT EmployeeID, FirstName, LastName, FirstName+' '+LastName FROM Employees WHERE Username =@un AND Password =@psw";
                    cmd.Parameters.AddWithValue("@un", tb_username.Text);
                    cmd.Parameters.AddWithValue("@psw", tb_password.Text);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    User u = null;
                    while (reader.Read())
                    {
                        u = new User();
                        u.ID = reader.GetInt32(0);
                        u.Name = reader.GetString(1);
                        u.Surname = reader.GetString(2);
                        u.Fullname = reader.GetString(3);
                    }
                    if(u != null)
                    {
                        LoginUser.user = u;
                        islogin = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }//using parantezi bittiği anda using içerisinde oluşturulan nesneyi Dispose eder.
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (islogin == false)
            {
                Application.Exit();
            }
        }
    }
}
