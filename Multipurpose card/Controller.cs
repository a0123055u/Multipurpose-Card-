using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipurpose_card
{
    class Controller
    {
        public String connectusingentity(String user,String pass)
        {
            Connection connect = new Connection();
            String values= (connect.Authentication(user, pass));
            if(values!="Not found")
            {
                return values;
            }
            else
                return values;

        }
        public String getBankUrl(String bankname)
        {
            Connection connectback = new Connection();
            String url = (connectback.getBankUrl1(bankname));
            if (url != null)
                return url;
            else
                return "Null in controller";
        }
    }
}
