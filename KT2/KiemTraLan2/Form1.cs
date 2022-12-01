using KiemTraLan2;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SliderProject
{
    public partial class Form1 : Form
    {

        List<string> disk = new List<string>();
        int soGiay;
        bool repeat;
        bool random;

        public Form1()
        {
            InitializeComponent();

            NapDSODia();
            NapThuMuc();


        }

        public string? selectedDisk
        {
            get
            {
                return cbbDisk?.SelectedItem as string;
            }
        }

        public string? selectedPath
        {
            get
            {
                return selectedDisk + treeView1?.SelectedNode.FullPath;
            }
        }

        public void NapDSODia()
        {
            // Lấy danh sách các ổ đĩa của máy
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string[] drivers = Directory.GetLogicalDrives();
            foreach (string d in drivers)
            {
                disk?.Add(d);
            }
            cbbDisk.DataSource = disk;
        }

        void NapThuMuc()
        {
            treeView1?.Nodes.Clear();
            DirectoryInfo directory = new(selectedDisk??"");

            // Thêm Directory
            foreach (DirectoryInfo d in directory.GetDirectories())
            {
                if ((d?.Attributes & FileAttributes.Hidden) != 0) continue;          // Bỏ qua các thư mục ẩn
                // Nạp node vào
                TreeNode Node = new TreeNode(d?.Name);
                treeView1?.Nodes.Add(Node);
                Node?.Nodes.Add("TEMP");
            }

            // Thêm File
            FileInfo[] f = directory.GetFiles();
            foreach (FileInfo file in f)
            {
                if ((file?.Attributes & FileAttributes.Hidden) != 0) continue;
                TreeNode nodeFile = new TreeNode(file?.Name);
                treeView1?.Nodes.Add(nodeFile);
            }


        }


        private void btnChoseFolder_Click(object sender, EventArgs e)
        {
            var exts = new String[] { ".png", ".jpg", ".jpeg", ".gif" };
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var rs = dialog.ShowDialog();
            if(rs == DialogResult.OK)
            {
                txtFolderPath.Text = dialog.SelectedPath;
                lsvListFile?.Items.Clear();
                DirectoryInfo directory = new DirectoryInfo(dialog.SelectedPath);
                var listFile = directory.GetFiles();
                foreach(var file in listFile)
                {
                    if (exts.Contains(file?.Extension.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(file?.Name);
                        item?.SubItems.Add(file?.FullName);
                        item?.SubItems.Add(file?.Length.ToString());
                        lsvListFile?.Items.Add(item);
                    }
                }
            }
        }

        private void lsvListFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedItem = lsvListFile.SelectedItems[0];
            var imagePath = selectedItem.SubItems[1].Text;
            frmImageForm f = new frmImageForm(imagePath);
            f?.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Lấy value từ ListView cột 2
            var images = lsvListFile.Items.Cast<ListViewItem>().Select(lvi => lvi.SubItems[1].Text);
            frmImageSlider f = new frmImageSlider(images, soGiay, repeat, random);
            f.ShowDialog();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapThuMuc();
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node?.Nodes.Clear();
            try
            {
                // Thêm Directory vào node
                foreach (string dir in Directory.GetDirectories(selectedDisk + node?.FullPath))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                    n?.Nodes.Add("temp");
                }
                // Thêm file vào Node
                DirectoryInfo directory = new DirectoryInfo(selectedDisk + node?.FullPath);
                foreach (FileInfo file in directory.GetFiles())
                {
                    TreeNode f = new TreeNode(file?.Name);
                    node?.Nodes.Add(f);
                }

            }
            catch { }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var exts = new String[] { ".png", ".jpg", ".jpeg", ".gif" };
            txtFolderPath.Text = selectedPath;
            lsvListFile?.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(selectedPath??"");
            var listFile = directory.GetFiles();
            foreach (var file in listFile)
            {
                if (exts.Contains(file?.Extension.ToLower()))
                {
                    ListViewItem item = new ListViewItem(file?.Name);
                    item?.SubItems.Add(file?.FullName);
                    item?.SubItems.Add(file?.Length.ToString());
                    lsvListFile?.Items.Add(item);

                }
            }

        }

        private void lsvListFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSettings f = new frmSettings();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                this.soGiay = f.soGiay;
                this.repeat = f.repeat;
                this.random = f.random;
            }
        }
    }
}