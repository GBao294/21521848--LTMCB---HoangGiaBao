using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Xml.Linq;
using Path = System.IO.Path;
// using static System.Net.WebRequestMethods;


namespace Lab2
{
    public partial class bai6 : Form
    {

        string path = @"D:\";

        public bai6()
        {
            InitializeComponent();
            MessageBox.Show("Chỉ quét ổ D cho nhẹ chương trình");
            //LoadTreeView();

            if (Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path };
                treeView1.Nodes.Add(root);
                LoadExplorer(root);
            }
        }
        int x = 0;
        void LoadExplorer(TreeNode root)
        {
            if (root == null)
                return;
            try
            {
                var fileList = new DirectoryInfo(root.Text).GetFiles();

                if (fileList.Length > 0)
                {
                    foreach (FileInfo file in fileList)
                    {
                        if (x == 0)
                        {
                            TreeNode node = new TreeNode()
                            {
                                Text = Path.Combine(root.Text, file.Name)
                            }; // Thêm root.Text vào đường dẫn của file
                            root.Nodes.Add(node);
                            x = 1;
                        }
                        else
                        {
                            TreeNode node = new TreeNode() { Text = file.Name };
                            root.Nodes.Add(node);
                        }
                    }
                }

                var folderList = new DirectoryInfo(root.Text).GetDirectories();

                if (folderList.Length > 0)
                {
                    foreach (DirectoryInfo item in folderList)
                    {
                        if (Directory.Exists(item.FullName))
                        {
                            TreeNode node = new TreeNode() { Text = item.FullName };
                            root.Nodes.Add(node);
                            LoadExplorer(node);
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Lấy đường dẫn được chọn từ TreeView
            string selectedPath = e.Node.FullPath;

            // Kiểm tra nếu đường dẫn là đường dẫn tương đối thì thêm đường dẫn gốc vào
            if (!Path.IsPathRooted(selectedPath))
            {
                // Thêm đường dẫn gốc vào trước đường dẫn được chọn
                selectedPath = Path.Combine(path, selectedPath);
            }

            // Hiển thị đường dẫn đã được thêm đường dẫn gốc vào
            MessageBox.Show(selectedPath);

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Lấy đường dẫn đầy đủ của nút được chọn
            string fullPath = e.Node.FullPath;

            // Loại bỏ đường dẫn gốc của TreeView
            string removedRootPath = fullPath.Substring(path.Length + 1);


            // Kiểm tra định dạng của tệp tin (ảnh hay văn bản)
            string extension = Path.GetExtension(removedRootPath);
            if (extension != null)
            {
                // Nếu là tệp tin văn bản
                if (extension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    // Đọc nội dung của tệp tin
                    string content = File.ReadAllText(removedRootPath);

                    // Hiển thị nội dung văn bản trong TextBox
                    textBox1.Text = content;
                    textBox1.BringToFront();

                    // Xóa ảnh hiển thị trong PictureBox
                    pictureBox1.Image = null;
                }
                else
                {
                    // Nếu là tệp tin ảnh, hiển thị ảnh trong PictureBox
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    try
                    {
                        pictureBox1.Image = Image.FromFile(removedRootPath);
                        pictureBox1.BringToFront();
                        textBox1.Text = string.Empty;
                    }
                    catch
                    {
                        MessageBox.Show("Chỉ hiển thị được ảnh và văn bản.");
                    }
                }
            }

        }
    }
}
