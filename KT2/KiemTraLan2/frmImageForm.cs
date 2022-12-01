using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliderProject
{
    public partial class frmImageForm : Form
    {
        public frmImageForm(String path)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = path;
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
