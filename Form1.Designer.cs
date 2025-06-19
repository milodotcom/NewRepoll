namespace ll
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delegateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lambdaExpressionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builtinDelegatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practiceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delegateToolStripMenuItem,
            this.lambdaExpressionsToolStripMenuItem,
            this.builtinDelegatesToolStripMenuItem});
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.practiceToolStripMenuItem.Text = "Practice";
            this.practiceToolStripMenuItem.Click += new System.EventHandler(this.practiceToolStripMenuItem_Click);
            // 
            // delegateToolStripMenuItem
            // 
            this.delegateToolStripMenuItem.Name = "delegateToolStripMenuItem";
            this.delegateToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.delegateToolStripMenuItem.Text = "Delegate";
            this.delegateToolStripMenuItem.Click += new System.EventHandler(this.delegateToolStripMenuItem_Click);
            // 
            // lambdaExpressionsToolStripMenuItem
            // 
            this.lambdaExpressionsToolStripMenuItem.Name = "lambdaExpressionsToolStripMenuItem";
            this.lambdaExpressionsToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.lambdaExpressionsToolStripMenuItem.Text = "Lambda Expressions";
            // 
            // builtinDelegatesToolStripMenuItem
            // 
            this.builtinDelegatesToolStripMenuItem.Name = "builtinDelegatesToolStripMenuItem";
            this.builtinDelegatesToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.builtinDelegatesToolStripMenuItem.Text = "Built-in Delegates";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ll.Properties.Resources.IMG_1712;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delegateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lambdaExpressionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem builtinDelegatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

