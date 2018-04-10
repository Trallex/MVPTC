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
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pannel2 = new MVPTC.Pannel();
            this.pannel1 = new MVPTC.Pannel();
            this.SuspendLayout();
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(143, 396);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ClickAction);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(302, 396);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.ClickAction);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(452, 396);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ClickAction);
            // 
            // pannel2
            // 
            this.pannel2.CurrentPath = "";
            this.pannel2.Directories = null;
            this.pannel2.Drives = null;
            this.pannel2.Files = null;
            this.pannel2.Location = new System.Drawing.Point(374, 12);
            this.pannel2.Name = "pannel2";
            this.pannel2.Size = new System.Drawing.Size(309, 378);
            this.pannel2.TabIndex = 1;
            // 
            // pannel1
            // 
            this.pannel1.CurrentPath = "";
            this.pannel1.Directories = null;
            this.pannel1.Drives = null;
            this.pannel1.Files = null;
            this.pannel1.Location = new System.Drawing.Point(12, 12);
            this.pannel1.Name = "pannel1";
            this.pannel1.Size = new System.Drawing.Size(309, 378);
            this.pannel1.TabIndex = 0;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 456);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.pannel2);
            this.Controls.Add(this.pannel1);
            this.Name = "View";
            this.Text = "JK MVP TC ";
            this.ResumeLayout(false);

        }

        #endregion

        private Pannel pannel1;
        private Pannel pannel2;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonDelete;
    }
}

