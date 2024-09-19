using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rootPath.Text = Directory.GetCurrentDirectory();

            ScanLocalPackages();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }

        public void ShowPackage(PackageInfo packageInfo)
        {
            packageControl.ShowPackageInfo(packageInfo);
        }

        public void ScanLocalPackages()
        {
            List<PackageInfo> packages = LocalPackageManager.GetPackages();

            installedPackageList.Controls.Clear();

            foreach (var item in packages)
            {
                PackageShortControl psc = new PackageShortControl(this, item)
                {
                    Dock = DockStyle.Fill
                };
                installedPackageList.Controls.Add(psc);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ScanLocalPackages();
        }
    }
}