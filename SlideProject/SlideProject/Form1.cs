namespace SlideProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntruefoder_Click(object sender, EventArgs e)
        {
            var exts = new String[] { ".jpg", ".png", ".jpeg", ".gif" };
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var rs = dialog.ShowDialog();
            if(rs == DialogResult.OK)
            {
                txtfolderpath.Text = dialog.SelectedPath;
                lsvlistfile.Items.Clear();
                DirectoryInfo directory = new DirectoryInfo(dialog.SelectedPath);
                var listFIle = directory.GetFiles("*.png");// *.jpg, *.svg
                foreach (var file in listFIle)
                {
                    if (exts.Contains(file.Extension.ToLower())) 
                    {
                        ListViewItem item = new ListViewItem(file.Name);
                        item.SubItems.Add(file.FullName);
                        item.SubItems.Add(file.Length.ToString());
                        lsvlistfile.Items.Add(item);
                    }
                }
              } 
        }

        private void lsvlistfile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedItem = lsvlistfile.SelectedItems[0];
            var imagePath = selectedItem.SubItems[1].Text;
            ImageForm f = new ImageForm(imagePath);
            f.ShowDialog();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {

        }

        private void txtfolderpath_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsvlistfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}