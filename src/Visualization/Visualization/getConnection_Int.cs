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
        private GroupDataClient g;
        private IConnectionCustom2 c;
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
                    id_str =gu_id.ToString();
                }
                return id_str + "|" + parameters;
            }
            catch(Exception ex) {
                throw new Exception("|x| GetConnection: Error opening connection manger. (e1102)" + ex.Message);
            }
           
        }

        public void connect_to_buss()
        {
            
            //disconnect();
            ClassCreatorObj = new ClassCreator();
            c = ClassCreatorObj.CreateInstanceLic("Falcon.ConnectionObject.1", (tagCLSCTX)4, "", 
                "E18Q22510200702GKO");
            c.Mode = ConnectionMode.ConnectionModeRemoteConnectionless;
            e_open = c.Open2(Guid.Parse(id_str), parameters);
            g = new GroupDataClient();
            g.Connection = (FalconInterfacesLib.IConnection)c;

            checker = true; 
        }
        public void listning()
        {
            if(e_open == DeviceOpenError.DeviceOpenErrorNoError)
            {
               //g.GroupDataConfirmationWrite;
            }
        }
        public void senddata(string address, Boolean status , int data)
        {
          
            if (data != 0)
            {
                e_write = (DeviceWriteError)g.Write(address, (FalconInterfacesLib.Priority)Priority.PriorityLow, 6, status, (byte)data);
            }
            else
            {
                DialogResult  warningbox = MessageBox.Show("No data has been inserted"," " , MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
                      
        }

        public void disconnect()
        {
               
            c.Mode = ConnectionMode.ConnectionModeClosed;
            c = null;
            g = null;
            checker = false;
         
        }
    }

}
