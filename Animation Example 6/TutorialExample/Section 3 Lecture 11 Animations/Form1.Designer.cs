namespace Section_3_Lecture_11_Animations
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animateImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrowKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftMouseButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bufferingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Section_3_Lecture_11_Animations.Properties.Resources.landscape_3;
            this.pictureBox1.Location = new System.Drawing.Point(362, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animateImageToolStripMenuItem,
            this.changeImageToolStripMenuItem,
            this.bufferingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // animateImageToolStripMenuItem
            // 
            this.animateImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveImageToolStripMenuItem,
            this.resizeImageToolStripMenuItem,
            this.rotateImageToolStripMenuItem});
            this.animateImageToolStripMenuItem.Name = "animateImageToolStripMenuItem";
            this.animateImageToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.animateImageToolStripMenuItem.Text = "Animate Image";
            // 
            // moveImageToolStripMenuItem
            // 
            this.moveImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrowKeysToolStripMenuItem,
            this.leftMouseButtonToolStripMenuItem});
            this.moveImageToolStripMenuItem.Name = "moveImageToolStripMenuItem";
            this.moveImageToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.moveImageToolStripMenuItem.Text = "Move Image";
            // 
            // arrowKeysToolStripMenuItem
            // 
            this.arrowKeysToolStripMenuItem.Name = "arrowKeysToolStripMenuItem";
            this.arrowKeysToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.arrowKeysToolStripMenuItem.Text = "Arrow Keys";
            this.arrowKeysToolStripMenuItem.Click += new System.EventHandler(this.ArrowKeysToolStripMenuItem_Click);
            // 
            // leftMouseButtonToolStripMenuItem
            // 
            this.leftMouseButtonToolStripMenuItem.Name = "leftMouseButtonToolStripMenuItem";
            this.leftMouseButtonToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.leftMouseButtonToolStripMenuItem.Text = "Left Mouse Button";
            this.leftMouseButtonToolStripMenuItem.Click += new System.EventHandler(this.LeftMouseButtonToolStripMenuItem_Click);
            // 
            // resizeImageToolStripMenuItem
            // 
            this.resizeImageToolStripMenuItem.Name = "resizeImageToolStripMenuItem";
            this.resizeImageToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.resizeImageToolStripMenuItem.Text = "Resize Image";
            this.resizeImageToolStripMenuItem.Click += new System.EventHandler(this.ResizeImageToolStripMenuItem_Click);
            // 
            // rotateImageToolStripMenuItem
            // 
            this.rotateImageToolStripMenuItem.Name = "rotateImageToolStripMenuItem";
            this.rotateImageToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.rotateImageToolStripMenuItem.Text = "Rotate Image";
            this.rotateImageToolStripMenuItem.Click += new System.EventHandler(this.RotateImageToolStripMenuItem_Click);
            // 
            // changeImageToolStripMenuItem
            // 
            this.changeImageToolStripMenuItem.Name = "changeImageToolStripMenuItem";
            this.changeImageToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.changeImageToolStripMenuItem.Text = "Change Image";
            this.changeImageToolStripMenuItem.Click += new System.EventHandler(this.ChangeImageToolStripMenuItem_Click);
            // 
            // bufferingToolStripMenuItem
            // 
            this.bufferingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.doubleToolStripMenuItem});
            this.bufferingToolStripMenuItem.Name = "bufferingToolStripMenuItem";
            this.bufferingToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bufferingToolStripMenuItem.Text = "Buffering";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.singleToolStripMenuItem.Text = "Single";
            this.singleToolStripMenuItem.Click += new System.EventHandler(this.SingleToolStripMenuItem_Click);
            // 
            // doubleToolStripMenuItem
            // 
            this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            this.doubleToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.doubleToolStripMenuItem.Text = "Double";
            this.doubleToolStripMenuItem.Click += new System.EventHandler(this.DoubleToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(982, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Move an Object";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animateImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrowKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftMouseButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bufferingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

