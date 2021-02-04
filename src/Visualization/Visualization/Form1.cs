using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Visualization
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void StripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "csv files only|*.csv|All Files(*.*)|*.*";

            string line; 
            if (openfile.ShowDialog().Equals(DialogResult.OK))
            {
                StreamReader read = new StreamReader(File.OpenRead(openfile.FileName));
                line = read.ReadLine();
                int nodecount = -1;
                while (line != null)
                {
                    
                    string [] temp = line.Split(';');
                    if(temp[0] != " ")
                    { 
                        TreeNode mainNode = new TreeNode();
                        mainNode.Name = "mainNode";
                        mainNode.Text = temp[0];
                        Treeview.Nodes.Add(mainNode);
                        nodecount++;

                        
                    }
                    if (temp[1] != " ")
                    {
                        TreeNode node = new TreeNode();
                        node.Name = "Node";
                        node.Text = temp[1];
                        Treeview.Nodes[nodecount].Nodes.Add(node);

                    }
                    if (temp[2] != " ")
                    {
                        TreeNode childnode = new TreeNode();
                        childnode.Name = "childnode";
                        childnode.Text = temp[2];
                        Treeview.Nodes[nodecount].Nodes[0].Nodes.Add(childnode);

                    }
                    
                    line = read.ReadLine();
                }

                Treeview.Text = read.ReadToEnd();
                read.Dispose();
            }
            {

            }
        }


        private void StripSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Open Files";
            savefile.Filter = " Text Files|*.txt|All Files(*.*)|*.*";

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

    }
}
