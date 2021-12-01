namespace TeacherToolkit
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.floorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floor1RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floor2RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floor3RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Health Base 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(196, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // floorsToolStripMenuItem
            // 
            this.floorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floor1RoomsToolStripMenuItem,
            this.floor2RoomsToolStripMenuItem,
            this.floor3RoomsToolStripMenuItem});
            this.floorsToolStripMenuItem.Name = "floorsToolStripMenuItem";
            this.floorsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.floorsToolStripMenuItem.Text = "Floors";
            // 
            // floor1RoomsToolStripMenuItem
            // 
            this.floor1RoomsToolStripMenuItem.Name = "floor1RoomsToolStripMenuItem";
            this.floor1RoomsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.floor1RoomsToolStripMenuItem.Text = "Floor 1 Rooms";
            this.floor1RoomsToolStripMenuItem.Click += new System.EventHandler(this.floor1RoomsToolStripMenuItem_Click);
            // 
            // floor2RoomsToolStripMenuItem
            // 
            this.floor2RoomsToolStripMenuItem.Name = "floor2RoomsToolStripMenuItem";
            this.floor2RoomsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.floor2RoomsToolStripMenuItem.Text = "Floor 2 Rooms";
            this.floor2RoomsToolStripMenuItem.Click += new System.EventHandler(this.floor2RoomsToolStripMenuItem_Click);
            // 
            // floor3RoomsToolStripMenuItem
            // 
            this.floor3RoomsToolStripMenuItem.Name = "floor3RoomsToolStripMenuItem";
            this.floor3RoomsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.floor3RoomsToolStripMenuItem.Text = "Floor 3 Rooms";
            this.floor3RoomsToolStripMenuItem.Click += new System.EventHandler(this.floor3RoomsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ground Floor";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 204);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form5";
            this.Text = "Random seating plan ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem floorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floor1RoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floor2RoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floor3RoomsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}