using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mosiac.UX.Services;
using System;
using System.Windows.Forms;


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
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhadledException;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


#if (DEBUG)

           //var services = new ServiceCollection();
           //ConfigureServices(services);
           // var builder = new HostBuilder()
           //     .ConfigureServices((hostContext, services) =>
           //     {
           //         services.AddDbContext<DataLayer.Data.MosaicContext>(ServiceLifetime.Singleton);
           //     });

           //builder.Build();

           Main mainForm = new Main();
            //TestForm mainForm = new TestForm();
            mainForm.LoggedOnUserID = 8;
            Globals.CurrentLoggedUserID = 8;
            Globals.CurrentUserName = "Richard";
            
            Application.Run(new TestForm());

#else

            DialogResult dr = new DialogResult();
            LoginForm loginForm = new LoginForm();

            dr = loginForm.ShowDialog();
            if (dr == DialogResult.OK)
            {

                Main mainForm = new Main();

                mainForm.LoggedOnUserID = loginForm.EmployeeID;
                Globals.CurrentLoggedUserID = loginForm.EmployeeID;
                Globals.CurrentUserName = loginForm.UserName;

                Application.Run(new Main());
            }

#endif



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

        public static void ConfigureServices(IServiceCollection services)
        {
           

            services.AddDbContext<DataLayer.Data.MosaicContext>(
                options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
        }

    }
}
