using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOPlatform.Core.SeniorCoin
{
   

    public class SeniorCoinBalanceData
    {
        public string accountName { get; set; }
        public string accountHdPath { get; set; }
        public int coinType { get; set; }
        public long amountConfirmed { get; set; }
        public int amountUnconfirmed { get; set; }
        public long spendableAmount { get; set; }
        public List<SeniorCoinAddress> addresses { get; set; }
    }
}
