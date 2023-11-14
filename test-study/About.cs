using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_study
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Home fhome = new Home();
            fhome.Show();
            this.Hide();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
