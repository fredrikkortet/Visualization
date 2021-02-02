
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Treeview = new System.Windows.Forms.TreeView();
            this.Textbox = new System.Windows.Forms.RichTextBox();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.StripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.StripSaveAS = new System.Windows.Forms.ToolStripMenuItem();
            this.StripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.StripViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.StripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Treeview
            // 
            this.Treeview.Location = new System.Drawing.Point(0, 31);
            this.Treeview.Margin = new System.Windows.Forms.Padding(4);
            this.Treeview.Name = "Treeview";
            this.Treeview.Size = new System.Drawing.Size(799, 627);
            this.Treeview.TabIndex = 2;
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(0, 671);
            this.Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(799, 324);
            this.Textbox.TabIndex = 3;
            this.Textbox.Text = "";
            // 
            // DataPanel
            // 
            this.DataPanel.Location = new System.Drawing.Point(808, 140);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(755, 763);
            this.DataPanel.TabIndex = 4;
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.Location = new System.Drawing.Point(1133, 923);
            this.ButtonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(133, 62);
            this.ButtonCheck.TabIndex = 5;
            this.ButtonCheck.Text = "Check";
            this.ButtonCheck.UseVisualStyleBackColor = true;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(809, 36);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(92, 24);
            this.PathLabel.TabIndex = 6;
            this.PathLabel.Text = "Belysning";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(917, 110);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(102, 24);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "Information";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(1377, 110);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(59, 24);
            this.ValueLabel.TabIndex = 8;
            this.ValueLabel.Text = "Value";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.StripHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1579, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripOpen,
            this.StripSave,
            this.StripSaveAS});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // StripOpen
            // 
            this.StripOpen.Name = "StripOpen";
            this.StripOpen.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.StripOpen.Size = new System.Drawing.Size(224, 26);
            this.StripOpen.Text = "Open";
            // 
            // StripSave
            // 
            this.StripSave.Name = "StripSave";
            this.StripSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.StripSave.Size = new System.Drawing.Size(224, 26);
            this.StripSave.Text = "Save";
            // 
            // StripSaveAS
            // 
            this.StripSaveAS.Name = "StripSaveAS";
            this.StripSaveAS.Size = new System.Drawing.Size(224, 26);
            this.StripSaveAS.Text = "Save As...";
            // 
            // StripHelp
            // 
            this.StripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripViewHelp,
            this.StripAbout});
            this.StripHelp.Name = "StripHelp";
            this.StripHelp.Size = new System.Drawing.Size(55, 24);
            this.StripHelp.Text = "Help";
            // 
            // StripViewHelp
            // 
            this.StripViewHelp.Name = "StripViewHelp";
            this.StripViewHelp.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.StripViewHelp.Size = new System.Drawing.Size(253, 26);
            this.StripViewHelp.Text = "View Help";
            // 
            // StripAbout
            // 
            this.StripAbout.Name = "StripAbout";
            this.StripAbout.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.StripAbout.Size = new System.Drawing.Size(253, 26);
            this.StripAbout.Text = "About";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1579, 998);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.ButtonCheck);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.Treeview);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Window";
            this.Text = "Visualization";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TreeView Treeview;
        private System.Windows.Forms.RichTextBox Textbox;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Button ButtonCheck;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripHelp;
        private System.Windows.Forms.ToolStripMenuItem StripSave;
        private System.Windows.Forms.ToolStripMenuItem StripSaveAS;
        private System.Windows.Forms.ToolStripMenuItem StripViewHelp;
        private System.Windows.Forms.ToolStripMenuItem StripAbout;
        private System.Windows.Forms.ToolStripMenuItem StripOpen;
    }
}

