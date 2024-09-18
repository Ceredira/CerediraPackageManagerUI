using System;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    public partial class PackageControl : UserControl
    {
        public PackageControl(PackageInfo packageInfo)
        {
            InitializeComponent();
            packageName.Text = packageInfo.Name + " " + packageInfo.Version;
            // packageName.LinkClicked += PackageName_LinkClicked;
            packageDescription.Text = packageInfo.Description;
            packageWebsite.Text = packageInfo.Website;
            packageAuthor.Text = packageInfo.Author;

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