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
    public partial class Categories : Form
    {
        SqlConnection con; SqlCommand cmd;
        int rowindex = -1;
        public Categories()
        {
            con = new SqlConnection(Constr.ConStr);
            cmd = con.CreateCommand();
            InitializeComponent();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            CategoriesList();
        }
        private void CategoriesList()
        {
            try
            {
                List<Category> categories = new List<Category>();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM Categories";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Category cat = new Category();
                    cat.ID = reader.GetInt32(0);
                    cat.Name = reader.GetString(1);
                    cat.Desc = reader.GetString(2);
                    categories.Add(cat);
                }
                dgv_categories.DataSource = categories;
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }


        }

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                //Helper.cid = Convert.ToInt32(dgv_categories.Rows[rowindex].Cells[0].Value);
                AddCategory addCategory = new AddCategory(Convert.ToInt32(dgv_categories.Rows[rowindex].Cells[0].Value));
                addCategory.ShowDialog();
            }
            CategoriesList();
          
        }

        private void dgv_categories_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rowindex = dgv_categories.HitTest(e.X, e.Y).RowIndex;
                if (rowindex != -1)
                {
                    //MessageBox.Show("Sağ buton tıklandı");
                    contextMenuStrip1.Show(dgv_categories, e.X, e.Y);
                    dgv_categories.ClearSelection();
                    dgv_categories.Rows[rowindex].Selected = true;

                }
            }
        }

        private void btn_categoryadd_Click(object sender, EventArgs e)
        {
            AddCategory adc = new AddCategory();
            adc.ShowDialog();
            CategoriesList();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dgv_categories.Rows[rowindex].Cells[0].Value);

                if (MessageBox.Show($"{id} id'li kategori silinecektir.\nOnaylıyor musunuz?", "Kategori Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Categories WHERE CategoryID=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    try { con.Open(); cmd.ExecuteNonQuery(); }
                    finally { con.Close(); }
                    CategoriesList();
                }
            }
        }
    }
}
