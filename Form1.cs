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
            PackageInfo dr1 = new PackageInfo();
            dr1.Name = "Everything";
            dr1.Version = "1.0";
            dr1.Author = "David Carpenter";
            dr1.Description = "Everything — это бесплатная утилита поиска на рабочем столе для Windows, которая может быстро находить файлы и папки по имени. Поскольку двоичные файлы и само приложение инструмента Everything лицензированы по разрешительной лицензии MIT, оно считается программой с открытым исходным кодом.";
            dr1.Website = "https://www.voidtools.com/";
            dr1.AllowUninstall = true;
            dr1.Installed = true;

            PackageInfo dr2 = new PackageInfo();
            dr2.Name = "Everything";
            dr2.Version = "1.2";
            dr2.Author = "David Carpenter";
            dr2.Description = "Everything — это бесплатная утилита поиска на рабочем столе для Windows, которая может быстро находить файлы и папки по имени. Поскольку двоичные файлы и само приложение инструмента Everything лицензированы по разрешительной лицензии MIT, оно считается программой с открытым исходным кодом.";
            dr2.Website = "https://www.voidtools.com/";
            dr2.AllowUninstall = false;
            dr2.Installed = false;

            // Прочитать список каталогов в каталоге install
            // Создавать циклом по каждому каталогу объект DistrInfo
            // Наполнять его данными из файлов и 
            // Добавить в форму

            PackageShortControl pc1 = new PackageShortControl(this, dr1);
            PackageShortControl pc2 = new PackageShortControl(this, dr2);
            pc1.Dock = DockStyle.Fill;
            pc2.Dock = DockStyle.Fill;
            packageList.Controls.Add(pc1);
            packageList.Controls.Add(pc2);
        }

        public void ShowPackage(PackageInfo packageInfo)
        {
            PackageControl pc = new PackageControl(packageInfo);
            pc.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(pc);
        }
    }
}