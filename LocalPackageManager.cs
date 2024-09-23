using System;
using System.Collections.Generic;
using System.IO;

namespace CerediraPackageManagerUI
{
    /// <summary>
    /// Менеджер локальных пакетов. Методы для работы с установленными пакетами,
    /// которые находятся в каталоге установки.
    /// </summary>
    public partial class LocalPackageManager
    {
        /// <summary>
        /// Получение списка каталогов из указанного каталога
        /// </summary>
        /// <param name="directoryPath">Каталог для получения подкаталогов</param>
        /// <returns>Список подкаталогов</returns>
        /// <exception cref="Exception">Ошибки работы с ФС</exception>
        public static string[] GetDirectories(string directoryPath)
        {
            try
            {
                // Получить все каталоги внутри каталога
                return Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories);
            }
            catch (DirectoryNotFoundException)
            {
                //throw new Exception($"Каталог '{directoryPath}' не существует.");
                return new string[0];
            }
            catch (UnauthorizedAccessException)
            {
                //throw new Exception($"Нет доступа к каталогу '{directoryPath}'.");
                return new string[0];
            }
        }

        /// <summary>
        /// Метод получения списка установленных в каталоге пакетов, метаданные пакета парсятся
        /// из файлов пакета в каталоге install
        /// </summary>
        /// <returns>Список установленных пакетов</returns>
        public static List<PackageInfo> GetPackages()
        {
            List<PackageInfo> packages = new List<PackageInfo>();

            // Ищем пакеты в каталоге install
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "install");

            // Получаем все подкаталоги
            string[] directories = GetDirectories(directoryPath);

            // Каждый подкаталог - это пакет
            foreach (var dir in directories)
            {
                // Получение аттрибутов каталога или файла
                FileAttributes attr = File.GetAttributes(dir);

                // Определение, что данная сущность - каталог
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    // Создание сущности пакета
                    PackageInfo pi = new PackageInfo
                    {
                        Name = Path.GetFileName(dir),

                        // Все содержимое из файла добавляем в поле сущности пакета
                        Changelog = File.ReadAllText(Path.Combine(dir, "changelog.txt")),
                        Description = File.ReadAllText(Path.Combine(dir, "description.txt")),
                        DownloadPath = File.ReadAllText(Path.Combine(dir, "downloadPath.txt")),
                        OriginalPackageName = File.ReadAllText(Path.Combine(dir, "originalPackageName.txt")),
                        PackageAuthor = File.ReadAllText(Path.Combine(dir, "packageAuthor.txt")),
                        PackageDirs = File.ReadAllText(Path.Combine(dir, "_packageDirs.txt")),
                        PackageFiles = File.ReadAllText(Path.Combine(dir, "_packageFiles.txt")),
                        PackageSourceSize = File.ReadAllText(Path.Combine(dir, "_packageSourceSize.txt")),
                        PackageVersion = File.ReadAllText(Path.Combine(dir, "_packageVersion.txt")),
                        Website = File.ReadAllText(Path.Combine(dir, "website.txt")),

                        AllowUninstall = true,
                        Installed = true
                    };

                    // Добавить в список пакетов
                    packages.Add(pi);
                }
            }

            return packages;
        }
    }
}
