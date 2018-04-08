namespace MVPTC
{
    partial class View
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
            this.pannel1 = new MVPTC.Pannel();
            this.pannel2 = new MVPTC.Pannel();
            this.SuspendLayout();
            // 
            // pannel1
            // 
            this.pannel1.Location = new System.Drawing.Point(12, 12);
            this.pannel1.Name = "pannel1";
            this.pannel1.Size = new System.Drawing.Size(309, 378);
            this.pannel1.TabIndex = 0;
            // 
            // pannel2
            // 
            this.pannel2.Location = new System.Drawing.Point(374, 12);
            this.pannel2.Name = "pannel2";
            this.pannel2.Size = new System.Drawing.Size(309, 378);
            this.pannel2.TabIndex = 1;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 456);
            this.Controls.Add(this.pannel2);
            this.Controls.Add(this.pannel1);
            this.Name = "View";
            this.Text = "JK MVP TC ";
            this.ResumeLayout(false);

        }

        #endregion

        private Pannel pannel1;
        private Pannel pannel2;
    }
}

