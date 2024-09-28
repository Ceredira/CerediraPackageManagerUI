using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    /// <summary>
    /// Пользовательский компонент Карточка пакета
    /// </summary>
    public partial class PackageControl : UserControl
    {
        private PackageInfo packageInfo;

        private Form1 mainForm;

        public PackageControl()
        {
            InitializeComponent();
        }

        public void ShowPackageInfo(Form1 form1, PackageInfo packageInfo)
        {
            this.mainForm = form1;
            this.packageInfo = packageInfo;

            packageChangelog.Text = packageInfo.Changelog;
            packageName.Text = packageInfo.Name + " " + packageInfo.PackageVersion;
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

        public void HidePackageInfo(Form1 form1)
        {
            this.mainForm = form1;

            packageChangelog.Visible = false;
            packageName.Visible = false;
            packageDescription.Visible = false;
            packageAuthor.Visible = false;
            packageWebsite.Visible = false;

            installPackage.Enabled = false;
            deletePackage.Enabled = false;
            packageIcon.Visible = false;

            splitContainer1.Enabled = false;
            packageDescriptionTab.BackColor = System.Drawing.Color.Transparent;
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