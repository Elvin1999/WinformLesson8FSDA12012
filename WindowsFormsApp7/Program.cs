using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Presenters;
using WindowsFormsApp7.Views;

namespace WindowsFormsApp7
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            var view = new MainView();
            var presenter = new MainPresenter(view);

            Application.Run(view);

        }
    }
}
