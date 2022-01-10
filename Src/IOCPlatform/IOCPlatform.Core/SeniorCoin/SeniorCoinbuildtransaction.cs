using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOPlatform.Core.SeniorCoin
{
    public class SeniorCoinbuildtransaction
    {
        public string feeAmount { get; set; }
        public string password { get; set; }
        public bool segwitChangeAddress { get; set; }
        public string walletName { get; set; }
        public string accountName { get; set; }
        public List<SeniorCoinRecipient> recipients { get; set; }
        public bool allowUnconfirmed { get; set; }
        public bool shuffleOutputs { get; set; }
    }

}
