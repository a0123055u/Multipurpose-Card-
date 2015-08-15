using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiruWebApplication
{
    class Connection
    {
        String result = "";
        String temp1;
        String usernameforreturn = "";
        String res;
        String newresult;
        public String Authentication(String user, String password)
        {
            //SingleCardApplicationEntities urssinglecrd = new SingleCardApplicationEntities();

            try
            {
                using (SingleCardApplicationEntities11 likedobject = new SingleCardApplicationEntities11())
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
                                     select x.username);

                        if (check != null)
                            usernameforreturn = check.First().ToString();
                        var accuts = (from acc in likedobject.useraccounts
                                      where acc.userid == user
                                      select (acc.bankid));


                        //List<String> list = accuts.ToList<string>();
                        //accuts.Count();
                        String[] bankid = new String[accuts.Count()];
                        int count = 0;
                        if (accuts != null)
                        {
                            foreach (var ids in accuts)
                            {
                                bankid[count] = ids.ToString();
                                count++;

                            }
                        }
                        int controller = bankid.Count();
                        String[] banknames = new String[bankid.Count()];
                        String[] Accids = new String[bankid.Count()];
                        for (int cc = 0; cc < controller; cc++)
                        {
                            //store current value and finds it 
                            String tt = bankid[cc];


                            var displaynames = (from bak in likedobject.banks
                                                where bak.bankid == tt
                                                select bak.bankname);
                            //pass account number to the client
                            var accutsids = (from acc in likedobject.useraccounts
                                             where acc.userid == user && acc.bankid == tt
                                             select acc.accountid);
                            banknames[cc] = displaynames.FirstOrDefault().ToString();
                            Accids[cc] = accutsids.FirstOrDefault().ToString();

                        }
                        if ((banknames.Count() != 1) && (Accids.Count() != 1))
                        {


                            res = String.Join(",", banknames) + "," + String.Join(",", Accids) + "," + usernameforreturn;
                        }
                        else if ((banknames.Count() == 1) && (Accids.Count() == 1))
                        {
                            res = String.Join(",", banknames) + "," + String.Join(",", Accids) + "," + usernameforreturn;
                        }
                        Console.WriteLine(res);
                        return res;
                    }

                    else
                    {
                        return result;

                    }






                }
            }
            catch (Exception e)
            {
                return result + e.ToString();

            }

        }
        public String getBankUrl1(String bankname1)
        {
            String result = " ";
            try
            {
                using (SingleCardApplicationEntities11 urlobject = new SingleCardApplicationEntities11())
                {
                    var url = (from name in urlobject.banks
                               where name.bankname == bankname1
                               select name.bankurl);
                    result = url.FirstOrDefault().ToString();
                    return result;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return result;
            }
        }
        public String getBankName(String banknum)
        {

            try
            {
                using (SingleCardApplicationEntities11 obj = new SingleCardApplicationEntities11())
                {
                    var Bankid = (from acc in obj.useraccounts
                                  where acc.accountid == banknum
                                  select acc.bankid).FirstOrDefault();
                    var BankName = (from name in obj.banks
                                    where name.bankid == Bankid
                                    select name.bankname).FirstOrDefault();
                    return BankName.ToString();
                }
            }


            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
