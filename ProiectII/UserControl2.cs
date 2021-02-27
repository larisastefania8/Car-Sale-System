using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectII
{

    public partial class UserControl2 : UserControl
    {
        private static UserControl2 _instance;

        public static UserControl2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl2();
                return _instance;
            }
        }
        public UserControl2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CarSize_Click(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_car_Click(object sender, EventArgs e)
        {
            CarSize.Image = pictureBox1_car.Image;
            car1.Load("im_car\\1.png");
            car2.Load("im_car\\11.png");
            car3.Load("im_car\\111.png");
            label16.Text = label1.Text;
            label17.Text = label3.Text;
        }

        private void car2_Click(object sender, EventArgs e)
        {
            CarSize.Image = car2.Image;
        }

        private void car3_Click(object sender, EventArgs e)
        {
            CarSize.Image = car3.Image;
        }

        private void car1_Click(object sender, EventArgs e)
        {
            CarSize.Image = car1.Image;
        }

        private void pictureBox2_car_Click(object sender, EventArgs e)
        {
            CarSize.Image = pictureBox2_car.Image;
            car1.Load("im_car\\2.png");
            car2.Load("im_car\\22.png");
            car3.Load("im_car\\222.png");
            label16.Text = label6.Text;
            label17.Text = label4.Text;
        }

        private void pictureBox3_car_Click(object sender, EventArgs e)
        {
            CarSize.Image = pictureBox3_car.Image;
            car1.Load("im_car\\3.png");
            car2.Load("im_car\\33.png");
            car3.Load("im_car\\333.png");
            label16.Text = label9.Text;
            label17.Text = label7.Text;
        }

        private void pictureBox4_car_Click(object sender, EventArgs e)
        {
            CarSize.Image = pictureBox4_car.Image;
            car1.Load("im_car\\7.png");
            car2.Load("im_car\\77.png");
            car3.Load("im_car\\777.png");
            label16.Text = label12.Text;
            label17.Text = label10.Text;
        }

        private void pictureBox5_car_Click(object sender, EventArgs e)
        {
            CarSize.Image = pictureBox5_car.Image;
            car1.Load("im_car\\4.png");
            car2.Load("im_car\\44.png");
            car3.Load("im_car\\444.png");
            label16.Text = label15.Text;
            label17.Text = label13.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
