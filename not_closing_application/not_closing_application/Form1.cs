using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_closing_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult warn = new DialogResult();
            warn = MessageBox.Show("Kapanmıyom Tıklamasaydın", "Salak", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            if (warn == DialogResult.OK)
            {
                MessageBox.Show("Kapanmıyom", "Salak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1 darkform = new Form1();
                darkform.Show();
            }

            else
            {
                MessageBox.Show("Yıkılmam Kapanmam", "Salak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1 darkform = new Form1();
                darkform.Show();
            }
        }
    }
}
