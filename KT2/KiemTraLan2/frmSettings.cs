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
    public partial class frmSettings : Form
    {
        public int soGiay;
        public bool repeat;
        public bool random;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            soGiay = (int) numericUpDown1.Value;
            repeat = cbbRepeat.Checked;
            random = cbbRandom.Checked;
            DialogResult = DialogResult.OK;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
