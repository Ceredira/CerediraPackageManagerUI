﻿namespace CerediraPackageManagerUI
{
    public partial class PackageInfo
    {
        public string Name { get; set; }
        public string Changelog { get; set; }
        public string Description { get; set; }
        public string DownloadPath { get; set; }
        public string OriginalPackageName { get; set; }
        public string PackageAuthor { get; set; }
        public string PackageVersion { get; set; }
        public string Website { get; set; }
        public bool Installed { get; set; }
        public bool AllowUninstall { get; set; }
    }
}