using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gtk;
namespace P2P_Data_Sharer2
{
    public class MainWindow : Window
    {
        private HeaderBar _headerBar;

        public MainWindow(Builder builder) : base(builder.GetRawOwnedObject("MainWindow"))
        {
            _headerBar = builder.GetObject("HeaderBar") as HeaderBar;
            _headerBar.ShowCloseButton = true;

            DeleteEvent += (sender, args) => Application.Quit();
        }

        public MainWindow() : this(new Builder("MainWindow.glade"))
        {
        }
    }
   } 
