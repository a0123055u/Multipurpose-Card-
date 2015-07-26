using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipurpose_card
{
    class Connection
    {
        String result = "";
        String temp1;
        public String Authentication(String user, String password)
        {
           //SingleCardApplicationEntities urssinglecrd = new SingleCardApplicationEntities();
            
            try
            {
                using (SingleCardApplicationEntities likedobject = new SingleCardApplicationEntities())
                {
                    var checkpass = (from y in likedobject.bankusers
                                     where y.userid == user
                                     select y.passwords);
                    foreach (var temp in checkpass)
                    {
                       
                        temp1 = temp;

                    }
                    if (temp1.Equals(password))
                    {
                        var check = (from x in likedobject.bankusers
                                     where x.userid == user
                                     select new { x.username });
                        String usernameforreturn;
                        if(check!=null)
                             usernameforreturn = check.FirstOrDefault().ToString();
                        var accuts = (from acc in likedobject.useraccounts
                                      where acc.userid == user
                                      select  ( acc.bankid ));
                        List<String> list = accuts.ToList<string>();
                        //accuts.Count();
                        String[] bankid = new String[accuts.Count()];
                        int count=0;
                        if(accuts!=null)
                        {
                            foreach(var ids in accuts)
                            {
                                bankid[count] = ids.ToString();
                                count++;

                            }
                        }
                        int controller = bankid.Count();
                        String[] banknames= new String[10];
                        for (int cc = 0; cc < controller; cc++)
                        {
                            //store current value and finds it 
                            String tt = bankid[cc];
                            

                            var displaynames = (from bak in likedobject.banks
                                                where bak.bankid == tt
                                                select bak.bankname);
                            banknames[cc] = displaynames.FirstOrDefault().ToString();
                        }
                       
                            result =String.Join(",",banknames);
                        

                        Console.WriteLine(result);
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
