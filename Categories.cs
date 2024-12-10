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

        private void btn_catadd_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
        }

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory cat = new AddCategory();
            cat.ShowDialog(Owner);

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
    }
}
