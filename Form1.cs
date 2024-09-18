using System.Collections.Generic;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            List<PackageInfo> packages = LocalPackageManager.GetPackages();

            foreach (var item in packages)
            {
                PackageShortControl psc = new PackageShortControl(this, item);
                psc.Dock = DockStyle.Fill;
                packageList.Controls.Add(psc);
            }
        }

        public void ShowPackage(PackageInfo packageInfo)
        {
            PackageControl pc = new PackageControl(packageInfo)
            {
                Dock = DockStyle.Fill
            };
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(pc);
        }
    }
}