using System;
using System.Reflection;
using System.Windows.Forms;

namespace RSBot.Core
{
    public static class DoubleBuffer
    {
        /// <summary>
        /// Enable double buffer to any control ex gridview, flowlayout, tableLayout panel
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="DoubleBuffered"></param>
        public static void Set(Control ctl, bool DoubleBuffered)
        {
            try
            {
                typeof(Control).InvokeMember(
                    "DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null,
                    ctl,
                    new object[] { DoubleBuffered }
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
