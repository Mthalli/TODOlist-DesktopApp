using SQLitePCL;
using TODOlist_forms.Data;

namespace TODOlist_forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Batteries.Init();

            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Register());
            
        }
    }
}