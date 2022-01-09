using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;



namespace IOCPlatform.DataBase
{
   
    public class tbl_TRC20
    {
        [Key]
        public String Address { get; set; }
        public String Privatekey { get; set; }
        public String Publickey { get; set; }

        public Decimal Money { get; set; }

    }

    public class tbl_ERC20
    {
        [Key]
        public String Address { get; set; }
        public String Privatekey { get; set; }
       
        public Decimal Money { get; set; }
    }


}
