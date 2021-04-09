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
        public void Split_room(string underscore, string address)
        {
            using (StringReader linespliter = new StringReader(underscore))
            {
                char[] c = new char[3]; 
                linespliter.Read(c, 0, 2);
                if (c[1] == '-')
                {
                    return;
                }
            }
            
            if (linkedRooms.Count > 0)
            {
                if (check)
                {
                    currentNode = linkedRooms.First;
                    check = false; 
                }
                do
                {
                    if (currentNode.Value.CompareRoom(address))
                    {
                        currentNode.Value.addItem(underscore,address);
                        return;
                    }
                    if (currentNode.Next == null)
                    {
                        Room addroom = new Room(underscore, address);
                        linkedRooms.AddLast(addroom);
                        return ;
                    }
                    currentNode = currentNode.Next;

                } while (currentNode != null);
            }
            else
            {
                Room addroom = new Room(underscore, address);
                linkedRooms.AddLast(addroom);
            }


           
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

                if(temp[0] != " ")
                {
                    TreeNode mainNode = new TreeNode();
                    mainNode.Name = "mainNode";
                    mainNode.Tag = temp[3]; // address
                    mainNode.Text = temp[0]; // info name
                    treeview.Nodes.Add(mainNode);
                    nodecount++;
                }
                if(temp[1] != " ")
                {
                    TreeNode node = new TreeNode();
                    node.Name = "node";
                    node.Tag = temp[3];
                    node.Text = temp[1];
                    treeview.Nodes[nodecount].Nodes.Add(node);
                    check = true;
                }
                if(temp[2] != " ")
                {
                    Split_room(temp[2], temp[3]);
                } 
                line = read.ReadLine();
            }
            treeview.Text = read.ReadToEnd();
            read.Dispose();
        }
       
    }
   
}

