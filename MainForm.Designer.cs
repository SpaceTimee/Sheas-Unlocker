
namespace Sheas_Unlocker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UnlockButton = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.NavigateButton = new System.Windows.Forms.Button();
            this.RecurseCheckBox = new System.Windows.Forms.CheckBox();
            this.IgnoreCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UnlockButton
            // 
            this.UnlockButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UnlockButton.ForeColor = System.Drawing.Color.Black;
            this.UnlockButton.Location = new System.Drawing.Point(634, 12);
            this.UnlockButton.Margin = new System.Windows.Forms.Padding(0);
            this.UnlockButton.Name = "UnlockButton";
            this.UnlockButton.Size = new System.Drawing.Size(150, 46);
            this.UnlockButton.TabIndex = 2;
            this.UnlockButton.Text = "解锁";
            this.UnlockButton.UseVisualStyleBackColor = true;
            this.UnlockButton.Click += new System.EventHandler(this.UnlockButton_Click);
            // 
            // PathBox
            // 
            this.PathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PathBox.BackColor = System.Drawing.Color.White;
            this.PathBox.ForeColor = System.Drawing.Color.Black;
            this.PathBox.Location = new System.Drawing.Point(16, 16);
            this.PathBox.Margin = new System.Windows.Forms.Padding(0);
            this.PathBox.MaxLength = 260;
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(438, 38);
            this.PathBox.TabIndex = 0;
            // 
            // NavigateButton
            // 
            this.NavigateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NavigateButton.ForeColor = System.Drawing.Color.Black;
            this.NavigateButton.Location = new System.Drawing.Point(469, 12);
            this.NavigateButton.Margin = new System.Windows.Forms.Padding(0);
            this.NavigateButton.Name = "NavigateButton";
            this.NavigateButton.Size = new System.Drawing.Size(150, 46);
            this.NavigateButton.TabIndex = 1;
            this.NavigateButton.Text = "浏览";
            this.NavigateButton.UseVisualStyleBackColor = true;
            this.NavigateButton.Click += new System.EventHandler(this.NavigateButton_Click);
            // 
            // RecurseCheckBox
            // 
            this.RecurseCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RecurseCheckBox.AutoSize = true;
            this.RecurseCheckBox.Location = new System.Drawing.Point(799, 18);
            this.RecurseCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.RecurseCheckBox.Name = "RecurseCheckBox";
            this.RecurseCheckBox.Size = new System.Drawing.Size(166, 35);
            this.RecurseCheckBox.TabIndex = 3;
            this.RecurseCheckBox.Text = "遍历子目录";
            this.RecurseCheckBox.UseVisualStyleBackColor = true;
            // 
            // IgnoreCheckBox
            // 
            this.IgnoreCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IgnoreCheckBox.AutoSize = true;
            this.IgnoreCheckBox.Location = new System.Drawing.Point(969, 18);
            this.IgnoreCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.IgnoreCheckBox.Name = "IgnoreCheckBox";
            this.IgnoreCheckBox.Size = new System.Drawing.Size(142, 35);
            this.IgnoreCheckBox.TabIndex = 4;
            this.IgnoreCheckBox.Text = "禁用报错";
            this.IgnoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.UnlockButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 69);
            this.Controls.Add(this.IgnoreCheckBox);
            this.Controls.Add(this.RecurseCheckBox);
            this.Controls.Add(this.NavigateButton);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.UnlockButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 140);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sheas Unlocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnlockButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button NavigateButton;
        private System.Windows.Forms.CheckBox RecurseCheckBox;
        internal System.Windows.Forms.CheckBox IgnoreCheckBox;
    }
}

