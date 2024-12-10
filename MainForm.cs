using NORTHWNDWinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORTHWNDWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();

            toolStripStatusLabel1.Text = "User " + LoginUser.user.Fullname + " ✔😎😎😎";
        }

        private void TSMI_Category_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Categories))
                {
                    acikMi = true;
                    form.Activate();//Form açılmışsın en öne getir.
                }

            }
            if (acikMi == false)
            {
                Categories cat = new Categories();
                cat.WindowState = FormWindowState.Maximized;
                cat.MdiParent = this;
                cat.Show();
            }
        }
    }
}
