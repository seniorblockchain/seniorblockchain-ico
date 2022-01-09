using IOCPlatform.DataBase;
using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOPlatform.Core
{
    public class CoreTRC20
    {

        public CoreTRC20()
        {
            CreateThreadConstructor();
        }

        Thread thread2;
        Boolean _Status = false;

        private void CreateThreadConstructor()
        {
            try
            {
                thread2 = null;
            }
            catch { }

            thread2 = new Thread(new ThreadStart(_ScanCoreTRC20));
            thread2.IsBackground = true;
            _Status = false;
        }


        #region Thread

        public void Start()
        {
            _Status = true;
            thread2.Start();

        }



        public void Stop()
        {
            _Status = false;

            try
            {
                thread2.Interrupt();
            }
            catch { }



            try
            {
                thread2.Abort();
            }
            catch { }
            try
            {
                thread2 = null;
            }
            catch { }

            CreateThreadConstructor();

        }

        public void Resume()
        {
            try
            {
                thread2.Resume();
            }
            catch { }

        }

        public void Puse()
        {
            try
            {
                thread2.Suspend();
            }
            catch { }

        }

        public void Abort()
        {
            _Status = false;
            try
            {
                thread2.Abort();
            }
            catch { }
            try
            {
                thread2 = null;
            }
            catch { }



        }

        #endregion


        public delegate void EvenOnBeforScan();
        public event EvenOnBeforScan OnBeforScan;

        public delegate void EvenOnFinish(String _Input);
        public event EvenOnFinish OnFinish;


        public delegate void EvenOnCheckAddress(tbl_TRC20 _tbl_TRC20);
        public event EvenOnCheckAddress OnCheckAddress;


        public HttpBuilder _HttpBuilder;


        private async void _ScanCoreTRC20()
        {
            try
            {
                _HttpBuilder = new HttpBuilder();
                _HttpBuilder.UseProxy = false;
                _HttpBuilder._CreateBuilder();
            }
            catch { }





          //  _HttpBuilder._BuildRequst().Get("");
        }



    }
}
