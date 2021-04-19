using System;
using Eiba.Interop.FalconConnectionManager;
using Eiba.Interop.FalconInterfaces;
using FalconClientComponentsLib;
using EibaClassCreatorLib;
using System.Windows.Forms;


namespace Visualization
{

    class Falcon
    {

        private DeviceOpenError e_open;
        private DeviceWriteError e_write;
        private ClassCreator ClassCreatorObj;
        private GroupDataClient G;
        private IConnectionCustom2 c;
        private DPT_info.DPT_info.DPT_conversion dpt = new DPT_info.DPT_info.DPT_conversion();
        string id_str = "";//inside get connection
        string parameters; // inside get connection
        public Boolean checker = false;
        private RichTextBox feedback;
        private Room activeRoom;
        

        public Falcon(RichTextBox box)
        {
            feedback = box;
        }
        public string getConnection_Int()
        {
            if (c != null)
            {
                return null;
            }
            try
            {
                ConnectionManager cm = new ConnectionManager();
                FalconConnection con;
                // Skapar Connection Manager
                con = cm.GetConnection("", 1);
                if (con.guidEdi == null || con.wszParameters == null)
                {
                    id_str = "-";
                    parameters = "-";
                }
                else
                {
                    Guid gu_id = con.guidEdi;
                    parameters = "";
                    for (int i = 0; i < con.wszParameters.Length; i++)
                    {
                        parameters = parameters + Convert.ToChar(con.wszParameters[i]);

                    }
                    id_str = gu_id.ToString();
                }
                return id_str + "|" + parameters;
            }

            catch (Exception ex)
            {
                throw new Exception("|x| GetConnection: Error opening connection manger. (e1102)" + ex.Message);
            }

        }

        public void connect_to_buss()
        {

            try
            {
                //disconnect();
                ClassCreatorObj = new ClassCreator();
                c = ClassCreatorObj.CreateInstanceLic("Falcon.ConnectionObject.1", (tagCLSCTX)4, "",
                    "E18Q22510200702GKO");
                c.Mode = ConnectionMode.ConnectionModeRemoteConnectionless;
                e_open = c.Open2(Guid.Parse(id_str), parameters);
                G = new GroupDataClient();
                G.Connection = (FalconInterfacesLib.IConnection)c;

                if (e_open == DeviceOpenError.DeviceOpenErrorNoError)
                {
                    G.GroupDataIndicationWrite += g_IndicationWriteHandler;
                }
                checker = true;
            }
            catch (Exception e)
            {
                DialogResult res = MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void g_IndicationWriteHandler(int GroupAddress, int RoutingCnt, FalconInterfacesLib.Priority Prio, object data)
        {
            string address = GroupAddress.ToString("X");
            address = " " + getAddress(address)+ " ";
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ff");
            string pull = dpt.fromDPT(activeRoom.searchroom(address), data);
            string temp = pull  + " " + address + " " + "/" + dateTime + "\n";
            feedback.Text += temp;

        }

        public void senddata(string address, Boolean status, int data, string dptvalue)
        {
            if(dptvalue == "5.001" && (data < 0 || data > 100) )
            {
                DialogResult d = MessageBox.Show("Control the value that you have inserted! " + address, "Warning" ,MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }
            else if (dptvalue!="5.001" && (data < 0 || data >1))
            {
                DialogResult d = MessageBox.Show("Control the value that you have inserted! " + address, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string push = dpt.toDPT(dptvalue, data);
                e_write = (DeviceWriteError)G.Write(address, (FalconInterfacesLib.Priority)Priority.PriorityLow, 6, status, push);
            }
           
        }

        public void disconnect()
        {
            if (c != null)
            {
                c.Mode = ConnectionMode.ConnectionModeClosed;
                c = null;
                G = null;
                checker = false;
            }
            else
            {
                DialogResult res = MessageBox.Show("No connection found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
   
        private string getAddress(string adr)
        {
            string adress = "";
            adress = Convert.ToString(Convert.ToInt32(adr,16), 2);
            adress = adress.PadLeft(16 - adress.Length, '0');
            int dec0 = Convert.ToInt32(adress.Substring(0, 4),2);
            int dec1 = Convert.ToInt32(adress.Substring(4, 3),2);
            int dec2 = Convert.ToInt32(adress.Substring(7, 8),2)-1;
            adress = (dec0 + "/" + dec1 + "/" + dec2);

            return adress;
        }
        public void setRoom(Room activeRoom)
        {
            this.activeRoom = activeRoom;
        }
    }

}
