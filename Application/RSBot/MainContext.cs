using RSBot.Core.Components;
using RSBot.Core;
using RSBot.Views;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace RSBot
{
    public class MainContext : ApplicationContext
    {
        private int _openForms = 2;

        public MainContext(SplashScreen splashScreen, MainLegacy mainForm)
        {
            var ci = CultureInfo.InstalledUICulture;
            Kernel.Language = ci.Name.Replace("-", "_");
            LanguageManager.LoadLanguage("RSBot", Kernel.Language);
            splashScreen.Show();
            splashScreen.FormClosed += (s, args) =>
            {
                if (splashScreen.Completed == 1)
                {
                    mainForm.Show();
                }
            };

            Form[] forms = { splashScreen, mainForm };
            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    if (Interlocked.Decrement(ref _openForms) == 0)
                        ExitThread();
                };
            }
        }
    }
}
