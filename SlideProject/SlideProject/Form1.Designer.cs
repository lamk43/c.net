namespace SlideProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtfolderpath = new System.Windows.Forms.TextBox();
            this.btnchosefolder = new System.Windows.Forms.Button();
            this.lsvlistfile = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Thư Mục";
            // 
            // txtfolderpath
            // 
            this.txtfolderpath.Enabled = false;
            this.txtfolderpath.Location = new System.Drawing.Point(178, 22);
            this.txtfolderpath.Name = "txtfolderpath";
            this.txtfolderpath.Size = new System.Drawing.Size(464, 31);
            this.txtfolderpath.TabIndex = 1;
            this.txtfolderpath.TextChanged += new System.EventHandler(this.txtfolderpath_TextChanged);
            // 
            // btnchosefolder
            // 
            this.btnchosefolder.Location = new System.Drawing.Point(655, 19);
            this.btnchosefolder.Name = "btnchosefolder";
            this.btnchosefolder.Size = new System.Drawing.Size(112, 34);
            this.btnchosefolder.TabIndex = 2;
            this.btnchosefolder.Text = "...";
            this.btnchosefolder.UseVisualStyleBackColor = true;
            this.btnchosefolder.Click += new System.EventHandler(this.btntruefoder_Click);
            // 
            // lsvlistfile
            // 
            this.lsvlistfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvlistfile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lsvlistfile.FullRowSelect = true;
            this.lsvlistfile.GridLines = true;
            this.lsvlistfile.Location = new System.Drawing.Point(35, 60);
            this.lsvlistfile.MultiSelect = false;
            this.lsvlistfile.Name = "lsvlistfile";
            this.lsvlistfile.Size = new System.Drawing.Size(785, 397);
            this.lsvlistfile.TabIndex = 3;
            this.lsvlistfile.UseCompatibleStateImageBehavior = false;
            this.lsvlistfile.View = System.Windows.Forms.View.Details;
            this.lsvlistfile.SelectedIndexChanged += new System.EventHandler(this.lsvlistfile_SelectedIndexChanged);
            this.lsvlistfile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvlistfile_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Tên File";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 300;
            // 
            // btnshow
            // 
            this.btnshow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnshow.Location = new System.Drawing.Point(688, 463);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(132, 34);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 511);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lsvlistfile);
            this.Controls.Add(this.btnchosefolder);
            this.Controls.Add(this.txtfolderpath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtfolderpath;
        private Button btnchosefolder;
        private ListView lsvlistfile;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnshow;
    }
}