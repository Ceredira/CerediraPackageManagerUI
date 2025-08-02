using System;
using System.Drawing;
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
            Dock = DockStyle.Fill;
        }

        public PackageShortControl(Form1 form1, PackageInfo packageInfo)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            mainForm = form1;
            this.packageInfo = packageInfo;

            packageName.Text = $"{packageInfo.Name} {packageInfo.PackageVersion}";
            packageDescription.Text = packageInfo.Description;

            if (packageInfo.Installed == true)
            {
                packageIcon.Image = Properties.Resources.product_package_delivered_icon;
            }
            else
            {
                packageIcon.Image = Properties.Resources.box_package_icon;
            }

            // Подключаем клики ко всем элементам
            Click += PackageControl_Click;
            packageName.Click += PackageControl_Click;
            packageDescription.Click += PackageControl_Click;
            packageIcon.Click += PackageControl_Click;
            tableLayoutPanel1.Click += PackageControl_Click;
        }

        private void PackageName_Click(object sender, EventArgs e)
        {
            mainForm.ShowPackage(packageInfo);
        }

        private void PackageShortControl_Load(object sender, EventArgs e)
        {

        }

        private void PackageDescription_Click(object sender, EventArgs e)
        {
            mainForm.ShowPackage(packageInfo);
        }

        private void PackageIcon_Click(object sender, EventArgs e)
        {
            mainForm.ShowPackage(packageInfo);
        }

        private void TableLayoutPanel1_Click(object sender, EventArgs e)
        {
            mainForm.ShowPackage(packageInfo);
        }

        private void PackageControl_Click(object sender, EventArgs e)
        {
            mainForm.HighlightOnly(this); 
            mainForm.ShowPackage(packageInfo);
        }

        private bool _isSelected = false;
        public bool IsSelected
        {

            get => _isSelected;
            set
            {
                _isSelected = value;
                BackColor = _isSelected ? Color.LightGray : Color.White;
                BorderStyle = _isSelected ? BorderStyle.FixedSingle : BorderStyle.None;
            }
        }
    }
}
