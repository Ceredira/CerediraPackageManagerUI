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
            this.packageDescription = new System.Windows.Forms.Label();
            this.packageChangelogTab = new System.Windows.Forms.TabPage();
            this.packageChangelog = new System.Windows.Forms.Label();
            this.packageAdditionalInfo = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageIcon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.packageDescriptionTab.SuspendLayout();
            this.packageChangelogTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
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
            this.installPackage.Click += new System.EventHandler(this.installPackage_Click);
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
            this.tabControl1.Controls.Add(this.packageAdditionalInfo);
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
            this.packageChangelog.Size = new System.Drawing.Size(486, 261);
            this.packageChangelog.TabIndex = 0;
            this.packageChangelog.Text = "packageChangeLog";
            // 
            // packageAdditionalInfo
            // 
            this.packageAdditionalInfo.Location = new System.Drawing.Point(4, 25);
            this.packageAdditionalInfo.Name = "packageAdditionalInfo";
            this.packageAdditionalInfo.Size = new System.Drawing.Size(492, 267);
            this.packageAdditionalInfo.TabIndex = 2;
            this.packageAdditionalInfo.Text = "Подробности";
            this.packageAdditionalInfo.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox packageIcon;
        private System.Windows.Forms.Label packageName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage packageDescriptionTab;
        private System.Windows.Forms.TabPage packageChangelogTab;
        private System.Windows.Forms.Label packageDescription;
        private System.Windows.Forms.Label packageChangelog;
        private System.Windows.Forms.TabPage packageAdditionalInfo;
        private System.Windows.Forms.Label packageAuthor;
        private System.Windows.Forms.LinkLabel packageWebsite;
        private System.Windows.Forms.Button deletePackage;
        private System.Windows.Forms.Button installPackage;
        private System.Windows.Forms.FlowLayoutPanel packageTags;
    }
}
