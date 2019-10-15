using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp
{
    public interface IWindow
    {
        void Main();
    }

    public class Program : IWindow
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new Form1() );
        }
    }
}
