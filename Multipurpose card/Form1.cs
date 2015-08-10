using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multipurpose_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller contrl = new Controller();
            String accounts  = contrl.connectusingentity(textBox1.Text, textBox2.Text);
            char a = ',';
             String name=" ";
             String acc1id = " ";
             String acc2id = " ";
            String[] acc1 = accounts.Split(a);
            if (acc1.Count() == 5)
            {
                label5.Text = acc1[0];
                label6.Text = acc1[1];
                acc1id = acc1[2];
                acc2id = acc1[3];
               name = acc1[4];
                
            }
            else
            {
                label5.Text = acc1[0];
                label6.Text = "NA";
                acc1id = acc1[1];
                acc2id = "NA";
                 name = acc1[2];

            }
            
            label5.Refresh();
            label6.Refresh();







            Form2 obj2 = new Form2(label5.Text, label6.Text,acc1id,acc2id,name);
            obj2.Show();

       }
    }
}
