
namespace Visualization
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.Treeview = new System.Windows.Forms.TreeView();
            this.Textbox = new System.Windows.Forms.RichTextBox();
            this.addressPanel = new System.Windows.Forms.Panel();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.StripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.StripSaveAS = new System.Windows.Forms.ToolStripMenuItem();
            this.StripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.StripViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.StripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.valuePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Treeview
            // 
            this.Treeview.Location = new System.Drawing.Point(0, 25);
            this.Treeview.Name = "Treeview";
            this.Treeview.Size = new System.Drawing.Size(407, 510);
            this.Treeview.TabIndex = 2;
            this.Treeview.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Treeview_NodeMouseDoubleClick);
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(0, 541);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(407, 183);
            this.Textbox.TabIndex = 3;
            this.Textbox.Text = "";
            // 
            // addressPanel
            // 
            this.addressPanel.Location = new System.Drawing.Point(412, 114);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(130, 499);
            this.addressPanel.TabIndex = 4;
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.Location = new System.Drawing.Point(672, 619);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(100, 50);
            this.ButtonCheck.TabIndex = 5;
            this.ButtonCheck.Text = "Check";
            this.ButtonCheck.UseVisualStyleBackColor = true;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(569, 32);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(0, 18);
            this.pathLabel.TabIndex = 6;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(412, 91);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 18);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(1006, 91);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(44, 18);
            this.ValueLabel.TabIndex = 8;
            this.ValueLabel.Text = "Value";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripOpen,
            this.StripSave,
            this.StripSaveAS});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // StripOpen
            // 
            this.StripOpen.Name = "StripOpen";
            this.StripOpen.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.StripOpen.Size = new System.Drawing.Size(178, 22);
            this.StripOpen.Text = "Open";
            this.StripOpen.Click += new System.EventHandler(this.StripOpen_Click);
            // 
            // StripSave
            // 
            this.StripSave.Name = "StripSave";
            this.StripSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.StripSave.Size = new System.Drawing.Size(178, 22);
            this.StripSave.Text = "Save";
            this.StripSave.Click += new System.EventHandler(this.StripSave_Click);
            // 
            // StripSaveAS
            // 
            this.StripSaveAS.Name = "StripSaveAS";
            this.StripSaveAS.Size = new System.Drawing.Size(178, 22);
            this.StripSaveAS.Text = "Save As...";
            // 
            // StripHelp
            // 
            this.StripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripViewHelp,
            this.StripAbout});
            this.StripHelp.Name = "StripHelp";
            this.StripHelp.Size = new System.Drawing.Size(44, 20);
            this.StripHelp.Text = "Help";
            // 
            // StripViewHelp
            // 
            this.StripViewHelp.Name = "StripViewHelp";
            this.StripViewHelp.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.StripViewHelp.Size = new System.Drawing.Size(202, 22);
            this.StripViewHelp.Text = "View Help";
            // 
            // StripAbout
            // 
            this.StripAbout.Name = "StripAbout";
            this.StripAbout.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.StripAbout.Size = new System.Drawing.Size(202, 22);
            this.StripAbout.Text = "About";
            this.StripAbout.Click += new System.EventHandler(this.StripAbout_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.StripHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1204, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // infoPanel
            // 
            this.infoPanel.Location = new System.Drawing.Point(548, 114);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(456, 499);
            this.infoPanel.TabIndex = 5;
            // 
            // valuePanel
            // 
            this.valuePanel.Location = new System.Drawing.Point(1010, 114);
            this.valuePanel.Name = "valuePanel";
            this.valuePanel.Size = new System.Drawing.Size(167, 499);
            this.valuePanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Information";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1204, 734);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.valuePanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.ButtonCheck);
            this.Controls.Add(this.addressPanel);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.Treeview);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Window";
            this.Text = "Visualization";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView Treeview;
        private System.Windows.Forms.RichTextBox Textbox;
        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.Button ButtonCheck;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripOpen;
        private System.Windows.Forms.ToolStripMenuItem StripSave;
        private System.Windows.Forms.ToolStripMenuItem StripSaveAS;
        private System.Windows.Forms.ToolStripMenuItem StripHelp;
        private System.Windows.Forms.ToolStripMenuItem StripViewHelp;
        private System.Windows.Forms.ToolStripMenuItem StripAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel valuePanel;
        private System.Windows.Forms.Label label1;
    }
}

