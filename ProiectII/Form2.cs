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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            DataSet dsPart;
            DataSet dsCar;
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

            dsCar = new DataSet();
            dsPart = new DataSet();
            SqlDataAdapter daCar = new SqlDataAdapter("SELECT * FROM Cars", myCon);
            daCar.Fill(dsCar, "Cars");
            SqlDataAdapter daPart = new SqlDataAdapter("SELECT * FROM Parts", myCon);
            daPart.Fill(dsPart, "Parts");
            String sql = "insert into Cars ([Id], [Cars],[Code]) values(@Id,@Cars,@Code)";
            String sql1 = "insert into Parts ([Id],[Code],[Parts],[Price]) values (@Id,@Code,@Parts,@Price)";
            try
            {
                myCon.Open();
                using (SqlCommand cmd = new SqlCommand(sql, myCon))
                {
                    foreach (DataRow dr in dsCar.Tables["Cars"].Rows)
                    {
                        String id = dr.ItemArray.GetValue(0).ToString();
                        String code = dr.ItemArray.GetValue(2).ToString();
                        String name = dr.ItemArray.GetValue(1).ToString();
                        

                        if (CarsText.Text == name)
                        {
                            
                            using (SqlCommand cmd2 = new SqlCommand(sql1, myCon))
                            {
                                cmd2.Parameters.Add("@Id", SqlDbType.NVarChar).Value = id;
                                cmd2.Parameters.Add("@Code", SqlDbType.NVarChar).Value = code;
                                cmd2.Parameters.Add("@Parts", SqlDbType.NVarChar).Value = PartsText.Text;
                                cmd2.Parameters.Add("@Price", SqlDbType.NVarChar).Value = PriceText.Text;
                                int rowsAdded = cmd2.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            int rowsAdded,rowsAdded1;
                            cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = IdText.Text;
                            cmd.Parameters.Add("@Cars", SqlDbType.NVarChar).Value = CarsText.Text;
                            cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = CodeText.Text;
                            rowsAdded = cmd.ExecuteNonQuery();
                            using (SqlCommand cmd2 = new SqlCommand(sql1, myCon))
                            {
                                cmd2.Parameters.Add("@Id", SqlDbType.NVarChar).Value = IdText.Text;
                                cmd2.Parameters.Add("@Code", SqlDbType.NVarChar).Value = CodeText.Text;
                                cmd2.Parameters.Add("@Parts", SqlDbType.NVarChar).Value = PartsText.Text;
                                cmd2.Parameters.Add("@Price", SqlDbType.NVarChar).Value = PriceText.Text;
                                rowsAdded1 = cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }
    }
}
