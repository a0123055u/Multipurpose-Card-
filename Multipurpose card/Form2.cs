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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(String acc1name,String acc2name,String acc1num,String acc2num,String name)
        {
               InitializeComponent();
               button1.Text = acc1name;
               button2.Text = acc2name;
               label3.Text = name;
               label4.Text = name;
               label5.Text = acc1num;
               label6.Text = acc2num;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller url = new Controller();

            String tt = url.getBankUrl(button1.Text);
            Form3 obj = new Form3(label5.Text, tt);
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller url = new Controller();

            String tt = url.getBankUrl(button1.Text);
            Form3 obj = new Form3(label6.Text, tt);
            obj.Show();
        }
    }
}
