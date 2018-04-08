namespace MVPTC
{
    partial class Pannel
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
            this.comboBoxDrive = new System.Windows.Forms.ComboBox();
            this.listBoxComponents = new System.Windows.Forms.ListBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDrive
            // 
            this.comboBoxDrive.FormattingEnabled = true;
            this.comboBoxDrive.Location = new System.Drawing.Point(225, 45);
            this.comboBoxDrive.Name = "comboBoxDrive";
            this.comboBoxDrive.Size = new System.Drawing.Size(54, 21);
            this.comboBoxDrive.TabIndex = 0;
            this.comboBoxDrive.DropDown += new System.EventHandler(this.listDrives);
            this.comboBoxDrive.SelectedIndexChanged += new System.EventHandler(this.changeDrive);
            // 
            // listBoxComponents
            // 
            this.listBoxComponents.FormattingEnabled = true;
            this.listBoxComponents.Location = new System.Drawing.Point(29, 91);
            this.listBoxComponents.Name = "listBoxComponents";
            this.listBoxComponents.Size = new System.Drawing.Size(250, 251);
            this.listBoxComponents.TabIndex = 1;
            this.listBoxComponents.SelectedIndexChanged += new System.EventHandler(this.ItemSelect);
            this.listBoxComponents.DoubleClick += new System.EventHandler(this.ExecutePath);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(29, 15);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(250, 20);
            this.textBoxPath.TabIndex = 2;
            this.textBoxPath.TextChanged += new System.EventHandler(this.PathChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(29, 45);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = " ↑";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Pannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.listBoxComponents);
            this.Controls.Add(this.comboBoxDrive);
            this.Name = "Pannel";
            this.Size = new System.Drawing.Size(309, 378);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDrive;
        private System.Windows.Forms.ListBox listBoxComponents;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonBack;
    }
}
