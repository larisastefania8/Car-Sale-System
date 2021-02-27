using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ProiectII
{
    public partial class UserControl3 : UserControl
    {
        private static UserControl3 _instance;
        SqlConnection myCon = new SqlConnection();
        DataSet dsPart;
        DataSet dsCar;

        public static UserControl3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl3();
                return _instance;
            }
        }
        public UserControl3()
        {
            InitializeComponent();
            myCon.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            myCon.Open();
            dsCar = new DataSet();
            dsPart = new DataSet();
            SqlDataAdapter daCar = new SqlDataAdapter("SELECT * FROM Cars", myCon);
            daCar.Fill(dsCar, "Cars");
            SqlDataAdapter daPart = new SqlDataAdapter("SELECT * FROM Parts", myCon);
            daPart.Fill(dsPart, "Parts");
            foreach (DataRow dr in dsCar.Tables["Cars"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                Mark.Items.Add(name);
            }
            myCon.Close();
        }

        private void Mark_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int code = 0;
            String CarSelected = Mark.SelectedItem.ToString();
            
            foreach (DataRow dr in dsCar.Tables["Cars"].Rows)
            {
                if (CarSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    code = Convert.ToInt32(dr.ItemArray.GetValue(2));
                    Code.Text = code.ToString();
                }
            }
            foreach (DataRow dr in dsPart.Tables["Parts"].Rows)
            {
                if (code == Convert.ToInt32(dr.ItemArray.GetValue(1)))
                {
                    String pa = dr.ItemArray.GetValue(2).ToString();
                    Part1.Items.Add(pa);   
                }              
            }
            
        }

        private void Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String PartSelected = Part1.SelectedItem.ToString();

            foreach (DataRow dr in dsPart.Tables["Parts"].Rows)
            {
                if (PartSelected == dr.ItemArray.GetValue(2).ToString());
                {
                    String pr = dr.ItemArray.GetValue(3).ToString();
                    Price.Text = pr.ToString();
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();

        }
    }
}
