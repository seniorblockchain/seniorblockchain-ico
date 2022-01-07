 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace IOCPlatform.DataBase
{
    public class DatabaseProvider
    {
 
        public DatabaseProvider()
        {

                    
        }


        public Boolean _Add_Tbl_TRC20(tbl_TRC20 _TRC20)
        {
            try
            {


                DatabaseContext context = new DatabaseContext();

                //tbl_ERC20 _tbl_ERC20 = new tbl_ERC20()
                //{
                //    Address = Guid.NewGuid().ToString(),
                //    Privatekey = Guid.NewGuid().ToString(),
                //    Publickey = Guid.NewGuid().ToString(),
                //    Money = 0
                //};

                context.Tbl_TRC20.Add(_TRC20);
                context.SaveChanges();

                return true;
            }
            catch { }
            return false;
        }


        public List<tbl_TRC20> _Get_TRC20()
        {
            try
            {
                List<tbl_TRC20> _Allitem = new List<tbl_TRC20>();
                DatabaseContext context = new DatabaseContext();

                _Allitem = context.Tbl_TRC20.ToList();

                return _Allitem;
            }
            catch { }
            return new List<tbl_TRC20> { };
        }




    }
}
