using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using SimpleInjector.Advanced;
using SimpleInjector.Diagnostics;
using System.Reflection;
using DataLayer.Data;
using ServiceLayer;
using Mosiac.UX;
using Microsoft.EntityFrameworkCore;
using System.Composition;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;


namespace Mosiac.UX
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Main());

            var host = Host.CreateDefaultBuilder()
             .ConfigureAppConfiguration((context, builder) =>
             {
                 // Add other configuration files...
                 builder.AddJsonFile("appsettings.local.json", optional: true);
             })
             .ConfigureServices((context, services) =>
             {
                 ConfigureServices(context.Configuration, services);
             })
             .ConfigureLogging(logging =>
             {
                 // Add other loggers...
             })
             .Build();

            var services = host.Services;
            var mainForm = services.GetRequiredService<Main>();
            Application.Run(mainForm);

        }


        private static void ConfigureServices(IConfiguration configuration,
            IServiceCollection services)
        {
            services.AddDbContext<MosaicContext>(options => 
                options.UseSqlServer("Server=192.168.10.34;database=Badger;uid=sa;pwd=Kx09a32x"));
           
            
            services.AddSingleton<Main>();
        }

        private static void CurrentDomainOnUnhadledException(object sender, UnhandledExceptionEventArgs e)
        {
            var message = String.Format("Sorry, something went wrong.\r\n" +
               "{0}\r\n" +
               "Please contact support at ext 106",
               ((Exception)e.ExceptionObject).Message);

            Console.WriteLine("ERROR {0}: {1}",
                DateTimeOffset.Now, e.ExceptionObject);

            MessageBox.Show(message, "Unexpected Error");
        }

        private static void ApplicationOnThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            var message = String.Format("Sorry, something went wrong.\r\n" +
                                        "{0}\r\n" +
                                        "Please contact support at ext 106",
                                        e.Exception.Message);

            Console.WriteLine("ERROR {0}: {1}",
                DateTimeOffset.Now, e.Exception);

            MessageBox.Show(message, "Unexpected Error");
        }

    }
}
