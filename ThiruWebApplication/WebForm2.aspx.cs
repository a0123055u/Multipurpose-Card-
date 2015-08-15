using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Handlers;

namespace ThiruWebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Text = Request.Cookies["Firstpagdetails"]["name"];
            Label7.Text = Request.Cookies["Firstpagdetails"]["name"];
            Label8.Text = Request.Cookies["Firstpagdetails"]["accntnum1"];
            Label9.Text = Request.Cookies["Firstpagdetails"]["acctnum2"];
            String acc1 = Request.Cookies["Firstpagdetails"]["accntnum1"];
            Controller cntrl =new Controller();
            Button1.Text = cntrl.checkbankNameforAccount(acc1);
            String acc2 = Request.Cookies["Firstpagdetails"]["acctnum2"]; ;
            Button2.Text = cntrl.checkbankNameforAccount(acc2);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("WebForm3.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
}