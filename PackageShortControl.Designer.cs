namespace CerediraPackageManagerUI
{
    partial class PackageShortControl
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
            this.packageName = new System.Windows.Forms.Label();
            this.packageDescription = new System.Windows.Forms.Label();
            this.packageIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.packageIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // packageName
            // 
            this.packageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.packageName.Location = new System.Drawing.Point(112, 5);
            this.packageName.Margin = new System.Windows.Forms.Padding(5);
            this.packageName.Name = "packageName";
            this.packageName.Size = new System.Drawing.Size(383, 20);
            this.packageName.TabIndex = 1;
            this.packageName.Text = "packageName packageVersion";
            this.packageName.Click += new System.EventHandler(this.packageName_Click);
            // 
            // packageDescription
            // 
            this.packageDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.packageDescription.Location = new System.Drawing.Point(112, 35);
            this.packageDescription.Margin = new System.Windows.Forms.Padding(5);
            this.packageDescription.Name = "packageDescription";
            this.packageDescription.Size = new System.Drawing.Size(383, 60);
            this.packageDescription.TabIndex = 2;
            this.packageDescription.Text = "packageDescription";
            // 
            // packageIcon
            // 
            this.packageIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageIcon.Image = global::CerediraPackageManagerUI.Properties.Resources.box_package_icon;
            this.packageIcon.InitialImage = global::CerediraPackageManagerUI.Properties.Resources.box_package_icon;
            this.packageIcon.Location = new System.Drawing.Point(15, 15);
            this.packageIcon.Margin = new System.Windows.Forms.Padding(15);
            this.packageIcon.Name = "packageIcon";
            this.tableLayoutPanel1.SetRowSpan(this.packageIcon, 2);
            this.packageIcon.Size = new System.Drawing.Size(77, 70);
            this.packageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.packageIcon.TabIndex = 3;
            this.packageIcon.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.57258F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.42742F));
            this.tableLayoutPanel1.Controls.Add(this.packageDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.packageName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.packageIcon, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // PackageShortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 100);
            this.Name = "PackageShortControl";
            this.Size = new System.Drawing.Size(500, 100);
            this.Load += new System.EventHandler(this.PackageShortControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label packageName;
        private System.Windows.Forms.Label packageDescription;
        private System.Windows.Forms.PictureBox packageIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
