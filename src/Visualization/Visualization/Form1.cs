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

<<<<<<< HEAD
        private void StripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "csv files only|*.csv|All Files(*.*)|*.*";
           

            if (openfile.ShowDialog().Equals(DialogResult.OK))
            {
                StreamReader read = new StreamReader(File.OpenRead(openfile.FileName));
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
=======
        private void StripAbout_Click(object sender, EventArgs e)
        {
            fortext vilas = new fortext();
            vilas.Show();
        }

   
>>>>>>> d83e1a55f1d00c464fe35abfb1dfd03805a9bba6
    }
}
