using System;
using System.Windows.Forms;

namespace CerediraPackageManagerUI
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа в приложение
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
