using Syncfusion.SfSkinManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.Views.Pages
{
    public class BasePage : Page
    {
        public BasePage()
        {
            SfSkinManager.SetTheme(this, new Theme("Windows11Light"));
        }
    }
}
