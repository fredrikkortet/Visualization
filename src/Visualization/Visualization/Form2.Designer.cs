
namespace Visualization
{
    partial class fortext
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fortext));
            this.Visualizationlabel = new System.Windows.Forms.Label();
            this.VLabel = new System.Windows.Forms.Label();
            this.AboutText = new System.Windows.Forms.Label();
            this.Owner1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Visualizationlabel
            // 
            this.Visualizationlabel.AutoSize = true;
            this.Visualizationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizationlabel.Location = new System.Drawing.Point(126, 132);
            this.Visualizationlabel.Name = "Visualizationlabel";
            this.Visualizationlabel.Size = new System.Drawing.Size(111, 20);
            this.Visualizationlabel.TabIndex = 0;
            this.Visualizationlabel.Text = "Visualization";
            // 
            // VLabel
            // 
            this.VLabel.AutoSize = true;
            this.VLabel.Location = new System.Drawing.Point(166, 163);
            this.VLabel.Name = "VLabel";
            this.VLabel.Size = new System.Drawing.Size(22, 13);
            this.VLabel.TabIndex = 1;
            this.VLabel.Text = "0.1";
            // 
            // AboutText
            // 
            this.AboutText.AutoSize = true;
            this.AboutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutText.Location = new System.Drawing.Point(12, 189);
            this.AboutText.Name = "AboutText";
            this.AboutText.Size = new System.Drawing.Size(349, 15);
            this.AboutText.TabIndex = 2;
            this.AboutText.Text = "Visualization application compares KNX drivers with input data.";
            // 
            // Owner1
            // 
            this.Owner1.AutoSize = true;
            this.Owner1.Location = new System.Drawing.Point(86, 226);
            this.Owner1.Name = "Owner1";
            this.Owner1.Size = new System.Drawing.Size(214, 13);
            this.Owner1.TabIndex = 3;
            this.Owner1.Text = "By Rohullah Khorami and Fredrik Kortetjärvi ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "For Tekniska byrån";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(169, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // fortext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(373, 353);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Owner1);
            this.Controls.Add(this.AboutText);
            this.Controls.Add(this.VLabel);
            this.Controls.Add(this.Visualizationlabel);
            this.Name = "fortext";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Visualizationlabel;
        private System.Windows.Forms.Label VLabel;
        private System.Windows.Forms.Label AboutText;
        private System.Windows.Forms.Label Owner1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}