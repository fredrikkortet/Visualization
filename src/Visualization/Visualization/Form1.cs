using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace Visualization
{
    public partial class Window : Form
    {
        static LinkedList<Room> linkedRooms = new LinkedList<Room>();
        functions function = new functions(linkedRooms);
        Alternative valueItems = new Alternative();
        Falcon connect;
        public Room activeRoom;



        public Window()
        {
            InitializeComponent();
            connect = new Falcon(Textbox);
        }

        private void StripOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "csv files only|*.csv";
            if (openfile.ShowDialog().Equals(DialogResult.OK))
            {
                linkedRooms.Clear();
                Treeview.Nodes.Clear();
                StreamReader read = new StreamReader(File.OpenRead(openfile.FileName), System.Text.Encoding.GetEncoding(1252), true);

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
                writefile.Write(Textbox.Text);
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

            if (e.Node.Nodes.Count == 0)
            {
                object[] test = { 1, 2, 3 };
                addressPanel.Controls.Clear();
                infoPanel.Controls.Clear();
                valuePanel.Controls.Clear();
                pathLabel.Text = e.Node.FullPath;
                activeRoom = null;
                foreach (Room str in linkedRooms)
                {
                    if (str.CompareRoom((string)e.Node.Tag))
                    {
                        activeRoom = str;
                        break;
                    }
                }
                if (activeRoom == null)
                {
                    MessageBox.Show("Error message 404 \"Room not found\"");

                }
                else
                {
                    LinkedListNode<controller> roomItem = activeRoom.getControl().First;
                    ComboBox value;
                    int count = 0;
                    for (int i = 0; i < activeRoom.getCount() - 1; i++)
                    {
                        value = new ComboBox();
                        string[] temp = roomItem.Value.getRoomitem().Split('>');
                        object[] temp2 = valueItems.Value(temp[1]);

                        if (temp2 != null)
                        {
                            roomItem.Value.setCheck(temp[1]);
                            value.Items.AddRange(temp2);
                            roomItem.Value.setComboBox(value);
                            value.Location = new Point(0, count * 25);
                            Label firstlabel = new Label();
                            firstlabel.Location = new Point(0, count * 25);
                            firstlabel.Text = roomItem.Value.getAddress();

                            Label secondlabel = new Label();
                            secondlabel.Width = 450;
                            secondlabel.Location = new Point(0, count * 25);
                            secondlabel.Text = roomItem.Value.getRoomitem();
                            addressPanel.Controls.Add(firstlabel);
                            infoPanel.Controls.Add(secondlabel);
                            valuePanel.Controls.Add(value);
                            count++;
                        }
                        roomItem = roomItem.Next;


                    }
                }
            }

        }



        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            string co = connect.getConnection_Int();
            if(co != null)
            {
                string message = "Connected to the driver!\n";
                connect.connect_to_buss();
                Textbox.Text += message;
            }
           
           if (activeRoom != null)
            {
                connect.setRoom(activeRoom);
                LinkedListNode<controller> value = activeRoom.getControl().First;

                int nodata = 0;
                while (value != null)
                {

                    if (value.Value.getComboBox() != null && value.Value.getComboBox().Text != "")
                    {

                        int temp = int.Parse(value.Value.getComboBox().Text);
                        connect.senddata(value.Value.getAddress(), value.Value.getcheck(), temp,value.Value.getDpt());
                        nodata++;

                    }

                    value = value.Next;

                }
                if (nodata == 0)
                {
                    DialogResult res = MessageBox.Show("Empty data has been inserted!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("No Imported File!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {

            connect.disconnect();
            Textbox.ForeColor = Color.Red;
            Textbox.Text += "Disconnected\n";

        }
        public Room getRoom()
        {
            return activeRoom;
        }

        private void StripViewHelp_Click(object sender, EventArgs e)
        {
            Form3 helpdesk = new Form3();
            helpdesk.Show();
        }
    }
}
