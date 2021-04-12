
using System;
using System.Windows.Forms;



public class controller
{
    private string roomitem;
    private string address;
    private ComboBox value;
    private string dpt;
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
    public string getDpt()
    {
        return dpt;
    }
    public void setCheck(string data)
    {
        if (data.Equals(" T/F ") || data.Equals(" U/N ") || data.Equals(" S/S "))
        {
            if(data.Equals(" T/F "))
            {
                dpt = "1.001";
            }
            else if (data.Equals(" U/N "))
            {
                dpt = "1.008";
            }
            else if (data.Equals(" S/S "))
            {
                dpt = "1.009";
            }
            check = true;
        }
        
        else if (data.Equals(" värde ") || data.Equals(" Värde ") || data.Equals(" Position ") || data.Equals(" position "))
        {
            dpt = "5.001";
            check = false;

        }
    }
}
