using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOPlatform.Core
{
    public class SeniorCoinKey
    {
        private String _Address { get; set; }
        private String _PrivateKey { get; set; }
        private String _PublicKey { get; set; }

        public void GenerateKey()
        {

        }



        public String GetAddress()
        {
            return _Address;
        }
        public String GetPublicKey()
        {
            return _PublicKey;
        }

        public String GetPrivateKey()
        {
            return _PrivateKey;
        }



    }


    public class SeniorCoin
    {
        HttpBuilder _HttpBuilder;
        public SeniorCoin()
        {
            _HttpBuilder = new HttpBuilder();
            _HttpBuilder.UseProxy = false;
            _HttpBuilder._CreateBuilder();
        }


        public Boolean _CreateNewAddress()
        {
            SeniorCoinKey _SeniorCoinKey = new SeniorCoinKey();
            _SeniorCoinKey.GenerateKey();
            return true;
               
        }


    }
}
