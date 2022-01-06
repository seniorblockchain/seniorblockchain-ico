using IPC.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPC
{
    public partial class FrmAdressGen : Form
    {
        public FrmAdressGen()
        {
            InitializeComponent();
        }

        private void Btn_Generat_Click(object sender, EventArgs e)
        {
            DatabaseProvider _db = new DatabaseProvider();


            tbl_TRC20 _tbl_TRC20 = new tbl_TRC20()
            {
                Address = Guid.NewGuid().ToString(),
                Privatekey = Guid.NewGuid().ToString(),
                Publickey = Guid.NewGuid().ToString(),
                Money = 0
            };


            if (_db._Add_Tbl_TRC20(_tbl_TRC20) == true)
            {
                _AddLog("Sucess Add");
            }
            else
            {
                _AddLog("Failed Add");

            }




            _AddLog("Total Record is : " + _db._Get_TRC20().Count().ToString());
        }

        private void _AddLog(string _input)
        {
            try
            {
                Txt_LiveLog.AppendText(_input + Environment.NewLine);
            }
            catch { }
        }
    }
}
