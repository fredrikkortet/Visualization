using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;



namespace Visualization
{


    class functions
    {
         LinkedList<Room> linkedRooms ;
        LinkedListNode<Room> currentNode;
        Boolean check = true;
        public functions(LinkedList<Room> list)
        {
            this.linkedRooms = list;
        }
        public string[] SkipChar(string[] character)
        {

            for (int i = 0; i < character.Length; i++)
            {
                if (character[i] != null)
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
        public string[] Split_room(string underscore, string address)
        {
            string[] temp = underscore.Split('_');
            if (linkedRooms.Count > 0)
            {
                if (check)
                {
                    currentNode = linkedRooms.First;
                    check = false;
                }
                do
                {
                    if (currentNode.Value.CompareRoom(temp[0], address))
                    {
                        currentNode.Value.addItem(temp[1], address);
                        return null;
                    }
                    if (currentNode.Next == null)
                    {
                        Room addroom = new Room(temp[0], temp[1], address);
                        linkedRooms.AddLast(addroom);
                        return temp;
                    }
                    currentNode = currentNode.Next;
                } while (currentNode != null);
            }
            else
            {
                Room addroom = new Room(temp[0], temp[1], address);
                linkedRooms.AddLast(addroom);
            }

            return temp;
        }


        public void makeTree(StreamReader read, TreeView treeview)
        {
            string line;
            line = read.ReadLine();
            int nodecount = -1;
            while (line != null)
            {

                string[] temp = line.Split(';');
                temp = SkipChar(temp);
                if (temp[0] != " ")
                {
                    TreeNode mainNode = new TreeNode();
                    mainNode.Name = "mainNode";
                    mainNode.Text = temp[0];
                    treeview.Nodes.Add(mainNode);
                    nodecount++;

                }
                if (temp[1] != " ")
                {
                    TreeNode node = new TreeNode();
                    node.Name = "Node";
                    node.Text = temp[1];
                    treeview.Nodes[nodecount].Nodes.Add(node);
                    check = true; // it is  true until next plan is coming  

                }
                if (temp[2] != " ")
                {
                    string[] splitUnderscore = Split_room(temp[2], temp[3]);
                    if (splitUnderscore != null)
                    {
                        TreeNode childnode = new TreeNode();
                        childnode.Name = "childnode";
                        childnode.Tag = temp[3];
                        childnode.Text = splitUnderscore[0];
                        treeview.Nodes[nodecount].Nodes[0].Nodes.Add(childnode);
                    }
                }

                line = read.ReadLine();
            }
            treeview.Text = read.ReadToEnd();
            read.Dispose();
        }
    }
}

