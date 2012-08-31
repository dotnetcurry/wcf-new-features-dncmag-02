using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCF45_Multi_Auth_Clients
{
    public partial class Form1 : Form
    {
        MyRef.ServiceClient Proxy; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                var Result = Proxy.GetEmployees();
                dgvEmployees.DataSource = Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Proxy = new MyRef.ServiceClient();
            Proxy.ClientCredentials.UserName.UserName = "Admin";
            Proxy.ClientCredentials.UserName.Password = "P@ssw0rd_";
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
            {
                return true;
            };
        }
    }
}
