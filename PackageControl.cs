using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    public partial class PackageControl : UserControl
    {
        PackageInfo packageInfo;

        public PackageControl()
        {
            InitializeComponent();
        }

        public void ShowPackageInfo(PackageInfo packageInfo)
        {
            this.packageInfo = packageInfo;

            packageChangelog.Text = packageInfo.Changelog;
            packageName.Text = packageInfo.Name + " " + packageInfo.PackageVersion;
            // packageName.LinkClicked += PackageName_LinkClicked;
            packageDescription.Text = packageInfo.Description;
            packageAuthor.Text = packageInfo.PackageAuthor;
            packageWebsite.Text = packageInfo.Website;

            if (packageInfo.Installed == true)
            {
                installPackage.Enabled = false;
                deletePackage.Enabled = true;
                packageIcon.Image = global::CerediraPackageManagerUI.Properties.Resources.product_package_delivered_icon;
            }
            else
            {
                installPackage.Enabled = true;
                deletePackage.Enabled = false;
                packageIcon.Image = global::CerediraPackageManagerUI.Properties.Resources.box_package_icon;
            }

            infoPackageName.Text = packageInfo.Name;
            infoPackageVersion.Text = packageInfo.PackageVersion;
            infoPackageAuthor.Text = packageInfo.PackageAuthor;
            infoWebsite.Text = packageInfo.Website;
            infoDownloadPath.Text = packageInfo.DownloadPath;
            infoOriginalPackageName.Text = packageInfo.OriginalPackageName;
            infoPackageSourceSize.Text = packageInfo.PackageSourceSize;
            infoPackageSize.Text = "";

            packageFiles.Text = packageInfo.PackageFiles;
        }

        private void deletePackage_Click(object sender, System.EventArgs e)
        {
            foreach (var item in  packageInfo.PackageFiles.Split('\n').Reverse())
            {
                try
                {
                    if (File.Exists(item))
                    {
                        File.Delete(item);
                    }
                } catch { }
            }

            foreach (var item in packageInfo.PackageDirs.Split('\n').Reverse())
            {
                try
                {
                    if (Directory.Exists(item))
                    {
                        Directory.Delete(item);
                    }
                } catch { }
            }
        }
    }
}