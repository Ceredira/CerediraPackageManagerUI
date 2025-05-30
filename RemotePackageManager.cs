using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CerediraPackageManagerUI
{
    /// <summary>
    /// Менеджер пакетов из удаленного репозитория. Методы для работы с доступными пакетами,
    /// которые находятся в репозитории.
    /// </summary>
    internal class RemotePackageManager
    {
        /// <summary>
        /// Метод получения списка доступных в репозитории пакетов, метаданные пакета парсятся
        /// из файла .cpmd в формате json, содержащий все необходимые данные
        /// </summary>
        /// <param name="remoteRepositoryUrl"></param>
        /// <returns>Список доступных пакетов</returns>
        public async static Task<List<PackageInfo>> GetPackages(string remoteRepositoryUrl)
        {
            List<PackageInfo> packages = new List<PackageInfo>();

            // Вычитать файл /info.txt, который содержит список пакетов в формате
            // Everything/1.4.1.1022
            // Everything / 1.4.1.1024
            string repoInfo = await Downloader.GetPageContentAsync(remoteRepositoryUrl + "/info.txt");

            // Пакет - строка из списка
            foreach (var item in repoInfo.Split('\n'))
            {
                // Отрезаем лишние символы и символы новой строки с конца
                string itemTrimmed = item.Trim().Replace("\r", "");

                // Путь к пакету - это имя + версия, поэтому чтобы попасть в каталог, можно заменить / на -
                // и получить имя файла с расширением .cmpd.
                string packageUrl = remoteRepositoryUrl + $"/{itemTrimmed}/{itemTrimmed.Replace('/', '-')}.cpmd";

                // Получить содержимое в виде json
                // Пример содержимого
                // {
                //   "category": "инструменты,поиск",
                //   "changelog": "Monday, 10 October 2022: Version 1.4.1.1022\n\tfixed a crash when loading a preview failed.",
                //   "contextMenu": "Everything\nEverything\nEverything.bat\n\\bin\\Everything\\Everything.exe\n",
                //   "dependencies": "",
                //   "description": "Everything – это поисковая программа для Windows, мгновенно отыскивающая файлы и папки по их именам.\nВ отличие от встроенной в Windows поисковой системы, Everything изначально показывает каждый файл и папку в компьютере (отсюда и название \"Everything\", т.е. \"все\").\nВы вводите поисковый фильтр, после чего отображаются только нужные вам файлы и папки.",
                //   "packageAuthor": "https://github.com/unixshaman",
                //   "downloadPath": "https://www.voidtools.com/Everything-1.4.1.1022.x64.zip",
                //   "originalPackageName": "Everything-1.4.1.1022.x64.zip",
                //   "website": "https://www.voidtools.com/ru-ru/",
                //   "packageDirs": "apps\nbin\ninstall\nbin\\Everything\ninstall\\Everything\n",
                //   "packageFiles": "apps\\Everything.bat\nbin\\Everything\\Everything.db\nbin\\Everything\\Everything.exe\nbin\\Everything\\Everything.ini\nbin\\Everything\\Everything.lng\ninstall\\Everything\\category.txt\ninstall\\Everything\\changelog.txt\ninstall\\Everything\\contextMenu.txt\ninstall\\Everything\\dependencies.txt\ninstall\\Everything\\description.txt\ninstall\\Everything\\downloadPath.txt\ninstall\\Everything\\originalPackageName.txt\ninstall\\Everything\\packageAuthor.txt\ninstall\\Everything\\website.txt\ninstall\\Everything\\_packageDirs.txt\ninstall\\Everything\\_packageFiles.txt\ninstall\\Everything\\_packageSourceSize.txt\ninstall\\Everything\\_packageVersion.txt\n",
                //   "packageSize": "1,5 Мб",
                //   "packageSourceSize": "3,1 Мб\n",
                //   "packageVersion": "1.4.1.1022\n",
                //   "name": "Everything\n"
                // }
                string remotePackageInfo = await Downloader.GetPageContentAsync(packageUrl);

                // Десериализация json текста в объект пакета
                PackageInfo pi = JsonConvert.DeserializeObject<PackageInfo>(remotePackageInfo);

                // Добавить в список пакетов
                packages.Add(pi);
            }

            return packages;
        }
    }
}
