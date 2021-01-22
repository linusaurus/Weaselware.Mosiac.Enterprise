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

            var container = Bootstrap();

            Application.Run(container.GetInstance<Main>());
        }

        class ImportPropertySelectionBehavior : IPropertySelectionBehavior
        {
            public bool SelectProperty(Type implementationType, PropertyInfo prop) =>
                prop.GetCustomAttributes(typeof(ImportAttribute)).Any();
        }

        private static Container Bootstrap()
        {
            // Create the container as usual.
            var container = new Container();
            container.Options.PropertySelectionBehavior = new ImportPropertySelectionBehavior();

            // Register your types, for instance:
            container.Register<IOrderReceiptRepository, OrderReceiptRepository>(Lifestyle.Singleton);
            
           

            AutoRegisterWindowsForms(container);

            container.Verify();

            return container;
        }

        private static void AutoRegisterWindowsForms(Container container)
        {
            var types = container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            {
                var registration =
                    Lifestyle.Transient.CreateRegistration(type, container);

                registration.SuppressDiagnosticWarning(
                    DiagnosticType.DisposableTransientComponent,
                    "Forms should be disposed by app code; not by the container.");

                container.AddRegistration(type, registration);
            }
        }

    }
}
