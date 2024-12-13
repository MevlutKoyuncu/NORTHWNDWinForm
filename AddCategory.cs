using NORTHWNDWinForm.Model;
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

namespace NORTHWNDWinForm
{
    public partial class AddCategory : Form
    {
        SqlConnection con; SqlCommand cmd;

        public AddCategory()
        {
            con = new SqlConnection(Constr.ConStr);
            cmd = con.CreateCommand();
            InitializeComponent();
        }

        private void btn_catadd_Click(object sender, EventArgs e)
        {
            btn_catedit.Visible = false;
            if (btn_catadd.Visible == true)
            {
                cmd.CommandText = "INSERT INTO Categories(CategoryName,Description) VALUES(@name,@des)";
                cmd.Parameters.AddWithValue("@name", tb_catname.Text);
                cmd.Parameters.AddWithValue("@des", tb_catdesc.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    tb_catname.Text = tb_catdesc.Text = "";
                    MessageBox.Show("Kategori Başarıyla Eklenmiştir", "Başarılı", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Kategori Eklenirken bir hata oluştu", "Hata Var");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_catedit_Click(object sender, EventArgs e)
        {
            btn_catadd.Visible = false;
            if (!string.IsNullOrEmpty(tb_catname.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Categories SET CategoryName=@cn, Description=@des WHERE CategoryID=@id";
                cmd.Parameters.AddWithValue("@cn", tb_catname.Text);
                cmd.Parameters.AddWithValue("@des", tb_catdesc.Text);
                cmd.Parameters.AddWithValue("@id", tb_catno.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori Başarıyla Güncellenmiştir", "Başarılı");
                }
                catch
                {
                    MessageBox.Show("Kategori Güncellenirkene bir hata oluştu", "Hata Var");
                }
                finally
                {
                    con.Close();
                }
                btn_catedit.Visible = false;
                tb_catno.Text = tb_catname.Text = tb_catdesc.Text = "";
                Categories cat = new Categories();
                
            }
        }
    }
}

