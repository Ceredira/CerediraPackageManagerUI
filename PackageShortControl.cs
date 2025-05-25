using System;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    /// <summary>
    /// Пользовательский компонент Краткая карточка пакета
    /// </summary>
    public partial class PackageShortControl : UserControl
    {
        private PackageInfo packageInfo;

        private Form1 mainForm;

        public PackageShortControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public PackageShortControl(Form1 form1, PackageInfo packageInfo)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainForm = form1;
            this.packageInfo = packageInfo;

            packageName.Text = packageInfo.Name + " " + packageInfo.PackageVersion;
            packageDescription.Text = packageInfo.Description;

            if (packageInfo.Installed == true)
            {
                packageIcon.Image = Properties.Resources.product_package_delivered_icon;
            }
            else
            {
                packageIcon.Image = Properties.Resources.box_package_icon;
            }
        }

        private void PackageName_Click(object sender, EventArgs e)
        {
            this.mainForm.ShowPackage(this.packageInfo);
        }

        private void PackageShortControl_Load(object sender, EventArgs e)
        {

        }

        private void PackageDescription_Click(object sender, EventArgs e)
        {
            this.mainForm.ShowPackage(this.packageInfo);
        }

        private void PackageIcon_Click(object sender, EventArgs e)
        {
            this.mainForm.ShowPackage(this.packageInfo);
        }

        private void TableLayoutPanel1_Click(object sender, EventArgs e)
        {
            this.mainForm.ShowPackage(this.packageInfo);
        }
    }
}
