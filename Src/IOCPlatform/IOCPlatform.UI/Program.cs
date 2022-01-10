using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TronDotNet;
using ICOPlatform.UI.View;

namespace IOCPlatform
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();


            var services = new ServiceCollection();
            services.AddScoped<FrmAdressGen>();
            services.AddScoped<FrmMain>();
            services.AddScoped<FrmSeniorBlockchain>();
            ConfigureServices(services);


            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var frmAdressGen = serviceProvider.GetRequiredService<FrmSeniorBlockchain>();
                Application.Run(frmAdressGen);
            }


            //   Application.Run(new FrmAdressGen());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
             
            services.AddTronDotNet(x =>
            {
                x.Network = TronNetwork.MainNet;
                x.Channel = new GrpcChannelOption { Host = "3.225.171.164", Port = 50051 }; //https://developers.tron.network/docs/official-public-node
                x.SolidityChannel = new GrpcChannelOption { Host = "3.225.171.164", Port = 50061 }; //https://developers.tron.network/docs/official-public-node
                x.ApiKey = "e06b3c05-f11b-4221-a60c-705b5570b7fc"; //https://www.trongrid.io/
            });

            services.AddLogging();

        }
    }
}