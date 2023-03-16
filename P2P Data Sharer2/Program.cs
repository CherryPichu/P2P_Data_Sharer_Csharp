using System;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.GTK;
using Gtk;
using P2P_Data_Sharer2;

namespace GameOfLife.GTK
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Gtk.Application.Init();

            // Load the Glade file
            //var builder = new Builder("MainWindow.glade");
            //builder.AddFromFile("./MainWindow.glade");

            // Get the objects from the Glade file
            //var window = (Window)builder.GetObject("main_window");
            //var window = new MainWindow(builder);
            // Connect the button click event
            IntPtr appAddress = GetApplicationAddressFromAnotherProcess();
            var app = new Application(appAddress);

            var win = new MainWindow();
            app.AddWindow(win);

            win.Show();
            Application.Run();

        }
        static IntPtr GetApplicationAddressFromAnotherProcess()
        {
            // TODO: Implement method to get the address of the existing GTK# Application object
            return IntPtr.Zero;
        }
    }
}