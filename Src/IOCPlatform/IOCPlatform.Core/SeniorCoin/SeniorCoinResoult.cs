using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOPlatform.Core.SeniorCoin
{
    public class SeniorCoinResoult
    {
        public string transactionId { get; set; }
        public List<SeniorCoinAddressTR> outputs { get; set; }
    }
}
