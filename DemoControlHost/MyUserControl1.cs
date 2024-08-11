using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoControlHost
{
    public partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            InitializeComponent();
        }

        private void MyUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button 1 clicked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button 2 clicked");
        }
    }
}
