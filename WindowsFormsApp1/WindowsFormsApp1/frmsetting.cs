using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmsetting : Form
    {
        public frmsetting()
        {
            InitializeComponent();
        }
        public int SoPhut { get; set; }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            SoPhut = (int)numSoPhut.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
