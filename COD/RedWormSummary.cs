using COD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COD
{
    public partial class RedWormSummary : Form
    {
        public String photo1 { get; set; }
        public String photo2 { get; set; }
        public String photo3 { get; set; }
        public String photo4 { get; set; }

        public RedWormSummary()
        {
            InitializeComponent();
        }

        private void ShowButtonIfImageMatches(Button button, String resourceImage)
        {
            if (photo1 == resourceImage || photo2 == resourceImage || photo3 == resourceImage || photo4 == resourceImage)
            {
                button.Visible = true;
            }
        }

        private void hideTargets()
        {
            r1.Hide();
            r2.Hide();
            r3.Hide();
            r4.Hide();
            r5.Hide();
            r6.Hide();
            r7.Hide();
            r8.Hide();
            r9.Hide();
            r10.Hide();
            r11.Hide();
            r12.Hide();
        }

        private void RedWormSummary_Load(object sender, EventArgs e)
        {
            hideTargets();
            ShowButtonIfImageMatches(r1, "r1");
            ShowButtonIfImageMatches(r2, "r2");
            ShowButtonIfImageMatches(r3, "r3");
            ShowButtonIfImageMatches(r4, "r4");
            ShowButtonIfImageMatches(r5, "r5");
            ShowButtonIfImageMatches(r6, "r6");
            ShowButtonIfImageMatches(r7, "r7");
            ShowButtonIfImageMatches(r8, "r8");
            ShowButtonIfImageMatches(r9, "r9");
            ShowButtonIfImageMatches(r10, "r10");
            ShowButtonIfImageMatches(r11, "r11");
            ShowButtonIfImageMatches(r12, "r12");
        }

        private void showPin(Image resource)
        {
            Form pin = new Form();
            pin.BackgroundImage = resource;
            pin.Width = 564;
            pin.Height = 570;
            pin.BackgroundImageLayout = ImageLayout.Zoom;
            pin.FormBorderStyle = FormBorderStyle.Sizable;
            pin.Show();
        }

        private void r1_Click(object sender, EventArgs e)
        {
            showPin(Resources.r1_pin);
        }

        private void r2_Click(object sender, EventArgs e)
        {
            showPin(Resources.r2_pin);
        }

        private void r8_Click(object sender, EventArgs e)
        {
            showPin(Resources.r8_pin);
        }

        private void r6_Click(object sender, EventArgs e)
        {
            showPin(Resources.r6_pin);
        }

        private void r12_Click(object sender, EventArgs e)
        {
            showPin(Resources.r12_pin);
        }

        private void r11_Click(object sender, EventArgs e)
        {
            showPin(Resources.r11_pin);
        }

        private void r3_Click(object sender, EventArgs e)
        {
            showPin(Resources.r3_pin);
        }

        private void r10_Click(object sender, EventArgs e)
        {
            showPin(Resources.r10_pin);
        }

        private void r7_Click(object sender, EventArgs e)
        {
            showPin(Resources.r7_pin);
        }

        private void r9_Click(object sender, EventArgs e)
        {
            showPin(Resources.r9_pin);
        }

        private void r4_Click(object sender, EventArgs e)
        {
            showPin(Resources.r4_pin);
        }

        private void r5_Click(object sender, EventArgs e)
        {
            showPin(Resources.r5_pin);
        }
    }
}
