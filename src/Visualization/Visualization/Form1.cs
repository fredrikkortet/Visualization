using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Visualization
{
    public partial class Window : Form
    {
        functions function = new functions();
        public Window()
        {
            InitializeComponent();
        }

        private void StripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "csv files only|*.csv";
            if (openfile.ShowDialog().Equals(DialogResult.OK))
            {
                StreamReader read = new StreamReader(File.OpenRead(openfile.FileName));
                function.makeTree(read, Treeview);
            }
        }
        private void StripSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Open Files";
            savefile.Filter = " Text Files|*.txt";

            if (savefile.ShowDialog().Equals(System.Windows.Forms.DialogResult.OK))
            {
                StreamWriter writefile = new StreamWriter(File.Create(savefile.FileName));
                writefile.Write(Treeview.Text);
                writefile.Dispose();
            }
        }

        private void StripAbout_Click_1(object sender, EventArgs e)
        {
            fortext vilas = new fortext();
            vilas.Show();
        }


         void Treeview_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        { 
            
            if(e.Node.Nodes.Count == 0)
            {

                addressPanel.Controls.Clear();
                infoPanel.Controls.Clear();
                valuePanel.Controls.Clear();
                pathLabel.Text = e.Node.FullPath;
                for(int i = 0; i<4; i++)
                {
                    ComboBox value = new ComboBox();
                    value.Text = e.Node.Text;
                    value.Items.AddRange(new string[] {"1","2","3","4" });
                    Label firstlabel = new Label();
                    firstlabel.Location = new Point(0,i*40);
                    Label secondlabel = new Label();
                    secondlabel.Location = new Point(0, i * 40);
                    firstlabel.Text = e.Node.Text;
                    secondlabel.Text = e.Node.Text;
                    addressPanel.Controls.Add(secondlabel);
                    infoPanel.Controls.Add(firstlabel);
                    valuePanel.Controls.Add(value);
                }
               
               
                
                
            }
        }

       
    }
}
