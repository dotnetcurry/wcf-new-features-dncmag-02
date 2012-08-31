using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WCF45_UDP_Comparision_Client
{
    public partial class Form1 : Form
    {

        #region  Class Level Declaration
        string Protocol = string.Empty;
        MyRef.ServiceClient Proxy;  
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Radio Button Events
        private void rdTcp_CheckedChanged(object sender, EventArgs e)
        {
            Protocol = "Tcp";
        }

        private void rdHttp_CheckedChanged(object sender, EventArgs e)
        {
            Protocol = "Http";
        }

        private void rdUdp_CheckedChanged(object sender, EventArgs e)
        {
            Protocol = "Udp";
        } 
        #endregion

        /// <summary>
        /// Method for Posting Messages to Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Protocol == string.Empty)
                {
                    MessageBox.Show("Please select the Protocol"); 
                }
                else
                {
                    switch (Protocol)
                    {
                        case "Tcp":
                            Proxy = new MyRef.ServiceClient("NetTcpBinding_IService");
                            break;
                        case "Http":
                            Proxy = new MyRef.ServiceClient("BasicHttpBinding_IService");
                            break;
                        case "Udp":
                            Proxy = new MyRef.ServiceClient("UdpBinding_IService");
                            break;
                    }
                }
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                for (int i = 0; i < 2000; i++)
                {
                    MyRef.MessagePost msg = new MyRef.MessagePost()
                    {
                        MessageDetails = "My Message Post No" + i.ToString() + "with Protocol " + Protocol
                    };
                    Proxy.PostMessages(msg); 
                }
                stopWatch.Stop();
                if (Protocol == "Tcp")
                {
                    lblTcpTime.Text += stopWatch.ElapsedMilliseconds; 
                }
                if (Protocol == "Http")
                {
                    lblHttpTime.Text += stopWatch.ElapsedMilliseconds;
                }
                if (Protocol == "Udp")
                {
                    lblUdpTime.Text += stopWatch.ElapsedMilliseconds;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
