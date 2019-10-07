namespace WinFormNorrisAPI
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
            this.CboCategory = new System.Windows.Forms.ComboBox();
            this.BtnQueryAPI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboCategory
            // 
            this.CboCategory.FormattingEnabled = true;
            this.CboCategory.Location = new System.Drawing.Point(6, 21);
            this.CboCategory.Name = "CboCategory";
            this.CboCategory.Size = new System.Drawing.Size(121, 21);
            this.CboCategory.TabIndex = 0;
            this.CboCategory.SelectedIndexChanged += new System.EventHandler(this.CboCategory_SelectedIndexChanged);
            // 
            // BtnQueryAPI
            // 
            this.BtnQueryAPI.Location = new System.Drawing.Point(133, 19);
            this.BtnQueryAPI.Name = "BtnQueryAPI";
            this.BtnQueryAPI.Size = new System.Drawing.Size(85, 23);
            this.BtnQueryAPI.TabIndex = 1;
            this.BtnQueryAPI.Text = "Search";
            this.BtnQueryAPI.UseVisualStyleBackColor = true;
            this.BtnQueryAPI.Click += new System.EventHandler(this.BtnQueryAPI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboCategory);
            this.groupBox1.Controls.Add(this.BtnQueryAPI);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 80);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Chuck Norris";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboCategory;
        private System.Windows.Forms.Button BtnQueryAPI;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

