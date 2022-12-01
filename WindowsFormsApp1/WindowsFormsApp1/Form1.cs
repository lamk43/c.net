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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval= 1000;
        }
        int count = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // count++;
            //lblDongho.Text = $"{count}";
            count--;
            lblDongho.Text = convert(count);
            if (count == 0)
            {
                timer1.Stop();
            }

        }

        private void Start(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int soPhut = 0;
        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmsetting();
            var rs= f.ShowDialog();
            if (rs == DialogResult.OK) 
            {
             
                count = f.SoPhut * 60;
                lblDongho.Text = convert(count);
            }  
        }
        string convert(int soGiay)
        {
            int p = soGiay / 60;
            int s = soGiay % 60;
            return $"{p:0#}:{s:0#}";
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStart.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
