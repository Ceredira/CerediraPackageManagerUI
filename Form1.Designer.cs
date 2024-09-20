namespace CerediraPackageManagerUI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.installedPackageList = new System.Windows.Forms.FlowLayoutPanel();
            this.packageShortControl1 = new CerediraPackageManagerUI.PackageShortControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.remoteRepositoryUrl = new System.Windows.Forms.TextBox();
            this.remoteRepositoryUrlLabel = new System.Windows.Forms.Label();
            this.updateRemotePackages = new System.Windows.Forms.Button();
            this.availablePackageList = new System.Windows.Forms.FlowLayoutPanel();
            this.packageControl = new CerediraPackageManagerUI.PackageControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.updateLocalPackages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rootPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.installedPackageList.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1MinSize = 500;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.packageControl);
            this.splitContainer1.Panel2MinSize = 500;
            this.splitContainer1.Size = new System.Drawing.Size(1084, 462);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.installedPackageList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Установленные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // installedPackageList
            // 
            this.installedPackageList.AutoScroll = true;
            this.installedPackageList.Controls.Add(this.packageShortControl1);
            this.installedPackageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installedPackageList.Location = new System.Drawing.Point(3, 3);
            this.installedPackageList.Name = "installedPackageList";
            this.installedPackageList.Size = new System.Drawing.Size(526, 428);
            this.installedPackageList.TabIndex = 0;
            // 
            // packageShortControl1
            // 
            this.packageShortControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageShortControl1.Location = new System.Drawing.Point(3, 3);
            this.packageShortControl1.MinimumSize = new System.Drawing.Size(500, 100);
            this.packageShortControl1.Name = "packageShortControl1";
            this.packageShortControl1.Size = new System.Drawing.Size(500, 100);
            this.packageShortControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Доступные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.availablePackageList);
            this.splitContainer3.Size = new System.Drawing.Size(526, 428);
            this.splitContainer3.SplitterDistance = 45;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.remoteRepositoryUrl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.remoteRepositoryUrlLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.updateRemotePackages, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(526, 45);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // remoteRepositoryUrl
            // 
            this.remoteRepositoryUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteRepositoryUrl.Location = new System.Drawing.Point(3, 22);
            this.remoteRepositoryUrl.Name = "remoteRepositoryUrl";
            this.remoteRepositoryUrl.Size = new System.Drawing.Size(388, 20);
            this.remoteRepositoryUrl.TabIndex = 0;
            this.remoteRepositoryUrl.Text = "https://localhost:11443";
            // 
            // remoteRepositoryUrlLabel
            // 
            this.remoteRepositoryUrlLabel.AutoSize = true;
            this.remoteRepositoryUrlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteRepositoryUrlLabel.Location = new System.Drawing.Point(3, 3);
            this.remoteRepositoryUrlLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.remoteRepositoryUrlLabel.Name = "remoteRepositoryUrlLabel";
            this.remoteRepositoryUrlLabel.Size = new System.Drawing.Size(388, 16);
            this.remoteRepositoryUrlLabel.TabIndex = 1;
            this.remoteRepositoryUrlLabel.Text = "Адрес репозитория:";
            // 
            // updateRemotePackages
            // 
            this.updateRemotePackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateRemotePackages.Location = new System.Drawing.Point(404, 10);
            this.updateRemotePackages.Margin = new System.Windows.Forms.Padding(10);
            this.updateRemotePackages.Name = "updateRemotePackages";
            this.tableLayoutPanel2.SetRowSpan(this.updateRemotePackages, 2);
            this.updateRemotePackages.Size = new System.Drawing.Size(112, 25);
            this.updateRemotePackages.TabIndex = 2;
            this.updateRemotePackages.Text = "Обновить";
            this.updateRemotePackages.UseVisualStyleBackColor = true;
            this.updateRemotePackages.Click += new System.EventHandler(this.updateRemotePackages_Click);
            // 
            // availablePackageList
            // 
            this.availablePackageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availablePackageList.Location = new System.Drawing.Point(0, 0);
            this.availablePackageList.Name = "availablePackageList";
            this.availablePackageList.Size = new System.Drawing.Size(526, 379);
            this.availablePackageList.TabIndex = 0;
            // 
            // packageControl
            // 
            this.packageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageControl.Location = new System.Drawing.Point(0, 0);
            this.packageControl.Name = "packageControl";
            this.packageControl.Size = new System.Drawing.Size(536, 460);
            this.packageControl.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1084, 511);
            this.splitContainer2.SplitterDistance = 45;
            this.splitContainer2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.updateLocalPackages, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rootPath, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // updateLocalPackages
            // 
            this.updateLocalPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateLocalPackages.Location = new System.Drawing.Point(930, 10);
            this.updateLocalPackages.Margin = new System.Windows.Forms.Padding(10);
            this.updateLocalPackages.Name = "updateLocalPackages";
            this.updateLocalPackages.Size = new System.Drawing.Size(144, 25);
            this.updateLocalPackages.TabIndex = 0;
            this.updateLocalPackages.Text = "Обновить";
            this.updateLocalPackages.UseVisualStyleBackColor = true;
            this.updateLocalPackages.Click += new System.EventHandler(this.updateLocalPackages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каталог установки:";
            // 
            // rootPath
            // 
            this.rootPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPath.Location = new System.Drawing.Point(172, 10);
            this.rootPath.Margin = new System.Windows.Forms.Padding(10);
            this.rootPath.Name = "rootPath";
            this.rootPath.ReadOnly = true;
            this.rootPath.Size = new System.Drawing.Size(738, 20);
            this.rootPath.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.splitContainer2);
            this.MinimumSize = new System.Drawing.Size(1100, 550);
            this.Name = "Form1";
            this.Text = "CerediraPackageManagerUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.installedPackageList.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel installedPackageList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button updateLocalPackages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rootPath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox remoteRepositoryUrl;
        private System.Windows.Forms.Label remoteRepositoryUrlLabel;
        private System.Windows.Forms.Button updateRemotePackages;
        private System.Windows.Forms.FlowLayoutPanel availablePackageList;
        private PackageControl packageControl;
        private PackageShortControl packageShortControl1;
    }
}

