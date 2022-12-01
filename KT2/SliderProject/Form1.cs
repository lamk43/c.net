namespace SliderProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnChoseFolder_Click(object sender, EventArgs e)
        {
            var exts = new String[] { ".png", ".jpg", ".jpeg", ".gif" };
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var rs = dialog.ShowDialog();
            if(rs == DialogResult.OK)
            {
                txtFolderPath.Text = dialog.SelectedPath;
                lsvListFile.Items.Clear();
                DirectoryInfo directory = new DirectoryInfo(dialog.SelectedPath);
                var listFile = directory.GetFiles();
                foreach(var file in listFile)
                {
                    if (exts.Contains(file.Extension.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(file.Name);
                        item.SubItems.Add(file.FullName);
                        item.SubItems.Add(file.Length.ToString());
                        lsvListFile.Items.Add(item);
                    }
                }
            }
        }

        private void lsvListFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedItem = lsvListFile.SelectedItems[0];
            var imagePath = selectedItem.SubItems[1].Text;
            ImageForm f = new ImageForm(imagePath);
            f.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }
    }
}