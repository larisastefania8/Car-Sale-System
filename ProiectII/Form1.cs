using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ProiectII
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Home_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(UserControl1.Instance))
            {
                panel2.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            else
                UserControl1.Instance.BringToFront();
            
         
        }

        private void Cars_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(UserControl2.Instance))
            {
                panel2.Controls.Add(UserControl2.Instance);
                UserControl2.Instance.Dock = DockStyle.Fill;
                UserControl2.Instance.BringToFront();
            }
            else
                UserControl2.Instance.BringToFront();
            
        }

        private void Parts_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(UserControl3.Instance))
            {
                panel2.Controls.Add(UserControl3.Instance);
                UserControl3.Instance.Dock = DockStyle.Fill;
                UserControl3.Instance.BringToFront();
            }
            else
                UserControl3.Instance.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
