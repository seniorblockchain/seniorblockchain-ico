 
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
        public Boolean _Add_Tbl_ERC20(tbl_ERC20 _TRC20)
        {
            try
            {
                DatabaseContext context = new DatabaseContext();
                context.Tbl_ERC20.Add(_TRC20);
                context.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }

        public Boolean _Add_Tbl_TRC20(tbl_TRC20 _TRC20)
        {
            try
            {
                DatabaseContext context = new DatabaseContext(); 
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
