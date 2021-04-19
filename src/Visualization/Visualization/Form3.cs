using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization
{
    public partial class Form3 : Form
    {
        public Form3()
        {

            InitializeComponent();
            string text1 = "1. Open a csv file!\n";
            string text2 = "2. Choose a room/section!\n";
            string text3 = "3. Insert data by clicking on the values or just type!\n";
            string text4 = "4. Open KNX virtual.\n";
            string text5 = "5. Choose a port and click OK. \n";
            string text6 = "6. Click on check to connect to the KNX virtual.\n";
            string text7 = "7. Select ip port and type or insert the same port as KNX virtual and click OK\n";
            string text8 = "8. Select save from menubar to save the feedback from system.\n";


            richTextBox1.Text = text1+text2+text3+text4+text5+text6+text7+text7+text8;
        }

       
    }
}
