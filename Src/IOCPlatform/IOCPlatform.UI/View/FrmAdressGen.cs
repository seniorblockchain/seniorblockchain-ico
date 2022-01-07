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
    public partial class FrmAdressGen : LayoutForm
    {
        
        public FrmAdressGen(ILogger<FrmAdressGen> logger , IWalletClient wallet, IContractClientFactory contract, ITronClient tron)
        {
            _logger = logger;

            _wallet = wallet;
            _contract = contract;
            _tron = tron;

            InitializeComponent();
        }

        private readonly ILogger _logger;
        private readonly ITronClient _tron;
        private readonly IWalletClient _wallet;
        private readonly IContractClientFactory _contract;

        private async void Btn_Generat_Click(object sender, EventArgs e)
        {
            //DatabaseProvider _db = new DatabaseProvider();


            //tbl_TRC20 _tbl_TRC20 = new tbl_TRC20()
            //{
            //    Address = Guid.NewGuid().ToString(),
            //    Privatekey = Guid.NewGuid().ToString(),
            //    Publickey = Guid.NewGuid().ToString(),
            //    Money = 0
            //};


            //if (_db._Add_Tbl_TRC20(_tbl_TRC20) == true)
            //{
            //    _AddLog("Sucess Add");
            //}
            //else
            //{
            //    _AddLog("Failed Add");

            //}
            //_AddLog("Total Record is : " + _db._Get_TRC20().Count().ToString());







            var key = TronECKey.GenerateKey(TronNetwork.MainNet);
            var address = key.GetPublicAddress();
            var privatekey = key.GetPrivateKey();
            var publickey = key.GetPublicAddress();


          

              
            var account = _wallet.GetAccount(privatekey);            
            var contractAddress = "TR7NHqjeKQxGTCi8q8ZY4pL8otSzgjLj6t";
            var contractClient = _contract.CreateClient(ContractProtocol.TRC20);

            var balance = await contractClient.BalanceOfAsync(contractAddress, account);

         


         
        }



        private void _AddLog(string _input)
        {
            try
            {
                Txt_LiveLog.AppendText(_input + Environment.NewLine);
            }
            catch { }
        }

        private void FrmAdressGen_Load(object sender, EventArgs e)
        {

        }
    }
}
