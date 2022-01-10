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

namespace ICOPlatform.UI.View
{
    public partial class FrmSeniorBlockchain : LayoutForm
    {

        SeniorCoinWallet _SeniorCoinWallet = new SeniorCoinWallet();


        public FrmSeniorBlockchain(ILogger<FrmSeniorBlockchain> logger, IWalletClient wallet, IContractClientFactory contract, ITronClient tron)
        {
            _logger = logger;

            _wallet = wallet;
            _contract = contract;
            _tron = tron;
            InitializeComponent();
        }

        public ILogger _logger;
        private ITronClient _tron;
        private IWalletClient _wallet;
        private IContractClientFactory _contract;

        private void Btn_Getbalance_Click(object sender, EventArgs e)
        {
            // _SeniorCoinWallet.WalletUrl = @"http://localhost:15000/";
            try
            {

                var _balance = _SeniorCoinWallet._Get_Wallet_balance(Txt_MyWallet.Text, Txt_Account.Text);
                if (_balance != null)
                {
                    _AddLog("Success Load Data");
                    _AddLog("--------- Data ---------");
                    _AddLog("accountName  : " + _balance.balances[0].accountName);
                    _AddLog("accountHdPath  : " + _balance.balances[0].accountHdPath);
                    _AddLog("coinType  : " + _balance.balances[0].coinType.ToString());
                    _AddLog("amountConfirmed  : " + Convert.ToInt32(_balance.balances[0].amountConfirmed * 0.00000001));
                    _AddLog("amountConfirmed  : " + Convert.ToInt32(_balance.balances[0].amountUnconfirmed * 0.00000001));
                    _AddLog("spendableAmount  : " + Convert.ToInt32(_balance.balances[0].spendableAmount * 0.00000001));
                    _AddLog("");
                    _AddLog("--------- Addresss ---------");                
                    foreach (var _Adress in _balance.balances[0].addresses)
                    {
                        _AddLog("");
                        _AddLog("address  : " + _Adress.address);
                        _AddLog("isUsed  : " + _Adress.isUsed.ToString());
                        _AddLog("isChange  : " + _Adress.isChange.ToString());
                        _AddLog("amountConfirmed  : " + (_Adress.amountConfirmed * 0.00000001).ToString());
                        _AddLog("amountUnconfirmed  : " + (_Adress.amountUnconfirmed * 0.00000001).ToString());
                    }




                }
                else
                {
                    _AddLog("Failed Load data");
                }
            }catch (Exception ex) { }
        }

        private void _AddLog(string _input)
        {
            try
            {
                txt_log.AppendText(_input + Environment.NewLine);
            }
            catch { }
        }

        private void Btn_getAddressBalance_Click(object sender, EventArgs e)
        {
            // _SeniorCoinWallet.WalletUrl = @"http://localhost:15000/";
            try
            {

                var _Adress = _SeniorCoinWallet._Get_Address_balance(Txt_Address.Text);
                if (_Adress != null)
                {
                    _AddLog("");
                    _AddLog("address  : " + _Adress.address);
                    _AddLog("isUsed  : " + _Adress.isUsed.ToString());
                    _AddLog("isChange  : " + _Adress.isChange.ToString());
                    _AddLog("amountConfirmed  : " + (_Adress.amountConfirmed * 0.00000001).ToString());
                    _AddLog("amountUnconfirmed  : " + (_Adress.amountUnconfirmed * 0.00000001).ToString());

                }
                else
                {
                    _AddLog("Failed Load data");
                }
            }
            catch (Exception ex) { }
        }

        private void Btn_Transfer_Click(object sender, EventArgs e)
        {
            // _SeniorCoinWallet.WalletUrl = @"http://localhost:15000/";
            try
            {

                var _Adress = _SeniorCoinWallet._Post_BuildTrancetion(Txt_TransferToAddress.Text, Txt_amount.Text, Txt_MyWallet.Text, Txt_Account.Text, Txt_Password.Text);
                if (_Adress != null)
                {
                    _AddLog("");
                    _AddLog("fee  : " + _Adress.fee);
                    _AddLog("");
                    _AddLog("hex  : " + _Adress.hex);
                    _AddLog("");
                    _AddLog("transactionId  : " + _Adress.transactionId );


                    Txt_fee.Text = _Adress.fee.ToString();
                    Txt_hex.Text = _Adress.hex;
                    Txt_transactionId.Text = _Adress.transactionId;

                }
                else
                {
                    _AddLog("Failed Load data");
                }
            }
            catch (Exception ex) { }
        }

        private void Btn_SendCoin_Click(object sender, EventArgs e)
        {
            try
            {

                SeniorCoinTransectionBuild _BuildTR = new SeniorCoinTransectionBuild();

                _BuildTR.fee=Convert.ToInt32(Txt_fee.Text);
                _BuildTR.hex = Txt_hex.Text;
                _BuildTR.transactionId = Txt_transactionId.Text;


                var _Adress = _SeniorCoinWallet._Post_SendCoin(_BuildTR);
                if (_Adress != null)
                {
                    _AddLog("");
                    _AddLog("transactionId  : " + _Adress.transactionId);
                    _AddLog("");
                    foreach (var _data in _Adress.outputs)
                    {
                        _AddLog("address  : " + _data.address);
                        _AddLog("");
                        _AddLog("amount  : " + _data.amount);
                        _AddLog("");
                    }

                   

                }
                else
                {
                    _AddLog("Failed Load data");
                }
            }
            catch (Exception ex) { }
        }
    }
}
