using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Список установленных пакетов
        /// </summary>
        List<PackageInfo> localPackages;

        /// <summary>
        /// Список доступных пакетов
        /// </summary>
        List<PackageInfo> remotePackages;

        /// <summary>
        /// Инициализация главной формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Вывести текущий каталог в поле Каталог установки
            rootPath.Text = Directory.GetCurrentDirectory();

            // Проверить наличие установленных пакетов
            ScanLocalPackages();

            // Отобразить подробную инфомарцию по первому доступному пакету
            ShowPackage(localPackages[0]);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }

        /// <summary>
        /// Метод для отрисовки на форме информации по выбранному пакету
        /// </summary>
        /// <param name="packageInfo">Пакет</param>
        public void ShowPackage(PackageInfo packageInfo)
        {
            packageControl.ShowPackageInfo(this, packageInfo);
        }

        /// <summary>
        /// Метод для загрузки установленных пакетов
        /// </summary>
        public void ScanLocalPackages()
        {
            this.localPackages = LocalPackageManager.GetPackages();

            installedPackageList.Controls.Clear();

            foreach (var item in this.localPackages)
            {
                PackageShortControl psc = new PackageShortControl(this, item);
                installedPackageList.Controls.Add(psc);
            }
        }

        /// <summary>
        /// Метод для загрузки доступных пакетов
        /// </summary>
        public async void ScanRemotePackages()
        {
            this.remotePackages = await RemotePackageManager.GetPackages(remoteRepositoryUrl.Text);

            availablePackageList.Controls.Clear();

            foreach (var item in this.remotePackages)
            {
                PackageShortControl psc = new PackageShortControl(this, item);
                availablePackageList.Controls.Add(psc);
            }
        }

        /// <summary>
        /// Нажатие на кнопку Обновить на главной форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateLocalPackages_Click(object sender, System.EventArgs e)
        {
            ScanLocalPackages();
        }

        /// <summary>
        /// Нажатие на кнопку Обновить во вкладке Доступные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateRemotePackages_Click(object sender, System.EventArgs e)
        {
            ScanRemotePackages();
        }
    }
}