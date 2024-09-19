using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    public partial class PackageControl : UserControl
    {
        public PackageControl()
        {
            InitializeComponent();
        }

        public void ShowPackageInfo(PackageInfo packageInfo)
        {
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
            }
            else
            {
                installPackage.Enabled = true;
                deletePackage.Enabled = false;
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
    }
}