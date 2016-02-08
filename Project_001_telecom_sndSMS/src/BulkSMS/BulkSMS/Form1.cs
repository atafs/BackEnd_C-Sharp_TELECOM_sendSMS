using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace BulkSMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //SMS
                WebClient client = new WebClient();
                string to, msg;
                to = txtBoxTO.Text;
                msg = txtBoxMESSAGE.Text;
                string baseURL = "http://api.clickatell.com/http/sendmsg?user=americolib&password=POgCFIgJcUPCNa&api_id=3585811&to=" + to + "'&text='" + msg;

                //PRINT
                client.OpenRead(baseURL);
                MessageBox.Show("SUCCESSFULLY SENT MESSAGE!!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
