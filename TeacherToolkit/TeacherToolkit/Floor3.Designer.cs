namespace TeacherToolkit
{
    partial class Floor3
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
            this.floorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floor1RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floor2RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floor3RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(156, 24);
            this.menuStrip1.TabIndex = 11;
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
            this.floor1RoomsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.floor1RoomsToolStripMenuItem.Text = "Ground Floor Roooms";
            this.floor1RoomsToolStripMenuItem.Click += new System.EventHandler(this.floor1RoomsToolStripMenuItem_Click);
            // 
            // floor2RoomsToolStripMenuItem
            // 
            this.floor2RoomsToolStripMenuItem.Name = "floor2RoomsToolStripMenuItem";
            this.floor2RoomsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.floor2RoomsToolStripMenuItem.Text = "Floor 1 Rooms";
            this.floor2RoomsToolStripMenuItem.Click += new System.EventHandler(this.floor2RoomsToolStripMenuItem_Click);
            // 
            // floor3RoomsToolStripMenuItem
            // 
            this.floor3RoomsToolStripMenuItem.Name = "floor3RoomsToolStripMenuItem";
            this.floor3RoomsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.floor3RoomsToolStripMenuItem.Text = "Floor 2 Rooms";
            this.floor3RoomsToolStripMenuItem.Click += new System.EventHandler(this.floor3RoomsToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 110);
            this.button1.TabIndex = 12;
            this.button1.Text = "All Science Labs";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Floor 3";
            // 
            // Floor3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Floor3";
            this.Text = "Floor3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem floorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floor1RoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floor2RoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floor3RoomsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}