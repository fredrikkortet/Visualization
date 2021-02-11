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

        LinkedList<Room> linkedRooms = new LinkedList<Room>();
        LinkedListNode<Room> currentNode;
        Boolean check = true; 
        
        
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
                    temp = SkipChar(temp);
                    if (temp[0] != " ")
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
                        check = true; // it is  true until next plan is coming  

                    }
                    if (temp[2] != " ")
                    {
                        string[] splitUnderscore = Split_room(temp[2], temp[3]);
                        if (splitUnderscore !=null) { 
                        TreeNode childnode = new TreeNode();
                        childnode.Name = "childnode";
                        childnode.Text = splitUnderscore[0];
                        Treeview.Nodes[nodecount].Nodes[0].Nodes.Add(childnode);
                        }
                    }
                    
                    line = read.ReadLine();
                }

                Treeview.Text = read.ReadToEnd();
                read.Dispose();
            }
            {

            }
        }

        /**
         * This function skips character like " " 
         */
        private string[] SkipChar(string [] character)   
        {
          
            for(int i = 0; i< character.Length; i++)
            {
                if(character[i] != null)
                {
                    character[i] = character[i].Replace('\"', ' ');
                }
              
            }
            return character;

        }

        /// <summary>
        /// This function splits strings that have "_" 
        /// </summary>
        /// <param name="underscore"></param> it returns a string that has nothing in it.
        /// <returns></returns>
       private string [] Split_room(string underscore, string address)
        {
            string[] temp = underscore.Split('_');
            if(linkedRooms.Count>0)
            {
                if (check)
                {
                    currentNode = linkedRooms.First;
                    check = false;
                }
                do
                {
                    if (currentNode.Value.CompareRoom(temp[0],address))
                    {
                        currentNode.Value.addItem(temp[1], address);
                        return null;
                    }
                    if(currentNode.Next == null)
                    {
                        Room addroom = new Room(temp[0], temp[1], address);
                        linkedRooms.AddLast(addroom);
                        return temp;
                    }currentNode = currentNode.Next;
                } while (currentNode!=null);
            }else
            {
                Room addroom = new Room(temp[0], temp[1],address);
                linkedRooms.AddLast(addroom);
            }

            return temp;
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
