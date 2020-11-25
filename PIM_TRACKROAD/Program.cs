using PIM_TRACKROAD.GUI;
using System;
using System.Windows.Forms;

namespace PIM_TRACKROAD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
