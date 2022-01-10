using ICOPlatform.Core.SeniorCoin;
using ICOPlatform.UI.View.Shared;
using IOCPlatform.DataBase;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TronDotNet;
using TronDotNet.Contracts;

namespace IOCPlatform
{
    public partial class FrmMain : LayoutForm
    {
        public FrmMain(ILogger<FrmAdressGen> logger, IWalletClient wallet, IContractClientFactory contract, ITronClient tron)
        {

            _logger = logger;

            _wallet = wallet;
            _contract = contract;
            _tron = tron;

            InitializeComponent();
        }
        public ILogger _logger;
        private   ITronClient _tron;
        private   IWalletClient _wallet;
        private   IContractClientFactory _contract;

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = System.Windows.Forms.Application.ProductName + "  " +  new Version(System.Windows.Forms.Application.ProductVersion).ToString();

            }
            catch { }
        }

        private void Btn_AddressGen_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmAdressGen(_wallet, _contract, _tron).Show();
            }
            catch { }
        }

        private void Btn_Sync_Start_Click(object sender, EventArgs e)
        {
           
           

        }
    }
}
