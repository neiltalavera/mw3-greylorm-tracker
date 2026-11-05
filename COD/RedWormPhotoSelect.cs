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
    public partial class RedWormPhotoSelect : Form
    {
        private Red_Worm redWorm;
        public RedWormPhotoSelect(Red_Worm redWorm)
        {
            InitializeComponent();
            this.redWorm = redWorm;
        }

        protected void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox selectedPictureBox = sender as PictureBox;
            if (selectedPictureBox != null)
            {
                Image selectedImage = selectedPictureBox.BackgroundImage;

                // Set the image in FormA's PictureBox
                redWorm.SetPictureBoxImage(selectedImage, selectedPictureBox.Tag);

                // Close FormB after selection
                this.Close();
            }
        }
    }
}
