using System;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    public partial class PackageControl : UserControl
    {
        public PackageControl(PackageInfo packageInfo)
        {
            InitializeComponent();
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
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void installPackage_Click(object sender, EventArgs e)
        {

        }
    }
}