
using System;
using System.Windows.Forms;



    public class controller
    {
       private string roomitem;
       private string address;
       private ComboBox value;
    private Boolean check;
      // private DPT_info.DPT_info.DPT_conversion dpt;
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
    public Boolean getcheck()
    {
        return check;
    }
        public void setCheck(string data)
        {
        if (data.Equals(" T/F ") || data.Equals(" U/N ") || data.Equals(" S/S "))
        {
            check = true;   
        }
        else if (data.Equals(" värde ") || data.Equals(" Värde ") || data.Equals(" Position ") || data.Equals(" position "))
        {
            check = false;

        }
    }
    }
