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
            ((System.ComponentModel.ISupportInitialize)(this.packageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // packageName
            // 
            this.packageName.AutoSize = true;
            this.packageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.packageName.Location = new System.Drawing.Point(90, 15);
            this.packageName.Name = "packageName";
            this.packageName.Size = new System.Drawing.Size(257, 20);
            this.packageName.TabIndex = 1;
            this.packageName.Text = "packageName packageVersion";
            this.packageName.Click += new System.EventHandler(this.packageName_Click);
            // 
            // packageDescription
            // 
            this.packageDescription.AutoSize = true;
            this.packageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.packageDescription.Location = new System.Drawing.Point(90, 40);
            this.packageDescription.Name = "packageDescription";
            this.packageDescription.Size = new System.Drawing.Size(129, 16);
            this.packageDescription.TabIndex = 2;
            this.packageDescription.Text = "packageDescription";
            // 
            // packageIcon
            // 
            this.packageIcon.Location = new System.Drawing.Point(15, 15);
            this.packageIcon.Name = "packageIcon";
            this.packageIcon.Size = new System.Drawing.Size(60, 60);
            this.packageIcon.TabIndex = 3;
            this.packageIcon.TabStop = false;
            // 
            // PackageShortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.packageIcon);
            this.Controls.Add(this.packageDescription);
            this.Controls.Add(this.packageName);
            this.MinimumSize = new System.Drawing.Size(500, 100);
            this.Name = "PackageShortControl";
            this.Size = new System.Drawing.Size(500, 100);
            this.Load += new System.EventHandler(this.PackageShortControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label packageName;
        private System.Windows.Forms.Label packageDescription;
        private System.Windows.Forms.PictureBox packageIcon;
    }
}
