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


        public string getConnection_Int()
        {
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

           

            //DialogResult tes = MessageBox.Show(temp, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

             string address = dpt.getAddress(GroupAddress.ToString());
              string pull = dpt.fromDPT(address,data);
            //KNX_event(address, data);
        }

        public void senddata(string address, Boolean status, int data)
        {
            string push = dpt.toDPT("5.001", data);
            e_write = (DeviceWriteError)G.Write(address, (FalconInterfacesLib.Priority)Priority.PriorityLow, 6, status, push);
           
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
    }
}


