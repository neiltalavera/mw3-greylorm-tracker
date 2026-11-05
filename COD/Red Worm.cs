using COD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COD
{
    public partial class Red_Worm : Form
    {
        object picSender;
        bool hasPic1 = false;
        bool hasPic2 = false;
        bool hasPic3 = false;
        bool hasPic4 = false;
        public Red_Worm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picSender = sender;
            RedWormPhotoSelect photoSelect = new RedWormPhotoSelect(this);
            photoSelect.ShowDialog();
        }

        public void SetPictureBoxImage(Image image, object? tag)
        {
            PictureBox picBox = (PictureBox)picSender;
            picBox.BackgroundImage = image;
            picBox.Tag = tag;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form map = new Form();
            map.BackgroundImage = Resources.USB;
            map.Width = 869;
            map.Height = 878;
            map.FormBorderStyle = FormBorderStyle.FixedDialog;
            map.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!hasPic1 || !hasPic2 || !hasPic3 || !hasPic4)
            {
                MessageBox.Show("Select Photos before getting summary.");
                return;
            }
            RedWormSummary sumarry = new RedWormSummary
            {
                photo1 = pictureBox1.Tag.ToString(),
                photo2 = pictureBox2.Tag.ToString(),
                photo3 = pictureBox3.Tag.ToString(),
                photo4 = pictureBox4.Tag.ToString()
            };
            this.Hide();
            sumarry.ShowDialog();
            this.Show();
        }

        private void pictureBox1_BackgroundImageChanged(object sender, EventArgs e)
        {
            hasPic1 = true;
        }

        private void pictureBox2_BackgroundImageChanged(object sender, EventArgs e)
        {
            hasPic2 = true;
        }

        private void pictureBox3_BackgroundImageChanged(object sender, EventArgs e)
        {
            hasPic3 = true;
        }

        private void pictureBox4_BackgroundImageChanged(object sender, EventArgs e)
        {
            hasPic4 = true;
        }
    }
}
