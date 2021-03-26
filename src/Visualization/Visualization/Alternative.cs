using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualization
{
   public class Alternative
    {
        object[] onOff = { 0, 1};
        object[] finevalue = new object[101];

       public Alternative()
        {
            for (int i = 0; i < finevalue.Length; i++)
            {
                finevalue[i] = i;
            }
        }

        public object[] Value(string data)
        {
            
                if(data.Equals(" T/F ")|| data.Equals(" U/N ") || data.Equals(" S/S "))
                {
                return onOff;
                }
               else if (data.Equals(" värde ") || data.Equals(" Värde ") || data.Equals(" Position ") || data.Equals(" position "))
            {
                return finevalue;

            }
            return null;
        }
    }
   

    
}
