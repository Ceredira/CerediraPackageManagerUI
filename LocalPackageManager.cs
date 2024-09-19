using System;
using System.Collections.Generic;
using System.IO;

namespace CerediraPackageManagerUI
{
    public partial class LocalPackageManager
    {
        public static string[] GetDirectories(string directoryPath)
        {
            try
            {
                return Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories);
            }
            catch (DirectoryNotFoundException)
            {
                throw new Exception($"Каталог '{directoryPath}' не существует.");
            }
            catch (UnauthorizedAccessException)
            {
                throw new Exception($"Нет доступа к каталогу '{directoryPath}'.");
            }
        }

        public static List<PackageInfo> GetPackages()
        {
            List<PackageInfo> packages = new List<PackageInfo>();
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "install");
            string[] directories = GetDirectories(directoryPath);

            foreach (var dir in directories)
            {
                // get the file attributes for file or directory
                FileAttributes attr = File.GetAttributes(dir);

                //detect whether its a directory or file
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    PackageInfo pi = new PackageInfo
                    {
                        Name = Path.GetFileName(dir),

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

                    packages.Add(pi);
                }
            }

            return packages;
        }
    }
}
