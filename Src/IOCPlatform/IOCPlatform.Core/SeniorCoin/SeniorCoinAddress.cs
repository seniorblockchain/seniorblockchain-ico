using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOPlatform.Core.SeniorCoin
{
    public class SeniorCoinAddress
    {
        public string address { get; set; }
        public bool isUsed { get; set; }
        public bool isChange { get; set; }
        public long amountConfirmed { get; set; }
        public int amountUnconfirmed { get; set; }
    }

}

