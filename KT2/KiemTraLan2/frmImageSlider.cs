using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraLan2
{
    public partial class frmImageSlider : Form
    {
        IEnumerable<string> images;
        int soGiay;
        bool repeat;
        bool random;
        List<string> imagesList = new List<string>();
        string[] imagesArray;

        public frmImageSlider(IEnumerable<string> images, int soGiay, bool repeat, bool random)
        {
            InitializeComponent();
            this.images = images;
            this.soGiay = soGiay;
            this.repeat = repeat;
            this.random = random;
            imagesList = images.ToList();
            imagesArray = images.ToArray();


            timer1.Interval = soGiay * 1000;
            timer1.Start();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (repeat)
            {
                if(random)
                {
                    Random random = new Random();
                    i = random.Next(0, images.ToArray().Length);
                    pictureBox1.ImageLocation = imagesArray[i];
                }
                else
                {
                    if (i >= images.ToArray().Length) i = 0;
                    pictureBox1.ImageLocation = images.ToArray()[i];
                    i++;
                }
            }
            else if (random)
            {
                if (imagesList.Count == 0) timer1.Stop();
                Random random = new Random();
                i = random.Next(0, images.ToArray().Length);
                pictureBox1.ImageLocation = imagesArray[i];
                imagesList.Remove(images.ToArray()[i]);
                //MessageBox.Show(i.ToString());
            }
            else
            {
                if (i == images.ToArray().Length-1) timer1.Stop();
                pictureBox1.ImageLocation = images.ToArray()[i];
                i++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
