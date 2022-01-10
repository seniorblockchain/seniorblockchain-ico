using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOPlatform.Core.SeniorCoin
{
    public class SeniorCoinWallet
    {

        private const string _Url_Wallet_balance = "api/Wallet/balance?WalletName={0}&AccountName={1}";
        private const string _Url_Address_balance = "api/Wallet/received-by-address?Address={0}";
        private const string _Url_BuildTrancetion = "api/Wallet/build-transaction";
        private const string _Url_SendTrancetion = "api/Wallet/send-transaction";


        HttpBuilder _HttpBuilder;
        public SeniorCoinWallet()
        {
            WalletUrl = DefaultWalletUrl;
            _HttpBuilder = new HttpBuilder();
            _HttpBuilder.UseProxy = false;
            _HttpBuilder._CreateBuilder();


        }

        public String WalletUrl
        {

            get
            {
                try
                {
                    return File.ReadAllText("[wallet].txt");
                }
                catch { }
                return "";
            }
            set
            {
                try
                {
                    if (File.Exists("[wallet].txt") == true)
                    {
                        File.Delete("[wallet].txt");
                    }
                    File.WriteAllText("[wallet].txt", value);
                }
                catch { }
            }
        }

        public String DefaultWalletUrl
        {
            get
            {
                return @"http://localhost:15000/";              
            }            
        }

        public SeniorCoinBalance _Get_Wallet_balance(String _WalletName , String _AccountName)
        {
            try
            {

                var _Data = _HttpBuilder._BuildRequst.Get(WalletUrl + String.Format(_Url_Wallet_balance , _WalletName, _AccountName)).ToString();
                var _balance = JsonConvert.DeserializeObject<SeniorCoinBalance>(_Data);
                return _balance;
            }
            catch { }

            return new SeniorCoinBalance();
        }

        public SeniorCoinAddress _Get_Address_balance(String _Address)
        {
            try
            {

                var _Data = _HttpBuilder._BuildRequst.Get(WalletUrl + String.Format(_Url_Address_balance, _Address)).ToString();
                var _balance = JsonConvert.DeserializeObject<SeniorCoinAddress>(_Data);
                return _balance;
            }
            catch { }

            return new SeniorCoinAddress();
        }

        public SeniorCoinTransectionBuild _Post_BuildTrancetion(String _DestinationAddress, String _Amount , String _walletName , String _AccountName ,String _Password   )
        {
            try
            {
               
                SeniorCoinRecipient _Recip = new SeniorCoinRecipient();
                _Recip.destinationAddress = _DestinationAddress;
                _Recip.amount = _Amount;

                SeniorCoinbuildtransaction _Tr = new SeniorCoinbuildtransaction();
                _Tr.recipients = new List<SeniorCoinRecipient>();
                _Tr.recipients.Add(_Recip);
                _Tr.feeAmount = "0.0001";
                _Tr.password = _Password;
                _Tr.segwitChangeAddress = true;
                _Tr.walletName = _walletName;
                _Tr.accountName = _AccountName;
                _Tr.allowUnconfirmed = true;
                _Tr.shuffleOutputs = true;



                var _json = JsonConvert.SerializeObject(_Tr);


                var _Data = _HttpBuilder._BuildRequst.Post(WalletUrl + _Url_BuildTrancetion, _json, "application/json").ToString();


                var _balance = JsonConvert.DeserializeObject<SeniorCoinTransectionBuild>(_Data);

                return _balance;
            }
            catch { }

            return null;
        }


        public SeniorCoinResoult _Post_SendCoin(SeniorCoinTransectionBuild _BuildTR)
        {
            try
            {
                //SeniorCoinResoult

                


                var _json = JsonConvert.SerializeObject(_BuildTR);


                var _Data = _HttpBuilder._BuildRequst.Post(WalletUrl + _Url_SendTrancetion, _json, "application/json").ToString();


                var _balance = JsonConvert.DeserializeObject<SeniorCoinResoult>(_Data);

                return _balance;
            }
            catch { }

            return null;
        }


    }
}
