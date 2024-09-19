using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    public partial class Form1 : Form
    {

        List<PackageInfo> packages;

        public Form1()
        {
            InitializeComponent();
            rootPath.Text = Directory.GetCurrentDirectory();

            ScanLocalPackages();
            ShowPackage(packages[0]);
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
            this.packages = LocalPackageManager.GetPackages();

            installedPackageList.Controls.Clear();

            foreach (var item in this.packages)
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

        private async void button2_Click(object sender, System.EventArgs e)
        {
            string repoInfo = await Downloader.GetPageContentAsync(remoteRepositoryUrl.Text + "/info.txt");

            foreach (var item in repoInfo.Split('\n')) {
                string packageUrl = remoteRepositoryUrl.Text + $"/{item.Replace("\r", "")}/{item.Replace('/', '-').Replace("\r", "")}.cpmd";
                string remotePackageInfo = await Downloader.GetPageContentAsync(packageUrl);
                richTextBox1.Text = remotePackageInfo;
            }
        }
    }
}