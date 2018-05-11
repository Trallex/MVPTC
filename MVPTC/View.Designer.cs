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
            this.components = new System.ComponentModel.Container();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pannel2 = new MVPTC.Pannel();
            this.pannel1 = new MVPTC.Pannel();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(191, 487);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(100, 28);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ClickAction);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(403, 487);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(100, 28);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.ClickAction);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(603, 487);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ClickAction);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pannel2
            // 
            this.pannel2.CurrentPath = "";
            this.pannel2.Directories = null;
            this.pannel2.Drives = null;
            this.pannel2.Location = new System.Drawing.Point(499, 15);
            this.pannel2.Margin = new System.Windows.Forms.Padding(5);
            this.pannel2.Name = "pannel2";
            this.pannel2.Selected = null;
            this.pannel2.Size = new System.Drawing.Size(412, 465);
            this.pannel2.TabIndex = 1;
            // 
            // pannel1
            // 
            this.pannel1.CurrentPath = "";
            this.pannel1.Directories = null;
            this.pannel1.Drives = null;
            this.pannel1.Location = new System.Drawing.Point(16, 15);
            this.pannel1.Margin = new System.Windows.Forms.Padding(5);
            this.pannel1.Name = "pannel1";
            this.pannel1.Selected = null;
            this.pannel1.Size = new System.Drawing.Size(412, 465);
            this.pannel1.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(777, 493);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 17);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "Error:";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 561);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.pannel2);
            this.Controls.Add(this.pannel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "View";
            this.Text = "JK MVP TC ";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pannel pannel1;
        private Pannel pannel2;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelError;
    }
}

