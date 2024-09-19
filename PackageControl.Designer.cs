namespace CerediraPackageManagerUI
{
    partial class PackageControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deletePackage = new System.Windows.Forms.Button();
            this.installPackage = new System.Windows.Forms.Button();
            this.packageTags = new System.Windows.Forms.FlowLayoutPanel();
            this.packageAuthor = new System.Windows.Forms.Label();
            this.packageWebsite = new System.Windows.Forms.LinkLabel();
            this.packageName = new System.Windows.Forms.Label();
            this.packageIcon = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.packageDescriptionTab = new System.Windows.Forms.TabPage();
            this.packageDescription = new System.Windows.Forms.RichTextBox();
            this.packageChangelogTab = new System.Windows.Forms.TabPage();
            this.packageChangelog = new System.Windows.Forms.RichTextBox();
            this.packageAdditionalInfoTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.infoPackageSize = new System.Windows.Forms.Label();
            this.infoPackageSizeLabel = new System.Windows.Forms.Label();
            this.infoPackageSourceSize = new System.Windows.Forms.Label();
            this.infoPackageSourceSizeLabel = new System.Windows.Forms.Label();
            this.infoOriginalPackageName = new System.Windows.Forms.Label();
            this.infoOriginalPackageNameLabel = new System.Windows.Forms.Label();
            this.infoDownloadPath = new System.Windows.Forms.Label();
            this.infoDownloadPathLabel = new System.Windows.Forms.Label();
            this.infoWebsite = new System.Windows.Forms.Label();
            this.infoWebsiteLabel = new System.Windows.Forms.Label();
            this.infoPackageAuthor = new System.Windows.Forms.Label();
            this.infoPackageAuthorLabel = new System.Windows.Forms.Label();
            this.infoPackageVersion = new System.Windows.Forms.Label();
            this.infoPackageVersionLabel = new System.Windows.Forms.Label();
            this.infoPackageName = new System.Windows.Forms.Label();
            this.infoPackageNameLabel = new System.Windows.Forms.Label();
            this.packageFilesTab = new System.Windows.Forms.TabPage();
            this.packageFiles = new System.Windows.Forms.RichTextBox();
            this.packageDependenciesTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageIcon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.packageDescriptionTab.SuspendLayout();
            this.packageChangelogTab.SuspendLayout();
            this.packageAdditionalInfoTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.packageFilesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deletePackage);
            this.splitContainer1.Panel1.Controls.Add(this.installPackage);
            this.splitContainer1.Panel1.Controls.Add(this.packageTags);
            this.splitContainer1.Panel1.Controls.Add(this.packageAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.packageWebsite);
            this.splitContainer1.Panel1.Controls.Add(this.packageName);
            this.splitContainer1.Panel1.Controls.Add(this.packageIcon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(500, 500);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 2;
            // 
            // deletePackage
            // 
            this.deletePackage.BackColor = System.Drawing.SystemColors.Control;
            this.deletePackage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deletePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePackage.Location = new System.Drawing.Point(121, 150);
            this.deletePackage.Name = "deletePackage";
            this.deletePackage.Size = new System.Drawing.Size(100, 35);
            this.deletePackage.TabIndex = 10;
            this.deletePackage.Text = "Удалить";
            this.deletePackage.UseVisualStyleBackColor = false;
            this.deletePackage.Click += new System.EventHandler(this.deletePackage_Click);
            // 
            // installPackage
            // 
            this.installPackage.BackColor = System.Drawing.SystemColors.Control;
            this.installPackage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.installPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.installPackage.Location = new System.Drawing.Point(15, 150);
            this.installPackage.Name = "installPackage";
            this.installPackage.Size = new System.Drawing.Size(100, 35);
            this.installPackage.TabIndex = 9;
            this.installPackage.Text = "Установить";
            this.installPackage.UseVisualStyleBackColor = false;
            // 
            // packageTags
            // 
            this.packageTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.packageTags.Location = new System.Drawing.Point(15, 81);
            this.packageTags.Name = "packageTags";
            this.packageTags.Size = new System.Drawing.Size(469, 53);
            this.packageTags.TabIndex = 8;
            // 
            // packageAuthor
            // 
            this.packageAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.packageAuthor.Location = new System.Drawing.Point(91, 59);
            this.packageAuthor.Name = "packageAuthor";
            this.packageAuthor.Size = new System.Drawing.Size(393, 19);
            this.packageAuthor.TabIndex = 7;
            this.packageAuthor.Text = "packageAuthor";
            // 
            // packageWebsite
            // 
            this.packageWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.packageWebsite.Location = new System.Drawing.Point(91, 39);
            this.packageWebsite.Name = "packageWebsite";
            this.packageWebsite.Size = new System.Drawing.Size(393, 20);
            this.packageWebsite.TabIndex = 6;
            this.packageWebsite.TabStop = true;
            this.packageWebsite.Text = "packageSiteLink";
            // 
            // packageName
            // 
            this.packageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageName.Location = new System.Drawing.Point(90, 15);
            this.packageName.Name = "packageName";
            this.packageName.Size = new System.Drawing.Size(394, 20);
            this.packageName.TabIndex = 5;
            this.packageName.Text = "packageName packageVersion";
            // 
            // packageIcon
            // 
            this.packageIcon.Image = global::CerediraPackageManagerUI.Properties.Resources.box_package_icon;
            this.packageIcon.Location = new System.Drawing.Point(15, 15);
            this.packageIcon.Name = "packageIcon";
            this.packageIcon.Size = new System.Drawing.Size(60, 60);
            this.packageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.packageIcon.TabIndex = 4;
            this.packageIcon.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.packageDescriptionTab);
            this.tabControl1.Controls.Add(this.packageChangelogTab);
            this.tabControl1.Controls.Add(this.packageAdditionalInfoTab);
            this.tabControl1.Controls.Add(this.packageFilesTab);
            this.tabControl1.Controls.Add(this.packageDependenciesTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // packageDescriptionTab
            // 
            this.packageDescriptionTab.Controls.Add(this.packageDescription);
            this.packageDescriptionTab.Location = new System.Drawing.Point(4, 25);
            this.packageDescriptionTab.Name = "packageDescriptionTab";
            this.packageDescriptionTab.Padding = new System.Windows.Forms.Padding(3);
            this.packageDescriptionTab.Size = new System.Drawing.Size(492, 267);
            this.packageDescriptionTab.TabIndex = 0;
            this.packageDescriptionTab.Text = "Описание";
            this.packageDescriptionTab.UseVisualStyleBackColor = true;
            // 
            // packageDescription
            // 
            this.packageDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageDescription.Location = new System.Drawing.Point(3, 3);
            this.packageDescription.Name = "packageDescription";
            this.packageDescription.ReadOnly = true;
            this.packageDescription.Size = new System.Drawing.Size(486, 261);
            this.packageDescription.TabIndex = 0;
            this.packageDescription.Text = "packageDescription";
            // 
            // packageChangelogTab
            // 
            this.packageChangelogTab.Controls.Add(this.packageChangelog);
            this.packageChangelogTab.Location = new System.Drawing.Point(4, 25);
            this.packageChangelogTab.Name = "packageChangelogTab";
            this.packageChangelogTab.Padding = new System.Windows.Forms.Padding(3);
            this.packageChangelogTab.Size = new System.Drawing.Size(492, 267);
            this.packageChangelogTab.TabIndex = 1;
            this.packageChangelogTab.Text = "Изменения";
            this.packageChangelogTab.UseVisualStyleBackColor = true;
            // 
            // packageChangelog
            // 
            this.packageChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageChangelog.Location = new System.Drawing.Point(3, 3);
            this.packageChangelog.Name = "packageChangelog";
            this.packageChangelog.ReadOnly = true;
            this.packageChangelog.Size = new System.Drawing.Size(486, 261);
            this.packageChangelog.TabIndex = 0;
            this.packageChangelog.Text = "packageChangelog";
            // 
            // packageAdditionalInfoTab
            // 
            this.packageAdditionalInfoTab.Controls.Add(this.tableLayoutPanel1);
            this.packageAdditionalInfoTab.Location = new System.Drawing.Point(4, 25);
            this.packageAdditionalInfoTab.Name = "packageAdditionalInfoTab";
            this.packageAdditionalInfoTab.Size = new System.Drawing.Size(492, 267);
            this.packageAdditionalInfoTab.TabIndex = 2;
            this.packageAdditionalInfoTab.Text = "Подробности";
            this.packageAdditionalInfoTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.infoPackageSize, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.infoPackageSizeLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.infoPackageSourceSize, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.infoPackageSourceSizeLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.infoOriginalPackageName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.infoOriginalPackageNameLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.infoDownloadPath, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.infoDownloadPathLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.infoWebsite, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.infoWebsiteLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.infoPackageAuthor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.infoPackageAuthorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.infoPackageVersion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.infoPackageVersionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.infoPackageName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.infoPackageNameLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 267);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // infoPackageSize
            // 
            this.infoPackageSize.AutoSize = true;
            this.infoPackageSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPackageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPackageSize.Location = new System.Drawing.Point(152, 208);
            this.infoPackageSize.Margin = new System.Windows.Forms.Padding(5);
            this.infoPackageSize.Name = "infoPackageSize";
            this.infoPackageSize.Size = new System.Drawing.Size(335, 19);
            this.infoPackageSize.TabIndex = 15;
            this.infoPackageSize.Text = "Размер архива значение";
            // 
            // infoPackageSizeLabel
            // 
            this.infoPackageSizeLabel.AutoSize = true;
            this.infoPackageSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPackageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPackageSizeLabel.Location = new System.Drawing.Point(5, 208);
            this.infoPackageSizeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.infoPackageSizeLabel.Name = "infoPackageSizeLabel";
            this.infoPackageSizeLabel.Size = new System.Drawing.Size(137, 19);
            this.infoPackageSizeLabel.TabIndex = 14;
            this.infoPackageSizeLabel.Text = "Размер архива";
            // 
            // infoPackageSourceSize
            // 
            this.infoPackageSourceSize.AutoSize = true;
            this.infoPackageSourceSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPackageSourceSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPackageSourceSize.Location = new System.Drawing.Point(152, 179);
            this.infoPackageSourceSize.Margin = new System.Windows.Forms.Padding(5);
            this.infoPackageSourceSize.Name = "infoPackageSourceSize";
            this.infoPackageSourceSize.Size = new System.Drawing.Size(335, 19);
            this.infoPackageSourceSize.TabIndex = 13;
            this.infoPackageSourceSize.Text = "Размер распаковки значение";
            // 
            // infoPackageSourceSizeLabel
            // 
            this.infoPackageSourceSizeLabel.AutoSize = true;
            this.infoPackageSourceSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPackageSourceSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPackageSourceSizeLabel.Location = new System.Drawing.Point(5, 179);
            this.infoPackageSourceSizeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.infoPackageSourceSizeLabel.Name = "infoPackageSourceSizeLabel";
            this.infoPackageSourceSizeLabel.Size = new System.Drawing.Size(137, 19);
            this.infoPackageSourceSizeLabel.TabIndex = 12;
            this.infoPackageSourceSizeLabel.Text = "Размер распаковки";
            // 
            // infoOriginalPackageName
            // 
            this.infoOriginalPackageName.AutoSize = true;
            this.infoOriginalPackageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoOriginalPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoOriginalPackageName.Location = new System.Drawing.Point(152, 150);
            this.infoOriginalPackageName.Margin = new System.Windows.Forms.Padding(5);
            this.infoOriginalPackageName.Name = "infoOriginalPackageName";
            this.infoOriginalPackageName.Size = new System.Drawing.Size(335, 19);
            this.infoOriginalPackageName.TabIndex = 11;
            this.infoOriginalPackageName.Text = "Исходное имя пакета значение";
            // 
            // infoOriginalPackageNameLabel
            // 
            this.infoOriginalPackageNameLabel.AutoSize = true;
            this.infoOriginalPackageNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoOriginalPackageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoOriginalPackageNameLabel.Location = new System.Drawing.Point(5, 150);
            this.infoOriginalPackageNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.infoOriginalPackageNameLabel.Name = "infoOriginalPackageNameLabel";
            this.infoOriginalPackageNameLabel.Size = new System.Drawing.Size(137, 19);
            this.infoOriginalPackageNameLabel.TabIndex = 10;
            this.infoOriginalPackageNameLabel.Text = "Исходное имя пакета";
            // 
            // infoDownloadPath
            // 
            this.infoDownloadPath.AutoSize = true;
            this.infoDownloadPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoDownloadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoDownloadPath.Location = new System.Drawing.Point(152, 121);
            this.infoDownloadPath.Margin = new System.Windows.Forms.Padding(5);
            this.infoDownloadPath.Name = "infoDownloadPath";
            this.infoDownloadPath.Size = new System.Drawing.Size(335, 19);
            this.infoDownloadPath.TabIndex = 9;
            this.infoDownloadPath.Text = "Адрес скачивания значение";
            // 
            // infoDownloadPathLabel
            // 
            this.infoDownloadPathLabel.AutoSize = true;
            this.infoDownloadPathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoDownloadPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoDownloadPathLabel.Location = new System.Drawing.Point(5, 121);
            this.infoDownloadPathLabel.Margin = new System.Windows.Forms.Padding(5);
            this.infoDownloadPathLabel.Name = "infoDownloadPathLabel";
            this.infoDownloadPathLabel.Size = new System.Drawing.Size(137, 19);
            this.infoDownloadPathLabel.TabIndex = 8;
            this.infoDownloadPathLabel.Text = "Адрес скачивания";
            // 
            // infoWebsite
            // 
            this.infoWebsite.AutoSize = true;
            this.infoWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoWebsite.Location = new System.Drawing.Point(152, 92);
            this.infoWebsite.Margin = new System.Windows.Forms.Padding(5);
            this.infoWebsite.Name = "infoWebsite";
            this.infoWebsite.Size = new System.Drawing.Size(335, 19);
            this.infoWebsite.TabIndex = 7;
            this.infoWebsite.Text = "Веб-сайт значение";
            // 
            // infoWebsiteLabel
            // 
            this.infoWebsiteLabel.AutoSize = true;
            this.infoWebsiteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoWebsiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoWebsiteLabel.Location = new System.Drawing.Point(5, 92);
            this.infoWebsiteLabel.Margin = new System.Windows.Forms.Padding(5);
            this.infoWebsiteLabel.Name = "infoWebsiteLabel";
            this.infoWebsiteLabel.Size = new System.Drawing.Size(137, 19);
            this.infoWebsiteLabel.TabIndex = 6;
            this.infoWebsiteLabel.Text = "Веб-сайт";
            // 
            // infoPackageAuthor
            // 
            this.infoPackageAuthor.AutoSize = true;
            this.infoPackageAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPackageAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPackageAuthor.Location = new System.Drawing.Point(152, 63);
            this.infoPackageAuthor.Margin = new System.Windows.Forms.Padding(5);
            this.infoPackageAuthor.Name = "infoPackageAuthor";
            this.infoPackageAuthor.Size = new System.Drawing.Size(335, 19);
            this.infoPackageAuthor.TabIndex = 5;
            this.infoPackageAuthor.Text = "Автор пакета значение";
            // 
            // infoPackageAuthorLabel
            // 
            this.infoPackageAuthorLabel.AutoSize = true;
            this.infoPackageAuthorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPackageAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPackageAuthorLabel.Location = new System.Drawing.Point(5, 63);
            this.infoPackageAuthorLabel.Margin = new System.Windows.Forms.Padding(5);
            this.infoPackageAuthorLabel.Name = "infoPackageAuthorLabel";
            this.infoPackageAuthorLabel.Size = new System.Drawing.Size(137, 19);
            this.infoPackageAuthorLabel.TabIndex = 4;
            this.infoPackageAuthorLabel.Text = "Автор пакета";
            // 
            // infoPackageVersion
            // 
            this.infoPackageVersion.AutoSize = true;
            this.infoPackageVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPackageVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPackageVersion.Location = new System.Drawing.Point(152, 34);
            this.infoPackageVersion.Margin = new System.Windows.Forms.Padding(5);
            this.infoPackageVersion.Name = "infoPackageVersion";
            this.infoPackageVersion.Size = new System.Drawing.Size(335, 19);
            this.infoPackageVersion.TabIndex = 3;
            this.infoPackageVersion.Text = "Версия пакета значение";
            // 
            // infoPackageVersionLabel
            // 
            this.infoPackageVersionLabel.AutoSize = true;
            this.infoPackageVersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPackageVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPackageVersionLabel.Location = new System.Drawing.Point(5, 34);
            this.infoPackageVersionLabel.Margin = new System.Windows.Forms.Padding(5);
            this.infoPackageVersionLabel.Name = "infoPackageVersionLabel";
            this.infoPackageVersionLabel.Size = new System.Drawing.Size(137, 19);
            this.infoPackageVersionLabel.TabIndex = 2;
            this.infoPackageVersionLabel.Text = "Версия пакета";
            // 
            // infoPackageName
            // 
            this.infoPackageName.AutoSize = true;
            this.infoPackageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPackageName.Location = new System.Drawing.Point(152, 5);
            this.infoPackageName.Margin = new System.Windows.Forms.Padding(5);
            this.infoPackageName.Name = "infoPackageName";
            this.infoPackageName.Size = new System.Drawing.Size(335, 19);
            this.infoPackageName.TabIndex = 1;
            this.infoPackageName.Text = "Имя пакета значение";
            // 
            // infoPackageNameLabel
            // 
            this.infoPackageNameLabel.AutoSize = true;
            this.infoPackageNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPackageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPackageNameLabel.Location = new System.Drawing.Point(5, 5);
            this.infoPackageNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.infoPackageNameLabel.Name = "infoPackageNameLabel";
            this.infoPackageNameLabel.Size = new System.Drawing.Size(137, 19);
            this.infoPackageNameLabel.TabIndex = 0;
            this.infoPackageNameLabel.Text = "Имя пакета";
            // 
            // packageFilesTab
            // 
            this.packageFilesTab.Controls.Add(this.packageFiles);
            this.packageFilesTab.Location = new System.Drawing.Point(4, 25);
            this.packageFilesTab.Name = "packageFilesTab";
            this.packageFilesTab.Size = new System.Drawing.Size(492, 267);
            this.packageFilesTab.TabIndex = 3;
            this.packageFilesTab.Text = "Файлы пакета";
            this.packageFilesTab.UseVisualStyleBackColor = true;
            // 
            // packageFiles
            // 
            this.packageFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageFiles.Location = new System.Drawing.Point(0, 0);
            this.packageFiles.Name = "packageFiles";
            this.packageFiles.ReadOnly = true;
            this.packageFiles.Size = new System.Drawing.Size(492, 267);
            this.packageFiles.TabIndex = 1;
            this.packageFiles.Text = "packageFiles";
            // 
            // packageDependenciesTab
            // 
            this.packageDependenciesTab.Location = new System.Drawing.Point(4, 25);
            this.packageDependenciesTab.Name = "packageDependenciesTab";
            this.packageDependenciesTab.Padding = new System.Windows.Forms.Padding(3);
            this.packageDependenciesTab.Size = new System.Drawing.Size(492, 267);
            this.packageDependenciesTab.TabIndex = 4;
            this.packageDependenciesTab.Text = "Зависимости";
            this.packageDependenciesTab.UseVisualStyleBackColor = true;
            // 
            // PackageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PackageControl";
            this.Size = new System.Drawing.Size(500, 500);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packageIcon)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.packageDescriptionTab.ResumeLayout(false);
            this.packageChangelogTab.ResumeLayout(false);
            this.packageAdditionalInfoTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.packageFilesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox packageIcon;
        private System.Windows.Forms.Label packageName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage packageDescriptionTab;
        private System.Windows.Forms.TabPage packageChangelogTab;
        private System.Windows.Forms.TabPage packageAdditionalInfoTab;
        private System.Windows.Forms.Label packageAuthor;
        private System.Windows.Forms.LinkLabel packageWebsite;
        private System.Windows.Forms.Button deletePackage;
        private System.Windows.Forms.Button installPackage;
        private System.Windows.Forms.FlowLayoutPanel packageTags;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label infoDownloadPath;
        private System.Windows.Forms.Label infoDownloadPathLabel;
        private System.Windows.Forms.Label infoWebsite;
        private System.Windows.Forms.Label infoWebsiteLabel;
        private System.Windows.Forms.Label infoPackageAuthor;
        private System.Windows.Forms.Label infoPackageAuthorLabel;
        private System.Windows.Forms.Label infoPackageVersion;
        private System.Windows.Forms.Label infoPackageVersionLabel;
        private System.Windows.Forms.Label infoPackageName;
        private System.Windows.Forms.Label infoPackageNameLabel;
        private System.Windows.Forms.Label infoPackageSize;
        private System.Windows.Forms.Label infoPackageSizeLabel;
        private System.Windows.Forms.Label infoPackageSourceSize;
        private System.Windows.Forms.Label infoPackageSourceSizeLabel;
        private System.Windows.Forms.Label infoOriginalPackageName;
        private System.Windows.Forms.Label infoOriginalPackageNameLabel;
        private System.Windows.Forms.TabPage packageFilesTab;
        private System.Windows.Forms.RichTextBox packageFiles;
        private System.Windows.Forms.RichTextBox packageDescription;
        private System.Windows.Forms.RichTextBox packageChangelog;
        private System.Windows.Forms.TabPage packageDependenciesTab;
    }
}
