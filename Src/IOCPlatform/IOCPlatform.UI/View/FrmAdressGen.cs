using ICOPlatform.UI.View.Shared;
using IOCPlatform.DataBase;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Nethereum.Signer;
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
        
        public FrmAdressGen( IWalletClient wallet, IContractClientFactory contract, ITronClient tron)
        {
          //  _logger = logger;

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



            if(Token_TRC20.Checked == true)
            {
                _GenTRC20();
            }


            if (Token_ERC20.Checked == true)
            {
                _GenERC20();
            }



            return;

            var key = TronECKey.GenerateKey(TronNetwork.MainNet);
            var address = key.GetPublicAddress();
            var privatekey = key.GetPrivateKey();
            var publickey = key.GetPublicAddress();


          

              
            var account = _wallet.GetAccount(privatekey);            
            var contractAddress = "TR7NHqjeKQxGTCi8q8ZY4pL8otSzgjLj6t";
            var contractClient = _contract.CreateClient(ContractProtocol.TRC20);

            var balance = await contractClient.BalanceOfAsync(contractAddress, account);

         


         
        }

        private void _GenERC20()
        {
            try
            {
                DatabaseProvider _Db = new DatabaseProvider();
                int _Target = (int)Total_Address.Value;


                _AddLog("*****************  Start Getn Total " + _Target.ToString() + "   [ERC20] *******************");


                for (int _i = 1; _i <= _Target; _i++)
                {
                    try
                    {
                        EthECKey key = EthECKey.GenerateKey();
                        byte[] privateKeybyte = key.GetPrivateKeyAsBytes();
                        string privateKey = key.GetPrivateKey();
                        string Address = key.GetPublicAddress();
                   

                        tbl_ERC20 _tbl_ERC20 = new tbl_ERC20();
                        _tbl_ERC20.Address = Address;
                        _tbl_ERC20.Privatekey = privateKey;
                        

                        if (_Db._Add_Tbl_ERC20(_tbl_ERC20) == true)
                        {
                            _DoProgress(_i, _Target);

                            _AddLog(_tbl_ERC20.Address);
                        }



                        //var account = _wallet.GetAccount(privatekey);
                        //var contractAddress = "TR7NHqjeKQxGTCi8q8ZY4pL8otSzgjLj6t";
                        //var contractClient = _contract.CreateClient(ContractProtocol.TRC20);

                        //var balance = await contractClient.BalanceOfAsync(contractAddress, account);



                    }
                    catch { }

                }

                _AddLog(String.Format("*****************  End  [ERC20] *******************", _Target.ToString()));




            }
            catch { }
        }

        private async void _GenTRC20()
        {
            try
            {
                DatabaseProvider _Db = new DatabaseProvider(); 
                int _Target = (int)Total_Address.Value;


                _AddLog("*****************  Start Getn Total " + _Target.ToString() + "   [TRC20] *******************" );
               

                for (int _i = 1; _i <= _Target; _i++)
                {
                    try
                    {
                        var key = TronECKey.GenerateKey(TronNetwork.MainNet);
                        var address = key.GetPublicAddress();
                        var privatekey = key.GetPrivateKey();
                        var publickey = key.GetPublicAddress();

                        tbl_TRC20 _tbl_TRC20 = new tbl_TRC20();
                        _tbl_TRC20.Address = address;
                        _tbl_TRC20.Privatekey = privatekey;
                        _tbl_TRC20.Publickey = publickey;

                        if (_Db._Add_Tbl_TRC20(_tbl_TRC20) == true)
                        {
                            _DoProgress(_i, _Target);

                            _AddLog(_tbl_TRC20.Address);
                        }



                        //var account = _wallet.GetAccount(privatekey);
                        //var contractAddress = "TR7NHqjeKQxGTCi8q8ZY4pL8otSzgjLj6t";
                        //var contractClient = _contract.CreateClient(ContractProtocol.TRC20);

                        //var balance = await contractClient.BalanceOfAsync(contractAddress, account);



                    }
                    catch { }

                }

                _AddLog(String.Format("*****************  End  [TRC20] *******************", _Target.ToString()));




            }
            catch { }
        }


        private void _DoProgress(int _Current , int _Total)
        {
            try
            {
                Application.DoEvents();
            }
            catch { }

            try
            {

                lbl_total.Text = _Total.ToString();
                lbl_current.Text = _Current.ToString();
                
            }
            catch { }

            try
            {
                progress_gen.Maximum = _Total;
                progress_gen.Value = _Current;
            }
            catch { progress_gen.Value = progress_gen.Maximum; }

        }

        private void _AddLog(string _input)
        {
            try
            {
                Application.DoEvents();
            }
            catch { }

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
