using System;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    public partial class PackageShortControl : UserControl
    {
        private readonly PackageInfo packageInfo;

        private readonly Form1 mainForm;

        public PackageShortControl(Form1 form1, PackageInfo packageInfo)
        {
            InitializeComponent();
            this.mainForm = form1;
            this.packageInfo = packageInfo;
            packageName.Text = packageInfo.Name + " " + packageInfo.PackageVersion;
            packageDescription.Text = packageInfo.Description;
        }

        private void packageName_Click(object sender, EventArgs e)
        {
            this.mainForm.ShowPackage(this.packageInfo);
        }

        private void PackageShortControl_Load(object sender, EventArgs e)
        {

        }

        private void packageDescription_Click(object sender, EventArgs e)
        {
            this.mainForm.ShowPackage(this.packageInfo);
        }

        private void packageIcon_Click(object sender, EventArgs e)
        {
            this.mainForm.ShowPackage(this.packageInfo);
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            this.mainForm.ShowPackage(this.packageInfo);
        }
    }
}
