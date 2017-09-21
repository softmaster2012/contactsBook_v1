using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsBook_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form login = new Login();
            DialogResult res = login.ShowDialog();
            if (res == DialogResult.OK)
            {

            }
            else
            {
                this.Close();
            }
        }
    }
}
