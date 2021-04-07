
using System.Windows.Forms;


    public class controller
    {
       private string roomitem;
       private string address;
       private ComboBox value;
        public controller(string roomitem, string address)
        {
            this.roomitem = roomitem;
            this.address = address;
        }

        public string getRoomitem()
        {
            return roomitem;
        }
        public string getAddress()
        {
            return address;
        }
        public ComboBox getComboBox()
        {
            return value;
        }

        public void setComboBox(ComboBox value)
        {
            this.value = value;
        }
    }
