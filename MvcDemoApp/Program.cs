using System;
using System.Windows.Forms;
using MvcDemoApp.Model;
using MvcDemoApp.View;
using MvcDemoApp.Controller;
using System.DirectoryServices.ActiveDirectory;

namespace MvcDemoApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = new PersonModel();// new MainController();
            var view = new MainForm();// new MainForm();
            var controller = new MainController(model, view);

            Application.Run(view);
        }
    }
}

