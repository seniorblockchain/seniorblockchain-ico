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


    }
}
