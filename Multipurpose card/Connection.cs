using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipurpose_card
{
    class Connection
    {
        String result = "Not found";
        String temp1;
        public String Authentication(String user, String password)
        {
            usersofsinglecard urssinglecrd = new usersofsinglecard();
            try
            {
                using (AuthenticationEntities1 authEntity = new AuthenticationEntities1())
                {
                    var checkpass = (from y in authEntity.usersofsinglecards
                                     where y.userid == user
                                     select y.passwords);
                    foreach (var temp in checkpass)
                    {
                       
                        temp1 = temp;

                    }
                    if (temp1.Equals(password))
                    {
                        var check = (from x in authEntity.usersofsinglecards
                                     where x.userid == user
                                     select new { x.acc1name, x.acc2name,x.username});
                        foreach(var s in check)
                        {
                            result = s.acc1name+","+s.acc2name+","+s.username;
                            
                        }
                        return result;

                    }                       
                       
                    else
                    {
                         return result;
                    
                    }
                        

                   



                }
            }catch(Exception e)
            {
                return result +e.ToString();
               
            }
           
        }
    }
}
