using System;
using System.Windows.Forms;

namespace Sitecore.CdpPracticeExamViewer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PracticeForm());
        }
    }
}
