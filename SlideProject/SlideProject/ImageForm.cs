using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideProject
{
    public partial class ImageForm : Form
    {
        public ImageForm(String path)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = path;
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
