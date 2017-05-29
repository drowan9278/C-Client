using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class accountLoginHome : Form
    {
        public accountLoginHome()
        {
            InitializeComponent();
        }

        private void accountLoginHome_Load(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Hide();
            (new Form1()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
