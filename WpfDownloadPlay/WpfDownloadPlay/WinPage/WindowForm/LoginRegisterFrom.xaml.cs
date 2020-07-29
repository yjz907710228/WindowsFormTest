using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDownloadPlay.WinPage.WindowForm
{
    /// <summary>
    /// LoginFrom.xaml 的交互逻辑
    /// </summary>
    public partial class LoginRegisterFrom : Window
    {
        public LoginRegisterFrom()
        {
            InitializeComponent();
            ShowPage();
        }
        public void ShowPage()
        {
            this.frame_LoginRegister.Navigate(new Uri("/WinPage/PageTable/LoginPage.xaml", UriKind.Relative),UriKind.Relative);
        }

        public bool LoginJudge(string userAccountPhone,string password,string verificationCode)
        {
            bool flag = true;


            return flag;
        }
    }
}
