using System;
using System.Diagnostics;
using System.Windows.Forms;
using WTT.CoinApiDataFeed.Properties;

namespace WTT.CoinApiDataFeed
{
    public partial class ctlLogin : UserControl
    {
        public ctlLogin()
        {
            InitializeComponent();
        }

        public string ApiKey => txtApiKey.Text.Trim();

        private void ctlLogin_Load(object sender, EventArgs e)
        {
            txtApiKey.Text = Settings.Default.ApiKey;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            Process.Start("https://docs.coinapi.io/");
        }

        private void formatLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            Process.Start("https://www.coinapi.io/integration");
        }
    }
}