using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bypass_GunaUI___Siticon
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        const string _GunaUi = @"Bypass_GunaUI___Siticon.Guna.UI2.dll";
        const string _SiticonUi = @"Bypass_GunaUI___Siticon.Siticone.Desktop.UI.dll";

        [STAThread]
        static void Main()
        {
            EmbeddedAssembly.Load(_GunaUi, _GunaUi.Replace("Bypass_GunaUI___Siticon", string.Empty));
            EmbeddedAssembly.Load(_SiticonUi, _SiticonUi.Replace("Bypass_GunaUI___Siticon", string.Empty));
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
