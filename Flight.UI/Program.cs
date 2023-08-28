using Flight.DataAccess.Repositories;
using Flight.DataAccess;
using Flight.Model;
using Flight.DataAccess.BaseClasses;

namespace Flight.UI
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
            Application.Run(new Initialize());
        }
    }
}