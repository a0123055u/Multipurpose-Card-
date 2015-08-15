using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Handlers;
namespace ThiruWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Controller contrl = new Controller();
            String accounts = contrl.connectusingentity(TextBox1.Text, TextBox2.Text);
            char a = ',';
            String name = " ";
            String acc1id = " ";
            String acc2id = " ";
            String[] acc1 = accounts.Split(a);
            if (acc1.Count() == 5)
            {
                Label4.Text = acc1[0];
                Label5.Text = acc1[1];
                acc1id = acc1[2];
                acc2id = acc1[3];
                name = acc1[4];

            }
            else
            {
                Label4.Text = acc1[0];
                Label5.Text = "NA";
                acc1id = acc1[1];
                acc2id = "NA";
                name = acc1[2];

            }




            HttpCookie cokies = new HttpCookie("Firstpagdetails");
            cokies.Values.Add("accntnum1", acc1id);
            if(acc2id!="NA")
            cokies.Values.Add("acctnum2", acc2id);
            cokies.Values.Add("name", name);
            Response.Cookies.Add(cokies);
            


            Response.Redirect("WebForm2.aspx");
            
        }
    }
}